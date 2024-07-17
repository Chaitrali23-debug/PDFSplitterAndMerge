using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.X509;
using iTextSharp.text.pdf.parser;
using Path = System.IO.Path;
using System.Threading;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PDFSplitterAndMerge
{
    public partial class Form1 : Form
    {
        static string folderPath = string.Empty;
        static string MilfolderPath = string.Empty;
        static string SCRAfolderPath = string.Empty;
        static string PCLfolderPath = string.Empty;
        public Form1()
        {
            InitializeComponent();

            // Find and initialize the PictureBox control
            loaderPictureBox = this.Controls.Find("loaderPictureBox", true).FirstOrDefault() as PictureBox;
            loaderPictureBox.Visible = false;
            loaderPictureBox.BackColor = Color.Transparent;
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        folderPath = folderBrowserDialog.SelectedPath;
                        string foldername = Path.GetFileName(folderBrowserDialog.SelectedPath);
                        txtFolderName.Text = foldername;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async void ShowLoader()
        {
            try
            {
                // Show the loader asynchronously
                await Task.Run(() =>
                {
                    loaderPictureBox.Invoke((MethodInvoker)delegate
                    {
                        loaderPictureBox.Visible = true;
                    });
                });

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnSplit_Click(object sender, EventArgs e)
        {
            // Show the loader
            ShowLoader();
            try
            {
                string txtcomppth = txtFolderName.Text;
                if(txtcomppth == "")
                {
                    MessageBox.Show("Please select Complaint folder");
                    HideLoader();
                }
                else
                {
                    string[] pdfFiles = Directory.GetFiles(folderPath, "*.pdf");
                    if (pdfFiles.Count() != 0)
                    {

                        foreach (string pdfFile in pdfFiles)
                        {
                            // Start the PDF splitting process asynchronously
                            await SplitPDF(pdfFile);
                        }
                        MessageBox.Show("PDF files have been split successfully.");
                        // Hide the loader
                        HideLoader();
                    }
                    else
                    {
                        MessageBox.Show("Folder does not contain any pdf files.");
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        // Complete folder files splitting
        private async Task SplitPDF(string pdfFilePath)
        {
            try
            {
                // Simulate the splitting process with a delay
                await Task.Delay(1000);

                string nextLine = string.Empty;
                string fileNumber = string.Empty;
                string formattedDate = string.Empty;
                string secondLastLine=string.Empty;
                DateTime date;
                using (PdfReader reader = new PdfReader(pdfFilePath))
                {
                    // Iterate through each page
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        // Extract the text from the current page
                        string pageText = PdfTextExtractor.GetTextFromPage(reader, i);

                        // Split the text into separate lines
                        string[] lines = pageText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        
                        for(int j= lines.Length-1; j >= 0; j--)
                        {
                            // Split the line into words
                            string[] words = lines[j].Split(' ');

                            // Get the last word
                            string lastWord = words[words.Length - 2];

                            string flno= words[words.Length - 1];

                            // Parse the last word as a DateTime
                            if (DateTime.TryParse(lastWord, out DateTime date1))
                            {
                                // Convert the DateTime to the "yyyymmdd" format
                                 formattedDate = date1.ToString("yyyyMMdd");
                            }
                            else
                            {
                                if (lastWord.Length == 7 && int.TryParse(lastWord, out _))
                                {
                                    fileNumber = lastWord;
                                }
                            }

                            if (fileNumber != "" && formattedDate != "")
                            {
                                // Create a new document for the current page        
                                using (Document document = new Document(reader.GetPageSizeWithRotation(i)))
                                {
                                    string directoryname = Path.GetDirectoryName(pdfFilePath);
                                    string outputFilePath = Path.Combine(directoryname, $"{fileNumber}_C_{formattedDate}.pdf");

                                    // Create a PdfCopy instance to copy the page to a new document
                                    using (PdfCopy copy = new PdfCopy(document, new FileStream(outputFilePath, FileMode.Create)))
                                    {
                                        document.Open();

                                        // Copy the current page to the new document
                                        copy.AddPage(copy.GetImportedPage(reader, i));

                                        document.Close();
                                    }
                                }
                                
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void HideLoader()
        {
            try
            {
                // Hide the loader asynchronously
                await Task.Run(() =>
                {
                    loaderPictureBox.Invoke((MethodInvoker)delegate
                    {
                        loaderPictureBox.Visible = false;
                    });
                });

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnSplitAndMerge_Click(object sender, EventArgs e)
        {
            ShowLoader();
            try
            {
                if ((txtmilitary.Text != "") && (txtscrpath.Text != ""))
                {


                    string[] pdfFiles = Directory.GetFiles(MilfolderPath, "*.pdf");
                    string[] pdfFiless = Directory.GetFiles(SCRAfolderPath, "*.pdf");
                    if (pdfFiles.Count() != 0 && pdfFiless.Count()!=0)
                    {

                        foreach (string pdfFile in pdfFiles)
                        {
                            // Start the PDF splitting process asynchronously
                            await ProcessPdf(pdfFile, MilfolderPath, SCRAfolderPath); //,SCRAfolderPath

                            //SplitPDFSecProc(pdfFile, MilfolderPath);
                        }
                        MessageBox.Show("PDF files have been split successfully.");
                        // Hide the loader
                        HideLoader();
                    }
                    else
                    {
                        MessageBox.Show("Folder does not contain any pdf files.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter military and scra fields");
                    // Hide the loader
                    HideLoader();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMilitary_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        MilfolderPath = folderBrowserDialog.SelectedPath;
                        string foldername = Path.GetFileName(folderBrowserDialog.SelectedPath);
                        txtmilitary.Text = foldername;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        SCRAfolderPath = folderBrowserDialog.SelectedPath;
                        string foldername = Path.GetFileName(folderBrowserDialog.SelectedPath);
                        txtscrpath.Text = foldername;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task ProcessPdf(string pdfFilePath, string militaryFolderPath, string scraFolderPath)
        {
            try
            {
                // Step 1: Read the original PDF file and split by file numbers
                PdfReader reader = new PdfReader(pdfFilePath);
                int pageCount = reader.NumberOfPages;
                string formattedDate = string.Empty;
                DateTime date;
                string lastLine = string.Empty;
                string[] fileno = new string[pageCount];
                int flnoarrindex = 0;
                for (int page = 1; page <= pageCount; page++)
                {
                    // Extract text from each page
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, page);

                    // Find and extract the file number (assuming it's at the end)
                    string[] lines = pageText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    // Search for "DATED" in one line and the date in the next line
                    for (int i = 0; i < lines.Length-1; i++)
                    {
                        string currentLine = lines[i].Trim();
                        string nextLine = lines[i + 1].Trim();

                        Regex regex1 = new Regex(@"^([A-Za-z]+ \d{1,2}, \d{4})$");
                        Match match1 = regex1.Match(currentLine);

                        string dateString1 = currentLine.Trim();

                        if (DateTime.TryParseExact(dateString1, "MMMM dd, yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                        {
                            // Format the date as "yyyyMMdd"
                            formattedDate = date.ToString("yyyyMMdd");
                            //return formattedDate;
                        }

                        string[] words = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length > 0)
                        {
                            string fno = words[0];

                            if (fno.Length == 7 && int.TryParse(fno, out _))
                            {
                                string fileNumber = words[words.Length - 1];
                                fileno[flnoarrindex] = fileNumber.Trim();
                                flnoarrindex = flnoarrindex + 1;
                            }

                        }
                    }
                }

                for (int i = 0; i < fileno.Length-1 ; i++)
                {
                    int startPage;
                    int endPage;
                    string outputFilePath = string.Empty;
                    string scraFilePath = string.Empty;
                    if (fileno[i] != null)
                    {
                        if (fileno[i] == fileno[i + 1])
                        {
                            startPage = i;
                            endPage = i + 1;                            

                            // Step 2: Search and merge from the scra folder
                            scraFilePath = Path.Combine(scraFolderPath, "MILT_" + fileno[i] + "_D1" + ".pdf");
                            //MergeFiles(outputFilePath, scraFilePath);

                            if (File.Exists(scraFilePath))
                            {
                                outputFilePath = Path.Combine(militaryFolderPath, fileno[i] + "_MSCAFF_" + formattedDate + ".pdf");

                                SplitPage(reader, startPage + 1, endPage + 1, outputFilePath, scraFilePath);
                            }
                            else
                            {
                                string directorypath = militaryFolderPath + "\\" + "_Exception";
                                if(!Directory.Exists(directorypath))
                                    Directory.CreateDirectory(directorypath);
                                outputFilePath = Path.Combine(directorypath, fileno[i] + "_MSCAFF_" + formattedDate + ".pdf");
                                AddInExceptionFolder(reader, startPage + 1, endPage + 1, outputFilePath);
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }            
        }
        
        //Add in exception folder inside the military folder.
        //if the military file number not find in scra folder.
        private void AddInExceptionFolder(PdfReader reader, int StartpageNumber, int EndpageNumber, string outputFilePath)
        {
            try
            {
                Document doc = new Document();
                PdfCopy copy = new PdfCopy(doc, new FileStream($"{outputFilePath}", FileMode.Create));
                doc.Open();
                // Merge original page from military folder
                for (int page = StartpageNumber; page <= EndpageNumber; page++)
                {                   
                   
                    PdfImportedPage importedPage = copy.GetImportedPage(reader, page);
                    copy.AddPage(importedPage);
                }
                doc.Close();
                copy.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Merge and split pdf files from military folder and scra folder
        private void SplitPage(PdfReader reader, int StartpageNumber, int EndpageNumber, string outputFilePath,string scraFilePath)
        {
            try
            {
                //Read content from scra file
                PdfReader scraReader = new PdfReader(scraFilePath);
                int scraPageCount = scraReader.NumberOfPages;
                Document doc = new Document();
                PdfCopy copy = new PdfCopy(doc, new FileStream(Path.Combine(outputFilePath), FileMode.Create));
                doc.Open();
                // Merge original page from military folder
                for (int page = StartpageNumber; page <= EndpageNumber; page++)
                {
                    PdfImportedPage importedPage = copy.GetImportedPage(reader, page);
                    copy.AddPage(importedPage);
                }


                // Merge scra pages
                for (int scraPage = 1; scraPage <= scraPageCount; scraPage++)
                {
                    copy.AddPage(copy.GetImportedPage(scraReader, scraPage));
                }

                doc.Close();
                scraReader.Close();
            }
            catch (Exception)
            {

                throw;
            }            
        }

        private void btnSelectPcl_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        PCLfolderPath = folderBrowserDialog.SelectedPath;
                        string foldername = Path.GetFileName(folderBrowserDialog.SelectedPath);
                        txtpclpath.Text = foldername;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnsplitpclfiles_Click(object sender, EventArgs e)
        {
            ShowLoader();
            try
            {
                string txtcomppth = txtpclpath.Text;
                if (txtcomppth == "")
                {
                    MessageBox.Show("Please select PCL folder");
                    HideLoader();
                }
                else
                {
                    string[] pdfFiles = Directory.GetFiles(PCLfolderPath, "*.pdf");
                    if (pdfFiles.Count() != 0)
                    {
                        foreach (string pdfFile in pdfFiles)
                        {

                            // Start the PDF splitting process asynchronously
                            await SplitPCLPDF(pdfFile);
                        }
                        MessageBox.Show("PDF files have been split successfully.");
                        // Hide the loader
                        HideLoader();
                    }
                    else
                    {
                        MessageBox.Show("Folder does not contain any pdf files.");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task SplitPCLPDF(string pdfFilePath)
        {
            ShowLoader();
            try
            {
                // Simulate the splitting process with a delay
                await Task.Delay(1000);

                string nextLine = string.Empty;
                string fileNumber = string.Empty;
                string formattedDate = string.Empty;
                string sfileNumber = string.Empty;
                string sformattedDate = string.Empty; string lastLine = string.Empty; 
                int flnoarrindex = 0;
                DateTime date;
                using (PdfReader reader = new PdfReader(pdfFilePath))
                {
                    string[] fileno = new string[reader.NumberOfPages];
                    // Iterate through each page
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        // Extract the text from the current page
                        string pageText = PdfTextExtractor.GetTextFromPage(reader, i);

                        // Split the text into separate lines
                        string[] lines = pageText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int j = 0; j < lines.Length - 1; j++)
                        {

                            string currentLine = lines[j].Trim();
                             nextLine = lines[ j+ 1].Trim();

                            string[] words = lines[j].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            string regex1 = @"^(0[1-9]|1[0-9]|2[0-9]|3[01])/(0[1-9]|1[0-2])/([0-9]{4})$";
                            string pattern = @"^\d{7}$";
                            foreach (string word in words)
                            {
                                Match match1 = Regex.Match(word,regex1);
                                Match match2=Regex.Match(word,pattern);
                                if (match1.Success)
                                {
                                    date = Convert.ToDateTime(match1.Value);
                                    //if (DateTime.TryParseExact(match1.Value, "mm/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                                    //{
                                        // Format the date as "yyyyMMdd"
                                        formattedDate = date.ToString("yyyyMMdd");
                                        //return formattedDate;
                                    //}

                                    
                                }
                                if (match2.Success)
                                {
                                    fileNumber = match2.Value;
                                    fileno[flnoarrindex] = fileNumber.Trim();
                                    flnoarrindex = flnoarrindex + 1;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < fileno.Length - 1; i++)
                    {
                        int startPage;
                        int endPage;
                        string outputFilePath = string.Empty;
                        string scraFilePath = string.Empty;
                        if (fileno[i] != null)
                        {                          
                            
                            startPage = i;
                            outputFilePath = Path.Combine(PCLfolderPath, fileno[i] + "_PCL_" + formattedDate + ".pdf");
                            PclSplitPage(reader, startPage + 1, outputFilePath);
                            endPage = i + 1;
                            outputFilePath = Path.Combine(PCLfolderPath, fileno[i+1] + "_OTH_" + formattedDate + ".pdf");
                            PclSplitPage(reader, endPage + 1, outputFilePath);

                             i+= 1;
                            
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void PclSplitPage(PdfReader reader, int pageNumber, string outputFilePath)
        {
            using (var doc = new Document())
            {
                using (var copy = new PdfCopy(doc, new FileStream(outputFilePath, FileMode.Create)))
                {
                    doc.Open();
                    copy.AddPage(copy.GetImportedPage(reader, pageNumber));
                }
            }
        }
    }
}

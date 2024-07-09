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
                string[] pdfFiles = Directory.GetFiles(folderPath, "*.pdf");
                if (pdfFiles.Count() != 0)
                {

                    foreach (string pdfFile in pdfFiles) { 
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

                        // Iterate through each line
                        for (int j = 0; j < lines.Length; j++)
                        {
                            // Check if the line contains the desired file number
                            if (lines[j].Contains("Efile"))
                            {
                                // Check if the next line exists
                                if (j + 1 < lines.Length)
                                {
                                    // Retrieve the next line (7 digits)
                                    nextLine = lines[j + 1];

                                    // Extract the file number from the next line
                                    fileNumber = nextLine.Substring(0, 7);

                                }
                            }
                            if (lines[j].Contains("DATE"))
                            {
                                // Find the index of "DATE:"
                                int dateIndex = lines[j].IndexOf("DATE:");

                                if (dateIndex != -1)
                                {
                                    // Extract the date substring
                                    string dateSubstring = lines[j].Substring(dateIndex + 5).Trim();

                                    // Parse the date in MM/dd/yyyy format

                                    if (DateTime.TryParseExact(dateSubstring, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                                    {
                                        // Format the date as yyyyMMdd
                                        formattedDate = date.ToString("yyyyMMdd");

                                    }
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
                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        string currentLine = lines[i].Trim();
                        string nextLine = lines[i + 1].Trim();

                        // Check if current line contains "DATED"
                        if (currentLine.StartsWith("DATED"))
                        {
                            // Extract date from the next line
                            Regex regex = new Regex(@"^([A-Za-z]+ \d{1,2}, \d{4})$");
                            Match match = regex.Match(nextLine);

                            //if (match.Success)
                            //{
                            string dateString = nextLine.Trim();//.Substring(dateIndex + 5).Trim(); //match.Groups[1].Value;

                            // Parse the extracted date string
                            //DateTime date;
                            if (DateTime.TryParseExact(dateString, "MMMM d,yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                            {
                                // Format the date as "yyyyMMdd"
                                formattedDate = date.ToString("yyyyMMdd");
                                //return formattedDate;
                            }
                        }
                    }

                    lastLine = lines[lines.Length - 1].Trim();

                    if (!string.IsNullOrEmpty(lastLine))
                    {
                        string[] words = lastLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string fileNumber = words[words.Length - 1];
                        fileno[flnoarrindex] = fileNumber.Trim();
                        flnoarrindex = flnoarrindex + 1;
                    }
                }

                for (int i = 0; i < fileno.Length; i++)
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

                            outputFilePath = Path.Combine(militaryFolderPath, fileno[i] + "_MSCAFF_" + formattedDate + ".pdf");


                            // Step 2: Search and merge from the scra folder
                            scraFilePath = Path.Combine(scraFolderPath, "MILT_" + fileno[i] + "_D1" + ".pdf");
                            //MergeFiles(outputFilePath, scraFilePath);

                            if (File.Exists(scraFilePath))
                            {
                                SplitPage(reader, startPage + 1, endPage + 1, outputFilePath, scraFilePath);
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

                        for(int j=0; j < lines.Length; j++)
                        {
                            string currentLine = lines[j].Trim();
                            if(j+1 < lines.Length)
                            {
                                nextLine = lines[j + 1].Trim();
                            }
                             

                            if (currentLine.StartsWith("DATE SIGNED"))
                            {
                                // Extract date from the next line
                                Regex regex = new Regex(@"^([A-Za-z]+ \d{1,2}, \d{4})$");
                                Match match = regex.Match(nextLine);

                                string dateString = nextLine.Trim();//.Substring(dateIndex + 5).Trim(); //match.Groups[1].Value;

                                // Parse the extracted date string
                                if (DateTime.TryParseExact(dateString, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                                {
                                    // Format the date as "yyyyMMdd"
                                    formattedDate = date.ToString("yyyyMMdd");
                                    //return formattedDate;
                                }
                            }
                            else if (currentLine.StartsWith("eFiling"))
                            {
                                fileNumber = nextLine.Substring(0, 7);
                            }
                            else if (currentLine.StartsWith("Date"))
                            {
                                // Find the index of "DATE:"
                                int dateIndex = lines[j].IndexOf("Date:");

                                if (dateIndex != -1)
                                {
                                    // Extract the date substring
                                    string dateSubstring = lines[j].Substring(dateIndex + 5).Trim();

                                    // Parse the date in MM/dd/yyyy format

                                    if (DateTime.TryParseExact(dateSubstring, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                                    {
                                        // Format the date as yyyyMMdd
                                        sformattedDate = date.ToString("yyyyMMdd");

                                    }
                                }
                            }
                            lastLine = lines[lines.Length - 1].Trim();
                            if (!string.IsNullOrEmpty(lastLine))
                            {
                                string[] words = lastLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                sfileNumber = words[words.Length - 1];
                            }

                            if(fileNumber != "" && formattedDate != "")
                            {
                                string directoryname = Path.GetDirectoryName(pdfFilePath);
                                string outputFilePath = Path.Combine(directoryname, $"{fileNumber}_PCL_{formattedDate}.pdf");
                                PclSplitPage(reader, i, outputFilePath);
                                fileNumber = "";formattedDate = "";
                            }
                            else if(sfileNumber != "" && sformattedDate != "")
                            {
                                string directoryname = Path.GetDirectoryName(pdfFilePath);
                                string outputFilePath = Path.Combine(directoryname, $"{sfileNumber}_OTH_{sformattedDate}.pdf");
                                PclSplitPage(reader, i, outputFilePath);sfileNumber = "";sformattedDate = "";
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

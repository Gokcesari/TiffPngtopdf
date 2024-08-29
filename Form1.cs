using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using Tesseract;
using iText.Layout.Renderer;
using iText.Layout.Element;

namespace Tiff2PDF
{
    public partial class Form1 : Form
    {

        public String tiffDir = "";
        string[] tiffFiles;


        public Form1()
        {
            InitializeComponent();
        }

        public void chooseTiffDir()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tiffDir = fbd.SelectedPath;

                tiffFiles = Directory.GetFiles(@tiffDir, "*.tif");
                if (tiffFiles.Length == 0)
                {
                    rtb.AppendText("\nNo Tiff Files in" + tiffDir);
                    DialogResult dr = MessageBox.Show("Would you like to select another directory?", "No Tiff Files Found!", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            chooseTiffDir();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
                else
                {   // rtb is the RichTextBox
                    //ltbx is the ListBox
                    //textbx is the TextBox

                    rtb.AppendText("\n" + tiffFiles.Length + " Tiff File(s) Found");
                    tbxFolderPath.Text = fbd.SelectedPath;
                    for (int i = 0; i < tiffFiles.Length; i++)
                    {
                        lstbx.Items.Add(tiffFiles[i].Substring(tbxFolderPath.Text.Length + 1));
                        rtb.AppendText("\n" + tiffFiles[i].Substring(tbxFolderPath.Text.Length + 1) + " found!");
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb.AppendText("Launch: Successful");

        }

        private void btn_tiffDir_Click(object sender, EventArgs e)
        {
            chooseTiffDir();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            chooseTiffDir();


        }


        private void button_Click(object sender, EventArgs e)
        {
            string folderPath = tbxFolderPath.Text;
            var files = Directory.GetFiles(folderPath, ".");

            if (files == null)
            {
                MessageBox.Show("Dosya bulunamadı");
                return;
            }


            foreach (var file in files)
            {
                SearchablePdfCreate(file, Path.ChangeExtension(file, "pdf"), "tur");

                rtb.AppendText(file + " PDF oluşturuldu");
            }

        }
       

            public void SearchablePdfCreate(string inputName, string outputName, string dil)
            {
                int sayfaSayisi = 0;
                int toplamSayfa = 0;
                using (IResultRenderer renderer = Tesseract.PdfResultRenderer.CreatePdfRenderer(outputName, @"./tessdata", false))
                {
                    // PDF Title
                    using (renderer.BeginDocument(outputName))
                    {
                        using (TesseractEngine engine = new TesseractEngine(AppContext.BaseDirectory + "tessdata\\", dil, EngineMode.Default))
                        {
                            using (PixArray pages = PixArray.LoadMultiPageTiffFromFile(inputName))
                            {
                                toplamSayfa = pages.Count;
                                foreach (Pix p in pages)
                                {
                                    Application.DoEvents();
                                    using (var page = engine.Process(p, outputName))
                                    {
                                        renderer.AddPage(page);
                                        sayfaSayisi++;
                                    }
                                }

                            }
                        }
                    }
                }
            }



        }
    }




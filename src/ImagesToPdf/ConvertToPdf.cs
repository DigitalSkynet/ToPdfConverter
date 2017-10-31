using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImagesToPdf
{
    public partial class ConvertToPdf : Form
    {
        public ConvertToPdf()
        {
            InitializeComponent();

        }

        private void ConvertToPdf_Load(object sender, EventArgs e)
        {
            try
            {
                var args = Environment.GetCommandLineArgs();
                //MessageBox.Show("Started", "Debug", MessageBoxButtons.OK);

                var fullPath = string.Join(" ", args.Skip(1).ToArray());
                var ext = Path.GetExtension(fullPath);
                var pdfPath = fullPath.Replace(ext, ".pdf");

                try
                {
                    Document document = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    //MessageBox.Show(fullPath + "\r\n" + pdfPath, "Debug", MessageBoxButtons.OK);
                    using (var stream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        using (var imageStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            var image = Image.GetInstance(imageStream);

                            Image jpg = Image.GetInstance(image);
                            //Resize image depend upon your need
                            jpg.ScaleToFit(document.PageSize);
                            //Give space before image

                            jpg.Alignment = Element.ALIGN_LEFT;
                            document.Add(jpg);
                        }
                        document.Close();
                    }
                }
                catch
                {
                    if (File.Exists(pdfPath))
                    {
                        File.Delete(pdfPath);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Debug", MessageBoxButtons.OK);
            }
            finally
            {
                Application.Exit();
            }

        }
    }
}

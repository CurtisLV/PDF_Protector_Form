using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using static System.Net.WebRequestMethods;

namespace PDF_Protector_Form;

public partial class PDF_Protector : Form
{
    public PDF_Protector()
    {
        InitializeComponent();

        this.folderPathTextBox.DragDrop += new DragEventHandler(PDF_Protector_DragDrop);
        this.folderPathTextBox.DragEnter += new DragEventHandler(PDF_Protector_DragEnter);
    }

    private void applyPasswordButton_Click(object sender, EventArgs e)
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        string fullPath = folderPathTextBox.Text;
        // TODO - validate path and password (at least if !null)
        if (Directory.Exists(fullPath) && clientPasswordTextBox.Text != "")
        {
            // filter by pdf
            string[] filePaths = Directory.GetFiles(fullPath, "*.pdf");

            // loop through folder in folderPath
            PdfDocument document = new PdfDocument();
            
            foreach (string file in filePaths)
            {
                string clientPassword = clientPasswordTextBox.Text;
                document = PdfReader.Open(file, "");
                PdfSecuritySettings securitySettings = document.SecuritySettings;
                securitySettings.UserPassword = clientPassword;
                document.Save(file);
                // count how many processed?
                // report that process dones TODO
                Debug.WriteLine($"PW applied to: {Path.GetFileName(file)}");
            }

            // if pdf - apply client password, but msgbox to confirm that this password to this folder?
            //try
            //{
            //    document = PdfReader.Open(file, "invalid password");
            //}
            //catch (Exception exception)
            //{
            //    Debug.WriteLine(exception.Message);
            //}
            
            
            MessageBox.Show("Password applied to .PDFs!", "Done with PDF!", MessageBoxButtons.OK);
        }


        // else msgbox
    }

    private void PDF_Protector_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.All;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        } 
    }

    private void PDF_Protector_DragDrop(object sender, DragEventArgs e)
    {
        string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
        string fullPath = s.First().ToString();

        if (Path.GetExtension(fullPath).ToLower() == ".pdf")
        {
            folderPathTextBox.Text = Path.GetDirectoryName(fullPath);
        } else
        {
            MessageBox.Show("Draggd file is not a PDF!\nPlease drag a .pdf file!", "Drag a PDF!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
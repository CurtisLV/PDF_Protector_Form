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

        if (Directory.Exists(fullPath) && clientPasswordTextBox.Text != "")
        {
            // get all .pdfs
            string[] filePaths = Directory.GetFiles(fullPath, "*.pdf");
            int initialPDFcount = filePaths.Length;
            int countPDFs = 0;
            string openPassword = "";
            string closePassword = "";
            string passwordMsg = "";

            if (addRadioBtn.Checked)
            {
                openPassword = "";
                closePassword = clientPasswordTextBox.Text;
                passwordMsg = "applied to";
            }
            else if (removeRadioBtn.Checked)
            {
                openPassword = clientPasswordTextBox.Text;
                passwordMsg = "removed from";
            }

            // loop through folder in folderPath
            PdfDocument document = new PdfDocument();
            
            foreach (string file in filePaths)
            {
                try
                {
                    document = PdfReader.Open(file, openPassword);
                }
                catch (Exception exception)
                {
                    continue;
                }

                if (addRadioBtn.Checked) // if pw to removed, no need to save even with empty password
                {
                    PdfSecuritySettings securitySettings = document.SecuritySettings;
                    securitySettings.UserPassword = closePassword;
                }
                document.Save(file);
                // count how many processed for comparison
                countPDFs++;
            }
            // user advised how much files in folder and how much got new password
            MessageBox.Show($"There are {initialPDFcount} PDFs in the folder. Password {passwordMsg} {countPDFs} PDFs!\nIf numbers don't match, some PDFs had (different) password or were corrupted already before!", "Done with PDFs!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // else do nothing

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
            MessageBox.Show("Dragged file is not a PDF!\nPlease drag a .pdf file!", "Drag a PDF!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
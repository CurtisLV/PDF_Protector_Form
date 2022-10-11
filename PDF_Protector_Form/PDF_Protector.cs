using System.IO;

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
        string fullPath = folderPathTextBox.Text;
        // TODO - validate path and password (at least if !null)
        if (Directory.Exists(fullPath) && clientPasswordTextBox.Text != "")
        {
            string[] filePaths = Directory.GetFiles(fullPath, "*.pdf");
            // loop through folder in folderPath
            // filter by pdf?
            // if pdf - apply client password, but msgbox to confirm that this password to this folder?
            // count how many processed?
            // report that process done
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
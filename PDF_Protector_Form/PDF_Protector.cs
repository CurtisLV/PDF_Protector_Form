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
        folderPathTextBox.Text = Path.GetDirectoryName(s.First().ToString());
    }
}
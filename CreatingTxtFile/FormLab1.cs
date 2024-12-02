using static System.Net.Mime.MediaTypeNames;

namespace CreatingTxtFile
{
    public partial class FormLab1 : Form
    {
        public FormLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName Frm = new FrmFileName();
            Frm.ShowDialog();

            string getInput = txtInput1.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
            

            //FrmRegistration frmRegistration = new FrmRegistration();
            //frmRegistration.ShowDialog();
        }
    }
}

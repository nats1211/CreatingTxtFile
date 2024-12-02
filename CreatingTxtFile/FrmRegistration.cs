using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTxtFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] content = {"Student No.: " + txtStudentNo.Text ,
            "Full Name: " + txtLastName.Text + "," + txtFirstName.Text + "," + txtMI.Text, "Program: " + cbProgram.Text ,
            "Gender: " + cbGender.Text, "Age: " + txtAge.Text, "Birthday: " + Birthdate.Text,
            "Contact: " + txtContact.Text};


            string _fileName = txtStudentNo.Text + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, _fileName)))
            {
                foreach (string line in content)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }
}

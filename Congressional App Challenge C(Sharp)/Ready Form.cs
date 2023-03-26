using System;
using System.Windows.Forms;

namespace Congressional_App_Challenge_C_Sharp_
{
    public partial class Ready_Form : Form
    {
        public Ready_Form()
        {
            InitializeComponent();
        }
        private void Beginbut_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FTest test = new FTest();
            test.ShowDialog();
        } // Start Test

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

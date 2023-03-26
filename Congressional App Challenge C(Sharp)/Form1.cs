using System;
using System.Drawing;
using System.Windows.Forms;

namespace Congressional_App_Challenge_C_Sharp_
{

    public partial class F1 : Form
    {
        
        public F1()
        {         
            InitializeComponent();
        }
        private void InfoBut_Click(object sender, EventArgs e){
            Ready_Form info = new Ready_Form();
            info.ShowDialog();

        } // Info Button 
        private void StartBut_Click(object sender, EventArgs e){
            this.Hide();
            FTest test = new FTest();
            test.ShowDialog();  
        } // Start Button

        private void F1_Load(object sender, EventArgs e)
        {

        }
    }
}
 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congressional_App_Challenge_C_Sharp_
{
    public partial class Finish_Form : Form
    {
        public Finish_Form()
        {
            InitializeComponent();
            string remaining = System.IO.File.ReadAllText(@"E:\Congressional App Challenge C(Sharp)\Finish.txt");

            if (int.Parse(remaining) == 61)
            {
                Finbox.Text = "Time's Up!";
                System.IO.File.ReadAllText(@"E:\Congressional App Challenge C(Sharp)\Finish.txt").DefaultIfEmpty();
                Backbut.Visible = false;
                label1.Visible = false;
                Finbox.Dock = System.Windows.Forms.DockStyle.Top;
                Finishbut.Dock = System.Windows.Forms.DockStyle.Bottom;                
            }
            else
            {
                Finbox.Text = "You have: " + remaining + " questions left.";
                System.IO.File.ReadAllText(@"E:\Congressional App Challenge C(Sharp)\Finish.txt").DefaultIfEmpty();
            }
        } // Initialize

        private void Finishbut_Click(object sender, EventArgs e)
        {
            FTest master = (FTest)Application.OpenForms["FTest"];
            master.Hide();
            master.Tmr.Stop();
            this.Hide();
            ESbut result = new ESbut();
            result.ShowDialog();

        } // Finish Button
        private void Backbut_Click(object sender, EventArgs e)
        {
            this.Hide();
        } // Back Button

        private void Finbox_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Congressional_App_Challenge_C_Sharp_
{
    public partial class Question_Selector : Form
    {
     public Question_Selector()
        {
            InitializeComponent();
            string[] read = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt");
            string holder = "";
            for (int i = 0; i < 30; i++)
            {
                if (read[i] == "x")
                    holder += "☐\n";             
                else
                    holder += "🗹\n";
            }
            tbl.Text = holder;
            string holderx = "";
            for (int i = 30; i < 60; i++)
            {
                if (read[i] == "x")
                    holderx += "☐\n";
                else
                    holderx += "🗹\n";
            }
            tbr.Text = holderx;
        } // Initialize Form        
    private void button1_Click(object sender, EventArgs e)
        {

            bool done = false;
            string num = Gobox.Text;
            int x;

 
            while (done == false)
                {

                    if (num == "60")
                    {
                        System.IO.File.WriteAllText(@"E:\Congressional App Challenge C(Sharp)\WhereToGo.txt", num);                 
                    done = true;
                    }
                    if (num.Length < 2 && int.TryParse(num, out x))
                    {
                        System.IO.File.WriteAllText(@"E:\Congressional App Challenge C(Sharp)\WhereToGo.txt", num);
                    done = true;
                    }
                    else if (num.Length == 2)
                    {
                    if (int.TryParse(num, out x) && (num.Substring(0, 1) == "1" || num.Substring(0, 1) == "2" || num.Substring(0, 1) == "3" || num.Substring(0, 1) == "4" || num.Substring(0, 1) == "5"))
                        { 
                        System.IO.File.WriteAllText(@"E:\Congressional App Challenge C(Sharp)\WhereToGo.txt", num);
                        done = true;
                        }
                    }
              
                break;
                }
            if (done == true)
            {
                FTest master = (FTest)Application.OpenForms["FTest"];
                master.ConstantTic.Start();
                this.Hide();
            }
            else
                Gobox.Clear();
                
        } // GO Button

        private void Question_Selector_Load(object sender, EventArgs e)
        {

        }
    }
}

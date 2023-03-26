using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Congressional_App_Challenge_C_Sharp_
{
    public partial class ESbut : Form
    {
        public ESbut()
        {
            InitializeComponent();
            string[] answer = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Answer.txt"); // answers file
            string[] input = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt"); // user input file

           

            int correct = 0;

            string holder = "";
            for (int i = 0; i < 30; i++)
            {
                if (answer[i] == input[i]) { holder += "🗹\n"; correct++; }
                else if (input[i] == "x") holder += "■\n";
                else holder += "☐\n";
            } // make the boxes
            tbl.Text = holder;

            string holderx = "";
            for (int i = 30; i < 60; i++)
            {
                if (answer[i] == input[i]) { holderx += "🗹\n"; correct++; }
                else if (input[i] == "x") holderx += "■\n";
                else holderx += "☐\n";
            } // make the boxes
            tbr.Text = holderx;
           
            CorrectLabel.Text = "- Number Correct: " + correct.ToString();

            ProjectedACTLable.Text = ProjectedACTScore(correct);

            display(answer, input);
            
            
             


        }

        static string ProjectedACTScore(int correct)
        {
            if (correct > 58)
                return"- Projected ACT Score: 36";
            else if (correct > 56)
                return"- Projected ACT Score: 35";
            else if (correct > 54)
                return"- Projected ACT Score: 34";
            else if (correct > 53)
                return"- Projected ACT Score: 33";
            else if (correct > 51)
                return"- Projected ACT Score: 32";
            else if (correct > 49)
                return"- Projected ACT Score: 31";
            else if (correct > 48)
                return"- Projected ACT Score: 30";
            else if (correct > 46)
                return"- Projected ACT Score: 29";
            else if (correct > 44)
                return"- Projected ACT Score: 28";
            else if (correct > 42)
                return"- Projected ACT Score: 27";
            else if (correct > 40)
                return"- Projected ACT Score: 26";
            else if (correct > 37)
                return"- Projected ACT Score: 25";
            else if (correct > 35)
                return"- Projected ACT Score: 24";
            else if (correct > 33)
                return"- Projected ACT Score: 23";
            else if (correct > 32)
                return"- Projected ACT Score: 22";
            else if (correct > 30)
                return"- Projected ACT Score: 21";
            else if (correct > 28)
                return"- Projected ACT Score: 20";
            else if (correct > 26)
                return"- Projected ACT Score: 19";
            else if (correct > 23)
                return"- Projected ACT Score: 18";
            else if (correct > 18)
                return"- Projected ACT Score: 17";
            else if (correct > 14)
                return"- Projected ACT Score: 16";
            else if (correct > 11)
                return"- Projected ACT Score: 15";
            else if (correct > 56)
                return"- Projected ACT Score: 14";
            else if (correct > 9)
                return"- Projected ACT Score: 13";
            else if (correct > 7)
                return"- Projected ACT Score: 12";
            else if (correct > 5)
                return"- Projected ACT Score: 11";
            else if (correct > 4)
                return"- Projected ACT Score: 10";
            else if (correct > 3)
                return"- Projected ACT Score: 9";
            else if (correct > 2)
                return"- Projected ACT Score: 7";
            else if (correct > 1)
                return"- Projected ACT Score: 5";
            else if (correct > 0)
                return"- Projected ACT Score: 3";
            else
                return"- Projected ACT Score: 1";
        } // projected ACT score 


        void display(string[] answer, string[] input)
        {
            string[] NumbersAndQuantity = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\NumberAndQuantity.txt"); // Nnumbers and Quantities file
            string[] Algebra = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Algebra.txt"); // Algebra file
            string[] Functions = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Functions.txt"); // Functions file
            string[] Geometry = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Geometry.txt"); // Geometry file
            string[] EssentialSkills = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Essential Skills.txt"); // Essential Skills file

            

            int[] SectionCorrect = new int[5];
            

            for (int i = 0; i < NumbersAndQuantity.Length; i++)
            {
                if (answer[int.Parse(NumbersAndQuantity[i]) - 1] == input[int.Parse(NumbersAndQuantity[i]) - 1])
                    SectionCorrect[0]++;
            }
            for (int i = 0; i < Algebra.Length; i++)
            {
                if (answer[int.Parse(Algebra[i]) - 1] == input[int.Parse(Algebra[i]) - 1])
                    SectionCorrect[1]++;
            }
            for (int i = 0; i < Functions.Length; i++)
            {
                if (answer[int.Parse(Functions[i]) - 1] == input[int.Parse(Functions[i]) - 1])
                    SectionCorrect[2]++;
            }
            for (int i = 0; i < Geometry.Length; i++)
            {
                if (answer[int.Parse(Geometry[i]) - 1] == input[int.Parse(Geometry[i]) - 1])
                    SectionCorrect[3]++;
            }
            for (int i = 0; i < EssentialSkills.Length; i++)
            {
                
                if (answer[int.Parse(EssentialSkills[i]) - 1] == input[int.Parse(EssentialSkills[i]) - 1])
                    SectionCorrect[4]++;
            }

           

           for (int i = 0; i < 5; i++)
            {
               // SectionCorrect[i] *= 10;
            }

            

            if (SectionCorrect[4] == 0)
                EssentialSkillsLabel.Text = "-Essential Skills % Correct: 0%";
            else
            EssentialSkillsLabel.Text = "-Essential Skills % Correct: " + Math.Round(SectionCorrect[4] / (double)EssentialSkills.Length * 100, 2).ToString() + "%";

            if (SectionCorrect[3] == 0)
                GeometryLabel.Text = "-Geometry % Correct: 0%";
            else
                GeometryLabel.Text = "-Geometry % Correct: " + Math.Round(SectionCorrect[3] / (double)Geometry.Length * 100, 2).ToString() + "%";

            if (SectionCorrect[2] == 0)
                FunctionsLabel.Text = "-Functions % Correct: 0%";
            else
                FunctionsLabel.Text = "-Functions % Correct: " + Math.Round(SectionCorrect[2] / (double)Functions.Length * 100, 2).ToString() + "%";

            if (SectionCorrect[1] == 0)
            AlgebraLabel.Text = "-Algebra % Correct: 0%";
            else
                AlgebraLabel.Text = "-Algebra % Correct: " + Math.Round(SectionCorrect[1] / (double)Algebra.Length * 100, 2).ToString() + "%";

            if (SectionCorrect[0] == 0)
                NumsAndQuantityLabel.Text = "-Numbers & Quantity % Correct: 0%";
            else
                NumsAndQuantityLabel.Text = "-Numbers & Quantity % Correct: " + Math.Round(SectionCorrect[0] / (double)NumbersAndQuantity.Length * 100, 2).ToString() + "%";
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://actacademy.act.org/assessment/act-integrating-essential-skills-i/9485582");
            ESC.Visible = true;
            GC.Visible = false;
            FC.Visible = false;
            AC.Visible = false;
            NC.Visible = false;

        } // Essential Skills Button
        private void Gbut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.khanacademy.org/math/geometry");
            ESC.Visible = false;
            GC.Visible = true;
            FC.Visible = false;
            AC.Visible = false;
            NC.Visible = false;

        } // Geometry Button
        private void Fbut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.khanacademy.org/math/algebra-basics");
            ESC.Visible = false;
            GC.Visible = false;
            FC.Visible = true;
            AC.Visible = false;
            NC.Visible = false;

        } // Functions Button
        private void Abut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.khanacademy.org/math/algebra");
            ESC.Visible = false;
            GC.Visible = false;
            FC.Visible = false;
            AC.Visible = true;
            NC.Visible = false;

        } // Algebra Button
        private void NQbut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.khanacademy.org/math/algebra2");
            ESC.Visible = false;
            GC.Visible = false;
            FC.Visible = false;
            AC.Visible = false;
            NC.Visible = true;

        } // Numbers and Quantity Button

        private void Donebut_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void ESbut_Load(object sender, EventArgs e)
        {

        }
    }
}

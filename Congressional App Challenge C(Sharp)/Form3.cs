using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


    namespace Congressional_App_Challenge_C_Sharp_
    {

    public partial class FTest : Form
    {
        ///////////////////////Class Variables////////////////////////////////
        
            string[] spot = System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\QFile.txt");
            string[] answers = new string[60];
            int answerCount = 0;
            int seconds = 59;
            int minutes = 59;
            
        ///////////////////////Initialize////////////////////////////////

        public FTest()
            {
            InitializeComponent();
            Tmr.Start();
            pb.Image = Image.FromFile(@spot[0]);
            for (int i = 0; i < 60; i++)
            {
                answers[i] = "x";
            } // makes all spots x (meaning nothing is there)
        }
      
        ///////////////////////Timers////////////////////////////////

       
        private void Tmr_Tick(object sender, EventArgs e)
            {
                seconds--;
                if (seconds == -1)
                {
                    minutes--;
                    seconds = 59;
                }

                if (minutes >= 10)
                {
                    if (seconds >= 10)
                        Clock.Text = "Time Remaining: " + minutes + ":" + seconds;
                    else
                        Clock.Text = "Time Remaining: " + minutes + ":0" + seconds;
                }
                else
                {
                    if (seconds >= 10)
                        Clock.Text = "Time Remaining: 0" + minutes + ":" + seconds;
                    else
                        Clock.Text = "Time Remaining: 0" + minutes + ":0" + seconds;
                }

                if (minutes == 0 && seconds == 0)
                {
                Tmr.Stop();
                Finishbut_Click(sender, e);   
                this.Close();
                      
                }
            }// Timer
        private void ConstantTic_Tick(object sender, EventArgs e)
        {
            string Go = (System.IO.File.ReadAllText(@"E:\Congressional App Challenge C(Sharp)\WhereToGo.txt"));
            int Gonum = int.Parse(Go);
            System.Diagnostics.Debug.WriteLine(Gonum);
            Go.DefaultIfEmpty();         
            pb.Image = Image.FromFile(@spot[Gonum - 1]);
            answerCount = Gonum - 1;
            if (answerCount % 2 != 0)
            {
                Abut.Text = "F";
                Bbut.Text = "G";
                Cbut.Text = "H";
                Dbut.Text = "J";
                Ebut.Text = "K";
            }
            else
            {
                Abut.Text = "A";
                Bbut.Text = "B";
                Cbut.Text = "C";
                Dbut.Text = "D";
                Ebut.Text = "E";
            } // Letter Change
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            if (answers[answerCount] == "a")
                ap.Visible = true;
            if (answers[answerCount] == "b")
                bp.Visible = true;
            if (answers[answerCount] == "c")
                cp.Visible = true;
            if (answers[answerCount] == "d")
                dp.Visible = true;
            if (answers[answerCount] == "e")
                ep.Visible = true;           
            ConstantTic.Stop();
        } // Question Selector Timer

        ///////////////////////Buttons////////////////////////////////

        private void Abut_Click(object sender, EventArgs e)
            {
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            answers[answerCount] = "a";
            ap.Visible = true;

        } // A Button
        private void Bbut_Click(object sender, EventArgs e)
            {
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            answers[answerCount] = "b";
            bp.Visible = true;

        } // B Button
        private void Cbut_Click(object sender, EventArgs e)
            {
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            answers[answerCount] = "c";
            cp.Visible = true;

        } // C Button
        private void Dbut_Click(object sender, EventArgs e)
            {
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            answers[answerCount] = "d";
            dp.Visible = true;

        } // D Button
        private void Ebut_Click(object sender, EventArgs e)
            {
            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            answers[answerCount] = "e";
            ep.Visible = true;

        } // E Button
        private void Nextbut_Click(object sender, EventArgs e)
        {
            if (answerCount != 59)
           answerCount++;        
            

            if (answerCount % 2 != 0)
            {
                Abut.Text = "F";
                Bbut.Text = "G";
                Cbut.Text = "H";
                Dbut.Text = "J";
                Ebut.Text = "K";
            }
            else
            {
                Abut.Text = "A";
                Bbut.Text = "B";
                Cbut.Text = "C";
                Dbut.Text = "D";
                Ebut.Text = "E";
            } // Letter Change

            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            if (answers[answerCount] == "a")
                ap.Visible = true;
            if (answers[answerCount] == "b")
                bp.Visible = true;
            if (answers[answerCount] == "c")
                cp.Visible = true;
            if (answers[answerCount] == "d")
                dp.Visible = true;
            if (answers[answerCount] == "e")
                ep.Visible = true;

            pb.Image = Image.FromFile(spot[answerCount]);
        } // Next Button
        private void Backbut_Click(object sender, EventArgs e)
        {
            if (answerCount != 0)
             answerCount--;

                

            if (answerCount % 2 != 0)
            {
                Abut.Text = "F";
                Bbut.Text = "G";
                Cbut.Text = "H";
                Dbut.Text = "J";
                Ebut.Text = "K";
            }
            else
            {
                Abut.Text = "A";
                Bbut.Text = "B";
                Cbut.Text = "C";
                Dbut.Text = "D";
                Ebut.Text = "E";
            } // Letter Change

            ap.Visible = false;
            bp.Visible = false;
            cp.Visible = false;
            dp.Visible = false;
            ep.Visible = false;
            if (answers[answerCount] == "a")
                ap.Visible = true;
            if (answers[answerCount] == "b")
                bp.Visible = true;
            if (answers[answerCount] == "c")
                cp.Visible = true;
            if (answers[answerCount] == "d")
                dp.Visible = true;
            if (answers[answerCount] == "e")
                ep.Visible = true;

            pb.Image = Image.FromFile(spot[answerCount]);
        } // Back Button
        private void Qsbut_Click(object sender, EventArgs e)
        {
            System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt").DefaultIfEmpty();
            System.IO.File.WriteAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt", answers);
            Question_Selector quest = new Question_Selector();
            quest.ShowDialog();

        } //Question Selector Button
        private void Finishbut_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (minutes == 0 && seconds == 0)
                count = 61;
            else
            {
                for (int i = 0; i < 60; i++)
                {
                    if (answers[i] == "x")
                        count++;
                }
            }
            
            
            System.IO.File.WriteAllText(@"E:\Congressional App Challenge C(Sharp)\Finish.txt", count.ToString());
            System.IO.File.ReadAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt").DefaultIfEmpty();
            System.IO.File.WriteAllLines(@"E:\Congressional App Challenge C(Sharp)\Input.txt", answers);
            Finish_Form fin = new Finish_Form();
            fin.ShowDialog();


        } // Finish Button
        private void button1_Click(object sender, EventArgs e)
        {
            Calculator n = new Calculator();
            n.ShowDialog();
        }

        private void FTest_Load(object sender, EventArgs e)
        {

        }
    }
    }


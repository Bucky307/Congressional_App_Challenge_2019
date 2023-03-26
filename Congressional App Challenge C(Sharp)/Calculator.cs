using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Congressional_App_Challenge_C_Sharp_
{
    public partial class Calculator : Form
    {
        string display = "";
        char[] sign = new char[40];
        string[] nums = new string[80];
        int count = 0;

        public Calculator()
        {
            InitializeComponent();
            CheckTmr.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display = ""; 
            sign = new char[40];
            nums = new string[80];
            count = 0;
            tb.Clear();
           
        } // Clear Button
        private void button9_Click(object sender, EventArgs e)
        {
            nums[count] += "1";
            display += "1";
            tb.Clear(); tb.Text = display;
            

        } // 1 Button
        private void button3_Click(object sender, EventArgs e)
        {
            nums[count] += "2";
            display += "2";
            tb.Clear(); tb.Text = display;
            

        } // 2 Button
        private void button8_Click(object sender, EventArgs e)
        {
            nums[count] += "3";
            display += "3";
            tb.Clear(); tb.Text = display;
            

        }// 3 Button
        private void button6_Click(object sender, EventArgs e)
        {
            nums[count] += "4";
            display += "4";
            tb.Clear(); tb.Text = display;
            

        }// 4 Button
        private void button5_Click(object sender, EventArgs e)
        {
            nums[count] += "5";
            display += "5";
            tb.Clear(); tb.Text = display;
            

        }// 5 Button
        private void button7_Click(object sender, EventArgs e)
        {
            nums[count] += "6";
            display += "6";
            tb.Clear(); tb.Text = display;
            

        }// 6 Button
        private void button1_Click(object sender, EventArgs e)
        {
            nums[count] += "7";
            display += "7";
            tb.Clear(); tb.Text = display;
            

        }// 7 Button
        private void button2_Click(object sender, EventArgs e)
        {
            nums[count] += "8";
            display += "8";
            tb.Clear(); tb.Text = display;
            


        }// 8 Button
        private void button4_Click(object sender, EventArgs e)
        {
            nums[count] += "9";
            display += "9";
            tb.Clear(); tb.Text = display;
            


        }// 9 Button
        private void button11_Click(object sender, EventArgs e)
        {
            nums[count] += "0";
            display += "0";
            tb.Clear(); tb.Text = display;
            

        }// 0 Button
        private void button10_Click(object sender, EventArgs e)
        {
            nums[count] += ".";
            display += ".";
            tb.Clear(); tb.Text = display;
            

        } // . Button
        private void button15_Click(object sender, EventArgs e)
        {
            sign[count] = '+';
            display += sign[count];
            tb.Clear(); tb.Text = display;

            count++;


        } // + Button
        private void button13_Click(object sender, EventArgs e)
        {
            if (nums[count] == null)
            {
                nums[count] += "-";
                display += nums[count];
                tb.Clear(); tb.Text = display;
            }
           else
           {
               sign[count] = '-';
               display += sign[count];
               tb.Clear(); tb.Text = display;
               count++;
           }
        } // - Button
        private void button16_Click(object sender, EventArgs e)
        {
            sign[count] = 'x';
            display += sign[count];
            tb.Clear(); tb.Text = display;

            count++;
        } // X Button
        private void button14_Click(object sender, EventArgs e)
        {
            sign[count] = '/';
            display += sign[count];
            tb.Clear(); tb.Text = display;

            count++;
        } // / Button
        private void button17_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {                         
                double solution = Condense(nums, sign, count, count);
                tb.Clear(); tb.Text = solution.ToString();

                nums = new string[80];
                sign = new char[40];

                count = 0;
                nums[count] = solution.ToString();
                display = nums[count];
            }
            
        } // = Button
        static double Condense(string[] nums, char[] sign, int count, int ConstCount)
            {
            double solution = 0; 
            int marker = 0;

            int td = 0;// 0: null -- 1: * -- 2: /
            int am = 0; // 0: null -- 1: + -- 2: -

            // multiplication and division set
            for (int i = 0; i < ConstCount; i++)
            {
                if (sign[i] == 'x' || sign[i] == '/')
                {
                    marker = i;
                   
                    if (sign[i] == 'x')
                        td = 1;
                    else td = 2;

                    break;
                }
            
            }
            
            if (td == 1) 
            {
                int c = marker;
                while (true)
                {
                  
                    if (nums[c] == "n")
                            c--;
                    else
                    {
                    solution = double.Parse(nums[c]) * double.Parse(nums[marker + 1]);
                        break;
                    }

                }
                
                nums[c] = solution.ToString();
                nums[marker + 1] = "n";
                sign[marker] = 'n';
                count --;

                if (count > 0)
                    return Condense(nums, sign, count, ConstCount);
            }
            else if (td == 2)
            {
                int c = marker;
                while (true)
                {
                    if (nums[c] == "n")
                        c--;
                    else
                    {
                        solution = double.Parse(nums[c]) / double.Parse(nums[marker + 1]);
                        break;
                    }

                   
                }

                nums[c] = solution.ToString();
                nums[marker + 1] = "n";
                sign[marker] = 'n';
                count--;

                if (count > 0)
                    return Condense(nums, sign, count, ConstCount);
            }

           

            // addition and subtraction set
            for (int i = 0; i < ConstCount; i++)
            {
                if (sign[i] == '+' || sign[i] == '-')
                {
                    marker = i;

                    if (sign[i] == '+')
                        am = 1;
                    else am = 2;

                    break;
                }
            }
          

            if (am == 1)
            {
                int c = marker;
                while (true)
                {
                    if (nums[c] == "n")
                        c--;
                    else
                    {
                        solution = double.Parse(nums[c]) + double.Parse(nums[marker + 1]);
                        break;
                    }

                }

                nums[c] = solution.ToString();
                nums[marker + 1] = "n";
                sign[marker] = 'n';
                count--;

                if (count > 0)
                    return Condense(nums, sign, count, ConstCount);
            }
            else if (am == 2)
            {
                int c = marker;
                while (true)
                {
                    if (nums[c] == "n")
                        c--;
                    else
                    {
                        solution = double.Parse(nums[c]) - double.Parse(nums[marker + 1]);
                        break;
                    }

                }

                nums[c] = solution.ToString();
                nums[marker + 1] = "n";
                sign[marker] = 'n';
                count--;

                if (count > 0)
                    return Condense(nums, sign, count, ConstCount);
            }

            

            return solution;






        } // = Function
        private void CheckTmr_Tick(object sender, EventArgs e)
        {
            if (display.Length == 1 && (display.IndexOf("+") == 1  || display.IndexOf("x") == 1 || display.IndexOf("/") == 1))
            {
                display = "";
                sign = new char[40];
                nums = new string[80];
                count = 0;
                tb.Clear();
            }
            if (display.Length > 1)
            {
                var x = display.Substring(display.Length - 2, 2);
                if (x == "++" || x == "+--" || x == "+x" || x == "+/" || x == "-+" || x == "---" || x == "-x" || x == "-/" || x == "x+" || x == "x--" || x == "xx" || x == "x/" || x == "/+" || x == "/--" || x == "/x" || x == "//" || x == "..")
                {
                    display = "";
                    sign = new char[40];
                    nums = new string[80];
                    count = 0;
                    tb.Clear();
                }
            }
                
                   
         
            
        } // Error Check Timer

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

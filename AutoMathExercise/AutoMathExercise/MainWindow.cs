using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMathExercise
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Num1, Num2;
        public int MathIndex;
        public bool Positive = true;

        public char MathChar = '!';
        public double Math_Answer;
        public double Final_Answer = 0;

        // Arry Option

        public char[] MathOptions;
        public int ArrySize;
        public int Speed;
        public bool timer = false;

        public void GetMathOptions(char[] MathOptionsArray, int ArrySize, int Speed)
        {
            this.MathOptions = MathOptionsArray;
            this.ArrySize = ArrySize;
            this.Speed = Speed;
        }

        public void Setting_Timer()
        {
            if (this.Speed == 1)
            {
                progressBar1.Maximum = 4;
                progressBar1.Visible = true;
                this.timer = true;
            }
            if (this.Speed == 2)
            {
                progressBar1.Maximum = 7;
                progressBar1.Visible = true;
                this.timer = true;
            }
            if (this.Speed == 3)
            {
                progressBar1.Maximum = 11;
                progressBar1.Visible = true;
                this.timer = true;
            }
        }

        public string Exercise()
        {
            Random RandNum = new Random();
            int index = RandNum.Next(0, this.ArrySize);
            this.ArrySize = this.ArrySize + 1 - 1;

            //חיבור
            if (MathOptions[index] == '+')
            {
                this.Num1 = RandNum.Next(0, 101);
                this.Num2 = RandNum.Next(0, 101);
                this.MathChar = '+';
                this.Final_Answer = this.Num1 + this.Num2;
                return this.Num1.ToString() + " " + MathChar.ToString() + " " + this.Num2.ToString() + " ="; 
            }

            //חיסור
            if (MathOptions[index] == '-')
            {
                this.Num1 = RandNum.Next(0, 101);
                this.Num2 = RandNum.Next(0, 101);
                this.MathChar = '-';
                this.Final_Answer = this.Num1 - this.Num2;
                return this.Num1.ToString() + " " + MathChar.ToString() + " " + this.Num2.ToString() + " =";
            }

            //כפל
            if (MathOptions[index] == 'X')
            {
                this.Num1 = RandNum.Next(0, 20);
                if (this.Num1 <= 5)
                {
                    this.Num2 = RandNum.Next(0, 20);
                }
                else
                {
                    if (this.Num1 <= 15)
                    {
                        this.Num2 = RandNum.Next(0, 15);
                    }
                    else
                    {
                        this.Num2 = RandNum.Next(0, 5);
                    }
                }
                this.Final_Answer = this.Num1 * this.Num2;
                this.MathChar = 'X';
                return this.Num1.ToString() + " " + MathChar.ToString() + " " + this.Num2.ToString() + " =";
            }

            //חילוק
            if (MathOptions[index] == ':')
            {
                this.Num1 = RandNum.Next(1, 20);
                if (this.Num1 <= 5)
                {
                    this.Num2 = RandNum.Next(1, 20);
                }
                else
                {
                    if (this.Num1 <= 15)
                    {
                        this.Num2 = RandNum.Next(1, 15);
                    }
                    else
                    {
                        this.Num2 = RandNum.Next(1, 5);
                    }
                }
                this.MathChar = ':';
                this.Math_Answer = this.Num1 * this.Num2;
                this.Final_Answer = this.Math_Answer / this.Num2;
                return Math_Answer.ToString() + " " + MathChar.ToString() + " " + this.Num2.ToString() + " =";
            }

            //חזקות
            if (MathOptions[index] == '^')
            {
                this.Num1 = RandNum.Next(0, 16);
                if (this.Num1 == 2)
                {
                    this.Num2 = RandNum.Next(0, 7);
                }
                else
                {
                    if (this.Num1 == 10)
                    {
                        this.Num2 = RandNum.Next(0, 4);
                    }
                    else
                    {
                        if (this.Num1 <= 6)
                        {
                            this.Num2 = RandNum.Next(0, 4);
                        }
                        else
                        {
                            this.Num2 = RandNum.Next(0, 3);
                        }
                    }
                }
                this.MathChar = '^';
                this.Final_Answer = Math.Pow(this.Num1, this.Num2);
                if (this.Num1 < 10)
                {
                    label2.Text = this.Num2.ToString();
                    label2.Visible = true;
                }
                else
                {
                    label3.Text = this.Num2.ToString();
                    label3.Visible = true;
                }
                return this.Num1.ToString() + "  =" ;
            }

            //שורשים
            if (MathOptions[index] == '√')
            {
                this.Num1 = RandNum.Next(0, 16);
                if (this.Num1 == 2)
                {
                    this.Num2 = RandNum.Next(2, 7);
                }
                else
                {
                    if (this.Num1 == 10)
                    {
                        this.Num2 = RandNum.Next(2, 4);
                    }
                    else
                    {
                        if (this.Num1 <= 6)
                        {
                            this.Num2 = RandNum.Next(2, 4);
                        }
                        else
                        {
                            this.Num2 = RandNum.Next(2, 3);
                        }
                    }
                }
                this.MathChar = '√';
                this.Math_Answer = Math.Pow(this.Num1, this.Num2);
                label1.Text = this.Num2.ToString();
                label1.Visible = true;
                if (this.Math_Answer <= 9)
                {
                    pictureBox1.Width = 25;
                }
                else
                {
                    if (this.Math_Answer <= 99)
                    {
                        pictureBox1.Width = 40;
                    }
                    else
                    {
                        if (this.Math_Answer <= 999)
                        {
                            pictureBox1.Width = 55;
                        }
                        else
                        {
                            pictureBox1.Width = 70;
                        }
                    }
                }
                pictureBox1.Visible = true;
                this.Final_Answer = this.Num1;
                return " " + MathChar.ToString() + Math_Answer.ToString() + " =";
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "1";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "2";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "3";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "4";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "5";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "6";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "7";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "8";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                textBox4.Text = "9";
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Answer = 0;
            Answer = int.Parse(this.Final_Answer.ToString());
            Time.Enabled = false;
            this.stress_time = 1;

            try
            {
                if (Positive == true)
                {
                    if (Answer == int.Parse(textBox4.Text))
                    {
                        this.textBox4.BackColor = Color.GreenYellow;
                        DisableAllButtons();
                        ShowResult.Enabled = true;
                    }
                    else
                    {
                        this.textBox4.BackColor = Color.Red;
                        DisableAllButtons();
                        ShowResult.Enabled = true;
                    }
                }
                else
                {
                    if (Answer == (int.Parse(textBox4.Text) * -1))
                    {
                        int Negative_Answer;
                        Negative_Answer = int.Parse(textBox4.Text) * -1;
                        textBox4.Text = Negative_Answer.ToString();
                        this.textBox4.BackColor = Color.GreenYellow;
                        DisableAllButtons();
                        ShowResult.Enabled = true;
                    }
                    else
                    {
                        int Negative_Answer;
                        Negative_Answer = int.Parse(textBox4.Text) * -1;
                        textBox4.Text = Negative_Answer.ToString();
                        this.textBox4.BackColor = Color.Red;
                        DisableAllButtons();
                        ShowResult.Enabled = true;
                    }
                }
            }
            catch
            {
                //textBox4.Text =  Answer.ToString();
                //this.Failures += this.Num1.ToString() + " " + " " + this.Num2.ToString() + " = " + Answer + "\n";
                this.textBox4.BackColor = Color.Red;
                DisableAllButtons();
                ShowResult.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Positive = false;
            button13.Enabled = false;
            button15.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox4.Text.Length.ToString()) == 1) && (int.Parse(textBox4.Text.ToString()) == 0))
            {
                //Nothing
            }
            else
            {
                if (int.Parse(textBox4.Text.Length.ToString()) <= 3)
                    textBox4.Text += "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Positive = true;
            button13.Enabled = true;
            button15.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text1.Text = Exercise();
            Setting_Timer();
            if (this.timer == true)
            {
                Time.Enabled = true;
            }
        }

        public string Failures = "Your Failures:" + "\n";

        private void button16_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Failures);
            //MessageBox.Show(Failures,"Failures");
            OptionsForm OptionForm = new OptionsForm();
            OptionForm.Show();
            this.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Failures = "Your Failures:" + "\n";
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int TickTime = 0;
        private void ShowResult_Tick(object sender, EventArgs e)
        {
            if (TickTime == 0)
            {
                textBox4.Text = this.Final_Answer.ToString();
            }
            if (TickTime == 1)
            {
                this.textBox4.BackColor = Color.WhiteSmoke;
                EnableAllButtons();
                ShowResult.Enabled = false;
                //
                textBox4.Text = "";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                pictureBox1.Visible = false;
                Text1.Text = Exercise();
                this.Positive = true;
                button13.Enabled = true;
                button15.Enabled = false;
                Time.Enabled = true;
                progressBar1.Value = 0;
            }
            TickTime++;
            if (TickTime == 2)
            {
                TickTime = 0;
            }

        }

        public void DisableAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }
        public void EnableAllButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = false;
            button16.Enabled = true;
        }

        int stress_time = 1;

        private void Time_Tick(object sender, EventArgs e)
        {
            bool stop_loop = false;
            if (stress_time > progressBar1.Maximum)
            {
                this.stress_time = 0;
                progressBar1.Value = stress_time;
                this.stress_time = 1;
                Time.Enabled = false;
                stop_loop = true;
                button10_Click(sender, e);
            }
            if ((stress_time <= progressBar1.Maximum) && (stop_loop == false))
            {
                progressBar1.Value = stress_time;
                stress_time++;
            }

        }

    }
}

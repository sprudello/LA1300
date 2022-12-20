using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4x4Schach
{
    partial class Form1
    {
        void Reset()
        {
            test = new bool[6, 6]
            {
                {false, false, false, false, false, false},
                {false, false, false, false, false, false},
                {false, false, false, false, false, false},
                {false, false, false, false, false, false},
                {false, false, false, false, false, false},
                {false, false, false, false, false, false}
            };
        }
        void Check(int x, int y)
        {
            test[x + 1, y] = true;
            test[x + 1, y + 1] = true;
            test[x - 1,y] = true;
            test[x - 1, y - 1] = true;
            test[x, y + 1] = true;
            test[x, y - 1] = true;
            test[x - 1, y + 1] = true;
            test[x + 1, y - 1] = true;
            test[x, y] = true;
        }
    }

    public partial class Form1 : Form
    {
        string temp = "";
        bool[,] test;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button1.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button1.Text;
                button1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button2.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button2.Text;
                button2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 3;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button3.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button3.Text;
                button3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 4;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button4.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button4.Text;
                button4.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button5.Text = temp;
                    temp = "";
                    Reset();
                }
            }
            else
            {
                Check(x, y);
                temp = button5.Text;
                button5.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button6.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button6.Text;
                button6.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 3;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button7.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button7.Text;
                button7.Text = "";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 4;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button8.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button8.Text;
                button8.Text = "";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 1;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button9.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button9.Text;
                button9.Text = "";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 2;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button10.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button10.Text;
                button10.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 3;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button11.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button11.Text;
                button11.Text = "";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 4;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button12.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button12.Text;
                button12.Text = "";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 1;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button13.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button13.Text;
                button13.Text = "";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button14.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button14.Text;
                button14.Text = "";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 3;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    button15.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button15.Text;
                button15.Text = "";
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 4;
            if (temp != "")
            {
                
                if (test[x, y] == true)
                {
                    button16.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                temp = button16.Text;
                button16.Text = "";
            }

        }
    }
}

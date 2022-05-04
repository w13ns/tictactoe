using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Check(string all)
        {
            if (all.Contains("xxx") || l1.Text + l4.Text + l7.Text == "xxx" || l2.Text + l5.Text + l8.Text == "xxx" || l3.Text + l6.Text + l9.Text == "xxx" || l1.Text + l5.Text + l9.Text == "xxx" || l3.Text + l5.Text + l7.Text == "xxx")
            {
                MessageBox.Show("x won in the last game!");
                restart();
                return true;
            }
            if (all.Contains("ooo") || l1.Text + l4.Text + l7.Text == "ooo" || l2.Text + l5.Text + l8.Text == "ooo" || l3.Text + l6.Text + l9.Text == "ooo" || l1.Text + l5.Text + l9.Text == "ooo" || l3.Text + l5.Text + l7.Text == "ooo")
            {
                MessageBox.Show("o won in the last game!");
                restart();
                return true;
            }
            return false;
        }
        void iffull(string all, bool a)
        {
            if (!all.Contains('*') & a == false)
            {
                MessageBox.Show("There was a draw in the last game");
                restart();
            }
        }
        void isWLN()
        {
            while (true)
            {
                Thread.Sleep(300);
                string all = $"{l1.Text + l2.Text + l3.Text}-{l4.Text + l5.Text + l6.Text}-{l7.Text + l8.Text + l9.Text}";
                if (all == "--")
                    Environment.Exit(0);
                iffull(all, Check(all));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(isWLN);
            thread.Start();
        }
        void whonowChange()
        {
            switch (whonow.Text)
            {
                case "x":
                    whonow.Text = "o";
                    break;
                case "o":
                    whonow.Text = "x";
                    break;
            }
        }
        void restart()
        {
            l9.Text = "*"; 
            l8.Text = "*"; 
            l7.Text = "*";
            l6.Text = "*";
            l5.Text = "*";
            l4.Text = "*";
            l3.Text = "*";
            l2.Text = "*";
            l1.Text = "*";
            whonow.Text = "x";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void l1_MouseHover(object sender, EventArgs e)
        {
            if(l1.Text == "*")
                l1.ForeColor = Color.Green;
            else
                l1.ForeColor = Color.Red;
        }

        private void l1_MouseLeave(object sender, EventArgs e)
        {
            l1.ForeColor = Color.Empty;
        }
        private void l2_MouseHover(object sender, EventArgs e)
        {
            if (l2.Text == "*")
                l2.ForeColor = Color.Green;
            else
                l2.ForeColor = Color.Red;
        }

        private void l2_MouseLeave(object sender, EventArgs e)
        {
            l2.ForeColor = Color.Empty;
        }
        private void l3_MouseHover(object sender, EventArgs e)
        {
            if (l3.Text == "*")
                l3.ForeColor = Color.Green;
            else
                l3.ForeColor = Color.Red;
        }

        private void l3_MouseLeave(object sender, EventArgs e)
        {
            l3.ForeColor = Color.Empty;
        }
        private void l4_MouseHover(object sender, EventArgs e)
        {
            if (l4.Text == "*")
                l4.ForeColor = Color.Green;
            else
                l4.ForeColor = Color.Red;
        }

        private void l4_MouseLeave(object sender, EventArgs e)
        {
            l4.ForeColor = Color.Empty;
        }
        private void l5_MouseHover(object sender, EventArgs e)
        {
            if (l5.Text == "*")
                l5.ForeColor = Color.Green;
            else
                l5.ForeColor = Color.Red;
        }

        private void l5_MouseLeave(object sender, EventArgs e)
        {
            l5.ForeColor = Color.Empty;
        }
        private void l6_MouseHover(object sender, EventArgs e)
        {
            if (l6.Text == "*")
                l6.ForeColor = Color.Green;
            else
                l6.ForeColor = Color.Red;
        }

        private void l6_MouseLeave(object sender, EventArgs e)
        {
            l6.ForeColor = Color.Empty;
        }
        private void l7_MouseHover(object sender, EventArgs e)
        {
            if (l7.Text == "*")
                l7.ForeColor = Color.Green;
            else
                l7.ForeColor = Color.Red;
        }

        private void l7_MouseLeave(object sender, EventArgs e)
        {
            l7.ForeColor = Color.Empty;
        }
        private void l8_MouseHover(object sender, EventArgs e)
        {
            if (l8.Text == "*")
                l8.ForeColor = Color.Green;
            else
                l8.ForeColor = Color.Red;
        }

        private void l8_MouseLeave(object sender, EventArgs e)
        {
            l8.ForeColor = Color.Empty;
        }
        private void l9_MouseHover(object sender, EventArgs e)
        {
            if (l9.Text == "*")
                l9.ForeColor = Color.Green;
            else
                l9.ForeColor = Color.Red;
        }

        private void l9_MouseLeave(object sender, EventArgs e)
        {
            l9.ForeColor = Color.Empty;
        }
        private void l1_Click(object sender, EventArgs e)
        {
            if (l1.Text == "*")
            {
                l1.Text = whonow.Text;
                l1.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l2_Click(object sender, EventArgs e)
        {
            if (l2.Text == "*")
            {
                l2.Text = whonow.Text;
                l2.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l3_Click(object sender, EventArgs e)
        {
            if (l3.Text == "*")
            {
                l3.Text = whonow.Text;
                l3.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l4_Click(object sender, EventArgs e)
        {
            if (l4.Text == "*")
            {
                l4.Text = whonow.Text;
                l4.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l5_Click(object sender, EventArgs e)
        {
            if (l5.Text == "*")
            {
                l5.Text = whonow.Text;
                l5.ForeColor = Color.Red;
                whonowChange();
            }
        }
            private void l6_Click(object sender, EventArgs e)
        {
            if (l6.Text == "*")
            {
                l6.Text = whonow.Text;
                l6.ForeColor = Color.Red;
                whonowChange();
            }
        }

        private void l7_Click(object sender, EventArgs e)
        {
            if (l7.Text == "*")
            {
                l7.Text = whonow.Text;
                l7.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l8_Click(object sender, EventArgs e)
        {
            if (l8.Text == "*")
            {
                l8.Text = whonow.Text;
                l8.ForeColor = Color.Red;
                whonowChange();
            }
        }
        private void l9_Click(object sender, EventArgs e)
        {
            if (l9.Text == "*")
            {
                l9.Text = whonow.Text;
                l9.ForeColor = Color.Red;
                whonowChange();
            }
        }
    }
}

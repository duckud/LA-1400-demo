using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PancakeVisual
{
    public partial class Form1 : Form
    {
        static int startingMoney = 20;
        static int startingPoints = 0;
        static int click = 0;
        static Random number = new Random();
        static int numberInt = number.Next(1, 3);

        public Form1()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
            string startingPointsstring = Convert.ToString(startingPoints);
            label2.Text = startingPointsstring;
            if (numberInt == 1)
            {
                pictureBox6.Location = new Point(145, 318);
            }
            else if (numberInt == 2)
            {
                pictureBox6.Location = new Point(373, 318);
            }
            else if (numberInt == 3)
            {
                pictureBox6.Location = new Point(592, 318);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            click = click + 1;
            startingMoney = startingMoney - 1;
            string startingMoneystring = Convert.ToString(startingMoney);
            label1.Text = startingMoneystring;
            if (startingMoney == 0)
            {
                MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                System.Environment.Exit(0);
            }
            pictureBox5.Location = new Point(140, 211);
            if (pictureBox6.Location != new Point(145, 318))
            {
                if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
            }
            if (pictureBox6.Location == new Point(145, 318))
            {
                startingPoints = startingPoints + 1;
                string startingPointsstring = Convert.ToString(startingPoints);
                label2.Text = startingPointsstring;
                if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            click = click + 1;
            startingMoney = startingMoney - 1;
            string startingMoneystring = Convert.ToString(startingMoney);
            label1.Text = startingMoneystring;
            if (startingMoney == 0)
            {
                MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                System.Environment.Exit(0);
            }

            pictureBox4.Location = new Point(360, 211);
            if (pictureBox6.Location != new Point(373, 318))
            {
                if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
            }
            if (pictureBox6.Location == new Point(373, 318))
            {
                startingPoints = startingPoints + 1;
                string startingPointsstring = Convert.ToString(startingPoints);
                label2.Text = startingPointsstring;
                if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
                }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click = click +1;
            startingMoney = startingMoney - 1;
            string startingMoneystring = Convert.ToString(startingMoney);
            label1.Text = startingMoneystring;
            if (startingMoney == 0)
            {
                MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                System.Environment.Exit(0);
            }
            pictureBox3.Location = new Point(560, 211);
            if (pictureBox6.Location != new Point(592, 318))
            {
                if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es falsch erraten, wollen Sie weiterspielen?", "Falsch erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
            }
            if (pictureBox6.Location == new Point(592, 318))
            {
                startingPoints = startingPoints + 1;
                string startingPointsstring = Convert.ToString(startingPoints);
                label2.Text = startingPointsstring;
                if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    number = new Random();
                    int numberInt = number.Next(1, 4);
                    if (numberInt == 1)
                    {
                        pictureBox6.Location = new Point(145, 318);
                    }
                    else if (numberInt == 2)
                    {
                        pictureBox6.Location = new Point(373, 318);
                    }
                    else if (numberInt == 3)
                    {
                        pictureBox6.Location = new Point(592, 318);
                    }
                    pictureBox3.Location = new Point(560, 279);
                    pictureBox4.Location = new Point(360, 279);
                    pictureBox5.Location = new Point(140, 279);
                }
                else if (MessageBox.Show("Sie haben es richtig erraten, wollen Sie weiterspielen?", "Richtig erraten", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Sie haben im Gesamten " + startingPoints + " Punkte. Das Programm wird jetzt geschlossen.");
                    System.Environment.Exit(0);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = new Random();
            int numberInt = number.Next(1, 4);
            if (numberInt == 1)
            {
                pictureBox6.Location = new Point(145, 318);
            }
            else if (numberInt == 2)
            {
                pictureBox6.Location = new Point(373, 318);
            }
            else if (numberInt == 3)
            {
                pictureBox6.Location = new Point(592, 318);
            }
            pictureBox3.Location = new Point(560, 279);
            pictureBox4.Location = new Point(360, 279);
            pictureBox5.Location = new Point(140, 279);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Highscore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    
}


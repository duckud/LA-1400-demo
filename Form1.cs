using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hütchen_Spiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = textBox1.Text;
                string inPath = @"..\..\..\Saves.txt";
                string text = File.ReadAllText(inPath);

                string[] lines = text.Split("\r\n");
                int words = lines.Length;
                string[] savedNames = new string[words - 1];
                string[] savedScores = new string[words - 1];
                for (int line = 0; line < lines.Length - 1; line++)
                {
                    try
                    {
                        string[] items = lines[line].Split(',');
                        savedNames[line] = items[0];
                        savedScores[line] = items[1];
                    }
                    catch
                    {

                    }
                }

                bool isFound = false;
                foreach (string savedName in savedNames)
                {
                    if (username == savedName)
                    {
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    label2.Text = "Willkommen zurück " + username;
                }
                else
                {
                    label2.Text = "Herzlich willkommen " + username;
                    File.AppendAllText(@"..\..\..\Saves.txt", username + Environment.NewLine);
                }
                label2.Visible = true;
            }
        }
    }
}

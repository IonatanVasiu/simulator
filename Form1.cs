using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSOAC
{
    public partial class Form1 : Form
    {
        string numeFisierSelectat;
        private int ctB, ctS, ctL;
        private string cuvant2, cuvant3;
        public Form1()
        {
            InitializeComponent();
        }



        private void startButon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.trc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] words = File.ReadAllText(filePath).Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                ctB = 0;
                ctS = 0;
                ctL = 0;

                for (int i = 0; i < words.Length - 2; i += 3)
                {
                    
                    switch (words[i])
                    {
                        case "B":
                            ctB++;
                            break;
                        case "S":
                            ctS++;
                            break;
                        case "L":
                            ctL++;
                            break;
                            
                    }

                }
                textBoxB.Text = ctB.ToString();
                textBoxL.Text = ctL.ToString();
                textBoxS.Text = ctS.ToString();
                textBoxTotal.Text = (ctB + ctS + ctL).ToString();


            }
        }
    }
}

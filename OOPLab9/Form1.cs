using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using System.IO;

namespace OOPLab9
{
    public partial class Form1 : DarkForm
    {
        const int Kol = 41;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files | *.txt";
            saveFileDialog1.Filter = "Text files | *.txt";
        }

        string line = "";
        string tmp1, tmp2, tmp3, tmp4;

        private void darkButton2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string tmp = "";
            for (int k = 0; k <= Kol; k++)
            {
                if (A[k].School == darkComboBox1.Text)
                {
                    tmp += A[k].Year + " " + A[k].FIO + " " + A[k].Gorod + "\r\n";
                }
            }
            File.WriteAllText(filename, tmp);
            Form2 F = new Form2();
            F.ShowDialog();
            tmp = "";

        }

        

        private void darkButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int k = 0; k <= Kol; k++)
            {
                if (A[k].School == darkComboBox1.Text)
                {
                    string tmp = A[k].Year + " " + A[k].FIO + " " + A[k].Gorod;
                    listBox1.Items.Add(tmp);
                }
            }
            darkButton2.Enabled = true;
        }

        List<Stroka> A = new List<Stroka>();

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                for (int k = 0; k <= Kol; k++) 
                {
                    line = sr.ReadLine();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line.ElementAt(i) == '|')
                        {
                            tmp1 = line;
                            tmp1 = tmp1.Remove(i, line.Length - i);
                        }
                        if (line.ElementAt(i) == '*')
                        {
                            tmp2 = line;
                            tmp2 = tmp2.Remove(i, line.Length - i);
                            tmp2 = tmp2.Remove(0, tmp1.Length + 1);
                        }
                        if (line.ElementAt(i) == '+')
                        {
                            tmp3 = line;
                            tmp3 = tmp3.Remove(i, line.Length - i);
                            tmp3 = tmp3.Remove(0, tmp1.Length + tmp2.Length + 2);
                        }
                        if (line.ElementAt(i) == '-')
                        {
                            tmp4 = line;
                            tmp4 = tmp4.Remove(i, line.Length - i);
                            tmp4 = tmp4.Remove(0, tmp1.Length + tmp2.Length + tmp3.Length + 3);
                        }
                    }
                    richTextBox1.Text += tmp1 + " " + tmp2 + " " + tmp3 + " " + tmp4 + "\r\n";
                    A.Add(new Stroka { FIO = tmp1, Year = tmp2, Gorod = tmp3, School = tmp4 });
                    if(darkComboBox1.Items.Contains(A[k].School) != true)
                    {
                        darkComboBox1.Items.Add(A[k].School);
                    }
                    darkButton3.Enabled = true;
                }
            }
        }
    }
}

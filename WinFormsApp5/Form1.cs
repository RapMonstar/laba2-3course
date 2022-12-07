using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "C:\\Users\\azaza\\Desktop\\1.txt";
        private void cREATENEWFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter stream = new StreamWriter(path))
                stream.WriteLine("Файл создан");
        }
        private void oPENEXISTINGFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }       
        }
        
        void saveFile(string chto, string gde)
        {
            if (chto.Count() > 1)
            {
                if(File.Exists(gde))
                    File.Create(gde).Close();
                File.WriteAllText(gde, chto);
            }
        }

        private void sAVEFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(richTextBox1.Text, path);
        }

        private void rELATEDUNDERANOTHERNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Test files|*.txt";
            if(saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter stream = new StreamWriter(saveFile.FileName, true))
                {
                    stream.WriteLine(richTextBox1.Text);
                    stream.Close();
                }
            }
        }

        private void pROCESSOPENFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void cLEARPROCESSINGRESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 cпособ
            string s1, s2;

            richTextBox2.Clear();
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                s1 = richTextBox1.Lines[i];
                int countWord = 0;
                int j = 1;
                if (s1 != "" && s1[0] != ' ' && s1[0] != '.'
                && s1[0] != ',') countWord++;
                while (j < s1.Length)
                {
                    if (s1[j] != ' ' && s1[j] != '.' && s1[j] != ','
                    && (s1[j - 1] == ' ' || s1[j - 1] == '.'
                    || s1[j - 1] == ',')) countWord++;
                    j++;
                }

                string[] arrString;
                string[] sss = {"     ","   ","  ", " ", ", "};

                arrString = s1.Split(sss,
               StringSplitOptions.RemoveEmptyEntries);
                //richTextBox2.AppendText(s1);

                for (int ii = 0; ii < arrString.Count(); ii++)
                {
                    if (ii == (countWord) / 2)
                    {
                        s2 = arrString[ii];
                        if (richTextBox2.Text.Length > 0)
                        {
                            richTextBox2.AppendText(Environment.NewLine);
                        }
                        richTextBox2.AppendText(s2);
                    }
                }


            }
            //2 способ

            //string s1, s2;

            //richTextBox2.Clear();
            //for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            //{
            //    s1 = richTextBox1.Lines[i];
            //    string[] s_mas = s1.Split(' ', ',', '.');
            //    int countWord = 0;
            //    foreach (string str in s_mas)
            //        if (str != "") countWord++;
            //    s2 = String.Concat(s1, (countWord + 1) / 2);

            //    string[] arrString;
            // string[] sss = { "  ", " ", ", " };
            // arrString = s1.Split(sss,
            // StringSplitOptions.RemoveEmptyEntries);

            //    for (int ii = 0; ii < arrString.Count(); ii++)
            //    {
            //        if (ii == (countWord) / 2)
            //        {
            //            s2 = arrString[ii];
            //            if (richTextBox2.Text.Length > 0)
            //            {
            //                richTextBox2.AppendText(Environment.NewLine);
            //            }
            //            richTextBox2.AppendText(s2);
            //        }
            //    }


            //}



        }
    }
}
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixerPad
{
    public partial class Form1 : Form
    {
        String open_path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //info info = new info();
            //info.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog1.FileName;
            string text = File.ReadAllText(filename2);
            fastColoredTextBox1.Text = text;
            open_path = filename2;
            string path = File.ReadAllText("files/path.t$");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("files/path.t$");
            File.WriteAllText(path, fastColoredTextBox1.Text);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "TEXT (.TXT File)")
                saveFileDialog1.Filter = "Текстовый документ (*.txt)|*.txt";
            else if (comboBox1.Text == "C#")
                saveFileDialog1.Filter = "C# файл (*.cs)|*.cs";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, fastColoredTextBox1.Text);
            File.WriteAllText("files/path.t$", filename);
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                fastColoredTextBox1.SelectAll();
            }
        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fastColoredTextBox1.Font = fontDialog1.Font;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                fastColoredTextBox1.Cut();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                fastColoredTextBox1.Paste();
            }
        }

        private void фToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                fastColoredTextBox1.Copy();
            }
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            fastColoredTextBox1.BackColor = colorDialog1.Color;
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void fastColoredTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            string text = fastColoredTextBox1.Text;
            string[] lines = text.Split('\n');
            label3.Text = "Символов: " + text.Length.ToString();
            label2.Text = "Строк: " + lines.Length.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


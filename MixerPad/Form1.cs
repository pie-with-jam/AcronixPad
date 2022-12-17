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
            richTextBox1.Text = text;
            open_path = filename2;
            string path = File.ReadAllText("files/path.t$");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("files/path.t$");
            File.WriteAllText(path, richTextBox1.Text);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "TEXT (.TXT File)")
                saveFileDialog1.Filter = "Текстовый документ (*.txt)|*.txt";
            else if (comboBox1.Text == "HTML")
                saveFileDialog1.Filter = "Web-Страница (*.html)|*.html";
            else if (comboBox1.Text == "CSS")
                saveFileDialog1.Filter = "CSS файл (*.css)|*.css";
            else if (comboBox1.Text == "MixerPad")
                saveFileDialog1.Filter = "MixerPad файл (*.mip)|*.mip";
            else if (comboBox1.Text == "Python")
                saveFileDialog1.Filter = "Python файл (*.py)|*.py";
            else if (comboBox1.Text == "C++")
                saveFileDialog1.Filter = "C++ файл (*.cpp)|*.cpp";
            else if (comboBox1.Text == "C#")
                saveFileDialog1.Filter = "C# файл (*.cs)|*.cs";
            else if (comboBox1.Text == "Pascal")
                saveFileDialog1.Filter = "Pascal файл (*.pas)|*.pas";
            else if (comboBox1.Text == "JavaScript")
                saveFileDialog1.Filter = "JavaScript файл (*.js)|*.js";
            else if (comboBox1.Text == "PHP")
                saveFileDialog1.Filter = "PHP файл (*.php)|*.php";
            else if (comboBox1.Text == "ASSEMBLER")
                saveFileDialog1.Filter = "ASSEMBLER файл (*.asm)|*.asm";
            else if (comboBox1.Text == "Lua")
                saveFileDialog1.Filter = "Lua файл (*.lua)|*.lua";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            File.WriteAllText("files/path.t$", filename);
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void фToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


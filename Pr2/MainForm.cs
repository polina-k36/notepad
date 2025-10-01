using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2
{
    public partial class MainForm : Form
    {
        byte but = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString();
            this.richTextBox1.Text = data;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (richTextBox1.Visible == false) { richTextBox1.Visible = true; }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                richTextBox1.Select();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text (*.txt) | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            richTextBox1.Clear();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Select();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Select();
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;

        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;

        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;

        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void InToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but += 1;
            switch (but)
            {
                case 1:
                    this.richTextBox1.BackColor = Color.RosyBrown;
                    break;
                case 2:
                    this.richTextBox1.BackColor = Color.DarkSeaGreen;
                    break;
                case 3:
                    this.richTextBox1.BackColor = Color.SteelBlue;
                    break;
                case 4:
                    this.richTextBox1.BackColor = Color.MediumSlateBlue;
                    break;
                case 5:
                    this.richTextBox1.BackColor = Color.Crimson;
                    break;
                case 6:
                    this.richTextBox1.BackColor = Color.LightYellow;
                    break;

                case 7:
                    this.richTextBox1.BackColor = Color.White;
                    but = 0;
                    break;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Select();
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
    }
}

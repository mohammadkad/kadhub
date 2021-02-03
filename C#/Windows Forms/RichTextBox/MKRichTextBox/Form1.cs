using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKRichTextBox
{
    public partial class Form1 : Form
    {
        private const int MAX_LINE = 15;
        private const int NUMBER_OF_REMOVED_LINES = 1;
        public Form1()
        {
            InitializeComponent();
        }

        // Delete the first n lines of RichTextBox in C#, 2021/02/03, Mohammad Kadkhodaei Elyaderani ;)
		private void btnAdd_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + " - " + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss:ffff"));

            if (richTextBox1.Lines.Count() > MAX_LINE)
            {

                richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(NUMBER_OF_REMOVED_LINES));
                richTextBox1.SelectedText = "";

            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = richTextBox1.Lines.Count().ToString();

            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
    }
}

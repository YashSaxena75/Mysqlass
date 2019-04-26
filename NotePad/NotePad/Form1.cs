using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Insert an Image";
            ofd.InitialDirectory = "C:";
            ofd.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp";
            ofd.ShowDialog();

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused == true)
                if (textBox1.CanUndo == true)
                
                {

                textBox1.Undo();
                textBox1.ClearUndo();

            }
            if (textBox2.Focused == true)
                if (textBox2.CanUndo==true)
                
            {
                    MessageBox.Show("Sorry we don't do that here!");
                    textBox2.ClearUndo();
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string saved_file = "";
            sfd.InitialDirectory = "C:";
            sfd.Title = "Save a File";
            sfd.FileName = "";
            sfd.Filter = "Text Files|*.txt |All Files| *.*";
            if (sfd.ShowDialog() != DialogResult.Cancel)
            {
                saved_file = sfd.FileName;
                RichTextBox rtb = new RichTextBox();
                rtb.SaveFile(saved_file, RichTextBoxStreamType.PlainText);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using me!");
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
            if(textBox2.SelectedText!="")
            {
                textBox2.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {

                textBox1.Copy();

            }
            if (textBox2.SelectionLength > 0)
            {

                textBox2.Copy();

            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                textBox2.Paste();
               
            }
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                textBox1.Paste();
               

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox2.SelectAll();
        }

        private void AboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This NotePad Version is made by Yash Saxena");

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bhai label pe click kyu kar raha bug hai to bata de aisi!");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bhai label pe click kyu kar raha bug hai to bata de aisi!");

        }
    }
}

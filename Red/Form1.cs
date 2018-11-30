using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red
{
    public partial class MyTextEditor : Form
    {


        public MyTextEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initializing sizes of fonts
            for (int i = 1; i <= 72; i++)
                cmb_size.Items.Add(i);
            cmb_size.SelectedIndex = 9;
            //cmb_size.Update();

            //initializing FontFamilies
            System.Drawing.Text.InstalledFontCollection InstalledFonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in InstalledFonts.Families)
                cmb_FontStyle.Items.Add(font.Name);

            cmb_FontStyle.Items.RemoveAt(0);
            cmb_FontStyle.SelectedIndex = cmb_FontStyle.FindString("Times New Roman");
            //cmb_FontStyle.Update();

            textEditor.Font = new Font(cmb_FontStyle.SelectedItem.ToString(), (int)cmb_size.SelectedItem, FontStyle.Regular);
        }


        private void Bold_Click(object sender, EventArgs e)
        {
            ChangeStyle(textEditor, FontStyle.Bold);
        }
                                   

        private void Italic_Click(object sender, EventArgs e)
        {
            ChangeStyle(textEditor, FontStyle.Italic);
        }

        private void UnderLine_Click(object sender, EventArgs e)
        {
            ChangeStyle(textEditor, FontStyle.Underline);
        }

        private void Strikeout_Click(object sender, EventArgs e)
        {
            ChangeStyle(textEditor, FontStyle.Strikeout);
        }

        

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_size.SelectedItem == null || cmb_FontStyle.SelectedItem == null) return;
            //if at least 1 symbol selected(selected text change)
            if (textEditor.SelectionLength > 0)
            {
                int n = 0;
                int.TryParse(cmb_size.SelectedItem.ToString(), out n);
                ChangeSize(textEditor, n);
            }
            //simple text change
            else
                textEditor.SelectionFont = new Font(cmb_FontStyle.SelectedItem.ToString(), (int)cmb_size.SelectedItem, FontStyle.Regular);

        }


        private void cmb_FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_size.SelectedItem == null || cmb_FontStyle.SelectedItem == null) return;
            //if at least 1 symbol selected(selected text change)
            if (textEditor.SelectionLength > 0)
                SetFontFamily(cmb_FontStyle.SelectedItem.ToString());
            //simple text change
            else
                textEditor.SelectionFont = new Font(cmb_FontStyle.SelectedItem.ToString(), (int)cmb_size.SelectedItem, FontStyle.Regular);
            
        }

        void SetFontFamily(string name)
        {
            ChangeFontFamily(textEditor, name);
        }



        private void ChangeSize(RichTextBox rtb, float size)
        {
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;
            int selectionEnd = selectionStart + selectionLength;
            for (int x = selectionStart; x < selectionEnd; ++x)
            {
                // Set temporary selection
                rtb.Select(x, 1);
                // Toggle font style of the selection   
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, size, rtb.SelectionFont.Style);
            }
            // Restore the original selection
            rtb.Select(selectionStart, selectionLength);
        }

        private void ChangeStyle(RichTextBox rtb, FontStyle style_to_change)
        {
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;
            int selectionEnd = selectionStart + selectionLength;

            rtb.Select(selectionStart, 1);
            FontStyle style = rtb.SelectionFont.Style;
            bool checkStyle = true;

            for (int x = selectionStart+1; x < selectionEnd; ++x)
            {
                rtb.Select(x, 1);
                if(rtb.SelectionFont.Style != style)
                {
                    checkStyle = false;
                    break;
                }
            }


            if (style_to_change == style && checkStyle == true)
                style_to_change = FontStyle.Regular; 
            

            for (int x = selectionStart; x < selectionEnd; ++x)
            {
                // Set temporary selection
                rtb.Select(x, 1);
                // Toggle font style of the selection   
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, style_to_change);
            }
            // Restore the original selection
            rtb.Select(selectionStart, selectionLength);
        }

        private void ChangeFontFamily(RichTextBox rtb, string Font_name)
        {
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;
            int selectionEnd = selectionStart + selectionLength;

            for (int x = selectionStart; x < selectionEnd; ++x)
            {
                // Set temporary selection
                rtb.Select(x, 1);
                // Toggle font style of the selection   
                rtb.SelectionFont = new Font(Font_name, rtb.SelectionFont.Size, rtb.SelectionFont.Style);
            }
            // Restore the original selection
            rtb.Select(selectionStart, selectionLength);
        }
    }
}

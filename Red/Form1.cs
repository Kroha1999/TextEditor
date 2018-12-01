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

//!!!!!!!!!!FORM!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public MyTextEditor()
        {
            InitializeComponent();
        }

        Color _color = Color.Black;
        Color PressedCol = Color.Silver;
        Color NotPressedCol = Color.FromArgb(224,224,224);


        private void Form1_Load(object sender, EventArgs e)
        {
            colorPanel.BackColor = _color;


            //initializing sizes of fonts
            for (int i = 1; i <= 72; i++)
                cmb_size.Items.Add(i);
            cmb_size.SelectedIndex = 8;

            //initializing FontFamilies
            System.Drawing.Text.InstalledFontCollection InstalledFonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in InstalledFonts.Families)
                cmb_FontFamily.Items.Add(font.Name);

            cmb_FontFamily.Items.RemoveAt(0);
            cmb_FontFamily.SelectedIndex = cmb_FontFamily.FindString("Times New Roman");
            
        }

        //STYLE BUTTONS
        private void Bold_Click(object sender, EventArgs e)
        {
            Change_ButStyle(textEditor, Bold);
            textEditor.Focus();
        }
                                   
        private void Italic_Click(object sender, EventArgs e)
        {
            Change_ButStyle(textEditor, Italic);
            textEditor.Focus();
        }        

        private void UnderLine_Click(object sender, EventArgs e)
        {
            Change_ButStyle(textEditor, UnderLine);
            textEditor.Focus();
        }

        private void Strikeout_Click(object sender, EventArgs e)
        {
            Change_ButStyle(textEditor, Strikeout);
            textEditor.Focus();
        }

        //FONT and SIZE comboBoxes functions

        //TEXTEDITOR
        private void textEditor_SelectionChanged(object sender, EventArgs e)
        {
            if (textEditor.SelectionLength == 0)
            {
                cmb_size.SelectedItem = (int)textEditor.SelectionFont.Size;
                cmb_FontFamily.SelectedIndex = cmb_FontFamily.FindString(textEditor.SelectionFont.FontFamily.Name);

                switch (textEditor.SelectionFont.Style)
                {
                    case FontStyle.Strikeout:
                        unpressBtns(Strikeout);
                        break;

                    case FontStyle.Underline:
                        unpressBtns(UnderLine);
                        break;

                    case FontStyle.Bold:
                        unpressBtns(Bold);
                        break;

                    case FontStyle.Italic:
                        unpressBtns(Italic);
                        break;

                    default:
                        unpressBtns();
                        break;
                }

                Console.WriteLine("size = " + textEditor.SelectionFont.Size + ", font = " + textEditor.SelectionFont.FontFamily.ToString() + ", selected font = " + cmb_FontFamily.SelectedItem.ToString() + ", Style = " + textEditor.SelectionFont.Style.ToString());
            }

        }


        //SIZE_FONT
        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_size.SelectedItem == null ) return;
            //if at least 1 symbol selected(selected text change)
            if (textEditor.SelectionLength > 0)
            {
                int n = 0;
                int.TryParse(cmb_size.SelectedItem.ToString(), out n);
                ChangeSize(textEditor, n);
            }
            //simple text change
            else
                if(cmb_size.SelectedItem != null && cmb_FontFamily.SelectedItem != null)
                    textEditor.SelectionFont = new Font(cmb_FontFamily.SelectedItem.ToString(), (int)cmb_size.SelectedItem, FontStyle.Regular);
            textEditor.Focus();

        }

        //FONTFAMILY
        private void cmb_FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_FontFamily.SelectedItem == null) return;
            //if at least 1 symbol selected(selected text change)
            if (textEditor.SelectionLength > 0)
                ChangeFontFamily(textEditor,cmb_FontFamily.SelectedItem.ToString());
            //simple text change
            else
                if (cmb_size.SelectedItem != null && cmb_FontFamily.SelectedItem != null)
                    textEditor.SelectionFont = new Font(cmb_FontFamily.SelectedItem.ToString(), (int)cmb_size.SelectedItem, FontStyle.Regular);
            textEditor.Focus();
        }


//!!!!!!!!!General Functions!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void Change_ButStyle(RichTextBox rtb,  Button btn)
        {
            FontStyle style;
            if (btn == Strikeout) style = FontStyle.Strikeout;
            else if (btn == UnderLine) style = FontStyle.Underline;
            else if (btn == Bold) style = FontStyle.Bold;
            else  style = FontStyle.Italic;


            if (rtb.SelectionLength > 0)
                ChangeStyle(rtb, style);
            else
            {
                //if not pressed - press
                if (btn.BackColor == NotPressedCol)
                {
                    textEditor.SelectionFont = new Font(textEditor.SelectionFont.FontFamily, textEditor.SelectionFont.Size, style);
                    //only 1 style allowed
                    unpressBtns(btn);
                }
                // else unpress
                else
                {
                    textEditor.SelectionFont = new Font(textEditor.SelectionFont.FontFamily, textEditor.SelectionFont.Size, FontStyle.Regular);
                    unpressBtns();
                }

                
            }
        }

        private void unpressBtns(Button except = null)
        {

            Italic.BackColor = NotPressedCol;
            Bold.BackColor = NotPressedCol;
            Strikeout.BackColor = NotPressedCol;
            UnderLine.BackColor = NotPressedCol;

            if (except == Strikeout) Strikeout.BackColor = PressedCol;
            else if (except == UnderLine) UnderLine.BackColor = PressedCol;
            else if (except == Bold) Bold.BackColor = PressedCol;
            else if (except == Italic) Italic.BackColor = PressedCol;        
                       

        }
        //for more than 1 symb
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


        // NULL EXCERPTION WORKERS
        int getSelectionFontSize(RichTextBox rtb)
        {
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;
            int selectionEnd = selectionStart + selectionLength;

            rtb.Select(rtb.SelectionStart, 1);

            
            int size = (int)rtb.SelectionFont.Size;

            for (int x = selectionStart + 1; x < selectionEnd; ++x)
            {
                // Set temporary selection
                rtb.Select(x, 1);
                // Toggle font style of the selection   
                if (size != (int)rtb.SelectionFont.Size)
                {
                    rtb.Select(selectionStart, selectionLength);
                    return -1;
                }
            }
            rtb.Select(selectionStart, selectionLength);
            return size;
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                colorPanel.BackColor = _color;
            }
        }
    }
}

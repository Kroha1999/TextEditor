namespace Red
{
    partial class MyTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Strikeout = new System.Windows.Forms.Button();
            this.Italic = new System.Windows.Forms.Button();
            this.UnderLine = new System.Windows.Forms.Button();
            this.Bold = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_FontFamily = new System.Windows.Forms.ComboBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RightBtn = new System.Windows.Forms.Button();
            this.CenterBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.UpperIndex = new System.Windows.Forms.Button();
            this.UnderIndex = new System.Windows.Forms.Button();
            this.Size_plus = new System.Windows.Forms.Button();
            this.Size_minus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.AcceptsTab = true;
            this.textEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditor.Location = new System.Drawing.Point(0, 111);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(1275, 430);
            this.textEditor.TabIndex = 0;
            this.textEditor.Text = "";
            this.textEditor.SelectionChanged += new System.EventHandler(this.textEditor_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Strikeout);
            this.groupBox1.Controls.Add(this.Italic);
            this.groupBox1.Controls.Add(this.UnderLine);
            this.groupBox1.Controls.Add(this.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1026, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style";
            // 
            // Strikeout
            // 
            this.Strikeout.AllowDrop = true;
            this.Strikeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Strikeout.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Strikeout.Location = new System.Drawing.Point(6, 25);
            this.Strikeout.Name = "Strikeout";
            this.Strikeout.Size = new System.Drawing.Size(50, 50);
            this.Strikeout.TabIndex = 3;
            this.Strikeout.Text = "V";
            this.Strikeout.UseVisualStyleBackColor = false;
            this.Strikeout.Click += new System.EventHandler(this.Strikeout_Click);
            // 
            // Italic
            // 
            this.Italic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Italic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Italic.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Italic.Location = new System.Drawing.Point(121, 25);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(50, 50);
            this.Italic.TabIndex = 1;
            this.Italic.Text = "I";
            this.Italic.UseVisualStyleBackColor = false;
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // UnderLine
            // 
            this.UnderLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnderLine.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderLine.Location = new System.Drawing.Point(65, 25);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(50, 50);
            this.UnderLine.TabIndex = 2;
            this.UnderLine.Text = "U";
            this.UnderLine.UseVisualStyleBackColor = false;
            this.UnderLine.Click += new System.EventHandler(this.UnderLine_Click);
            // 
            // Bold
            // 
            this.Bold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Bold.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bold.Location = new System.Drawing.Point(177, 25);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(50, 50);
            this.Bold.TabIndex = 0;
            this.Bold.Text = "B";
            this.Bold.UseVisualStyleBackColor = false;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Size_minus);
            this.groupBox2.Controls.Add(this.Size_plus);
            this.groupBox2.Controls.Add(this.cmb_size);
            this.groupBox2.Controls.Add(this.cmb_FontFamily);
            this.groupBox2.Location = new System.Drawing.Point(534, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // cmb_size
            // 
            this.cmb_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(365, 20);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(102, 28);
            this.cmb_size.TabIndex = 1;
            this.cmb_size.SelectedIndexChanged += new System.EventHandler(this.cmb_size_SelectedIndexChanged);
            // 
            // cmb_FontFamily
            // 
            this.cmb_FontFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_FontFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_FontFamily.FormattingEnabled = true;
            this.cmb_FontFamily.Location = new System.Drawing.Point(6, 20);
            this.cmb_FontFamily.Name = "cmb_FontFamily";
            this.cmb_FontFamily.Size = new System.Drawing.Size(353, 28);
            this.cmb_FontFamily.TabIndex = 0;
            this.cmb_FontFamily.SelectedIndexChanged += new System.EventHandler(this.cmb_FontStyle_SelectedIndexChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(226, 30);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(50, 50);
            this.colorPanel.TabIndex = 4;
            this.colorPanel.BackColorChanged += new System.EventHandler(this.colorPanel_BackColorChanged);
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 35);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save file";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OpenButton.Location = new System.Drawing.Point(12, 53);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(111, 35);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Open file";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RightBtn);
            this.groupBox3.Controls.Add(this.CenterBtn);
            this.groupBox3.Controls.Add(this.LeftBtn);
            this.groupBox3.Location = new System.Drawing.Point(328, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 92);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allignment";
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(131, 25);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(50, 50);
            this.RightBtn.TabIndex = 2;
            this.RightBtn.Text = "R";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // CenterBtn
            // 
            this.CenterBtn.Location = new System.Drawing.Point(75, 25);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(50, 50);
            this.CenterBtn.TabIndex = 1;
            this.CenterBtn.Text = "C";
            this.CenterBtn.UseVisualStyleBackColor = true;
            this.CenterBtn.Click += new System.EventHandler(this.CenterBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(19, 25);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(50, 50);
            this.LeftBtn.TabIndex = 0;
            this.LeftBtn.Text = "L";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // UpperIndex
            // 
            this.UpperIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpperIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpperIndex.Location = new System.Drawing.Point(282, 9);
            this.UpperIndex.Name = "UpperIndex";
            this.UpperIndex.Size = new System.Drawing.Size(40, 40);
            this.UpperIndex.TabIndex = 0;
            this.UpperIndex.Text = "xⁿ";
            this.UpperIndex.UseVisualStyleBackColor = false;
            this.UpperIndex.Click += new System.EventHandler(this.UpperIndex_Click);
            // 
            // UnderIndex
            // 
            this.UnderIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnderIndex.Location = new System.Drawing.Point(282, 57);
            this.UnderIndex.Name = "UnderIndex";
            this.UnderIndex.Size = new System.Drawing.Size(40, 40);
            this.UnderIndex.TabIndex = 8;
            this.UnderIndex.Text = "xₙ";
            this.UnderIndex.UseVisualStyleBackColor = false;
            this.UnderIndex.Click += new System.EventHandler(this.UnderIndex_Click);
            // 
            // Size_plus
            // 
            this.Size_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Size_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size_plus.Location = new System.Drawing.Point(365, 53);
            this.Size_plus.Name = "Size_plus";
            this.Size_plus.Size = new System.Drawing.Size(45, 30);
            this.Size_plus.TabIndex = 2;
            this.Size_plus.Text = "A+";
            this.Size_plus.UseVisualStyleBackColor = true;
            this.Size_plus.Click += new System.EventHandler(this.Size_plus_Click);
            // 
            // Size_minus
            // 
            this.Size_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Size_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size_minus.Location = new System.Drawing.Point(422, 53);
            this.Size_minus.Name = "Size_minus";
            this.Size_minus.Size = new System.Drawing.Size(45, 30);
            this.Size_minus.TabIndex = 3;
            this.Size_minus.Text = "A-";
            this.Size_minus.UseVisualStyleBackColor = true;
            this.Size_minus.Click += new System.EventHandler(this.Size_minus_Click);
            // 
            // MyTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 544);
            this.Controls.Add(this.UnderIndex);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.UpperIndex);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEditor);
            this.Name = "MyTextEditor";
            this.ShowIcon = false;
            this.Text = "MyTextEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bold;
        private System.Windows.Forms.Button Italic;
        private System.Windows.Forms.Button Strikeout;
        private System.Windows.Forms.Button UnderLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_FontFamily;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button CenterBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button UpperIndex;
        private System.Windows.Forms.Button UnderIndex;
        private System.Windows.Forms.Button Size_minus;
        private System.Windows.Forms.Button Size_plus;
    }
}


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
            this.cmb_FontStyle = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditor.Location = new System.Drawing.Point(-2, 114);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(1079, 431);
            this.textEditor.TabIndex = 0;
            this.textEditor.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Strikeout);
            this.groupBox1.Controls.Add(this.Italic);
            this.groupBox1.Controls.Add(this.UnderLine);
            this.groupBox1.Controls.Add(this.Bold);
            this.groupBox1.Location = new System.Drawing.Point(792, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Strikeout
            // 
            this.Strikeout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Strikeout.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Strikeout.Location = new System.Drawing.Point(9, 18);
            this.Strikeout.Name = "Strikeout";
            this.Strikeout.Size = new System.Drawing.Size(50, 50);
            this.Strikeout.TabIndex = 3;
            this.Strikeout.Text = "V";
            this.Strikeout.UseVisualStyleBackColor = true;
            this.Strikeout.Click += new System.EventHandler(this.Strikeout_Click);
            // 
            // Italic
            // 
            this.Italic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Italic.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Italic.Location = new System.Drawing.Point(121, 18);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(50, 50);
            this.Italic.TabIndex = 1;
            this.Italic.Text = "I";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // UnderLine
            // 
            this.UnderLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderLine.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderLine.Location = new System.Drawing.Point(65, 18);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(50, 50);
            this.UnderLine.TabIndex = 2;
            this.UnderLine.Text = "U";
            this.UnderLine.UseVisualStyleBackColor = true;
            this.UnderLine.Click += new System.EventHandler(this.UnderLine_Click);
            // 
            // Bold
            // 
            this.Bold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bold.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bold.Location = new System.Drawing.Point(177, 18);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(50, 50);
            this.Bold.TabIndex = 0;
            this.Bold.Text = "B";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmb_size);
            this.groupBox2.Controls.Add(this.cmb_FontStyle);
            this.groupBox2.Location = new System.Drawing.Point(302, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cmb_size
            // 
            this.cmb_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(364, 30);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(102, 28);
            this.cmb_size.TabIndex = 1;
            this.cmb_size.SelectedIndexChanged += new System.EventHandler(this.cmb_size_SelectedIndexChanged);
            // 
            // cmb_FontStyle
            // 
            this.cmb_FontStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_FontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_FontStyle.FormattingEnabled = true;
            this.cmb_FontStyle.Location = new System.Drawing.Point(5, 30);
            this.cmb_FontStyle.Name = "cmb_FontStyle";
            this.cmb_FontStyle.Size = new System.Drawing.Size(353, 28);
            this.cmb_FontStyle.TabIndex = 0;
            this.cmb_FontStyle.SelectedIndexChanged += new System.EventHandler(this.cmb_FontStyle_SelectedIndexChanged);
            // 
            // MyTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEditor);
            this.Name = "MyTextEditor";
            this.Text = "MyTextEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmb_FontStyle;
    }
}


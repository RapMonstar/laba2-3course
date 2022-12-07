namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cREATENEWFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENCURRENTFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESSOPENFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARPROCESSINGRESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREATENEWFILEToolStripMenuItem,
            this.oPENCURRENTFILEToolStripMenuItem,
            this.sAVEFILEToolStripMenuItem,
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem,
            this.pROCESSOPENFILEToolStripMenuItem,
            this.cLEARPROCESSINGRESULTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cREATENEWFILEToolStripMenuItem
            // 
            this.cREATENEWFILEToolStripMenuItem.Name = "cREATENEWFILEToolStripMenuItem";
            this.cREATENEWFILEToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.cREATENEWFILEToolStripMenuItem.Text = "CREATE NEW FILE";
            this.cREATENEWFILEToolStripMenuItem.Click += new System.EventHandler(this.cREATENEWFILEToolStripMenuItem_Click);
            // 
            // oPENCURRENTFILEToolStripMenuItem
            // 
            this.oPENCURRENTFILEToolStripMenuItem.Name = "oPENCURRENTFILEToolStripMenuItem";
            this.oPENCURRENTFILEToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.oPENCURRENTFILEToolStripMenuItem.Text = "OPEN EXISTING FILE";
            this.oPENCURRENTFILEToolStripMenuItem.Click += new System.EventHandler(this.oPENEXISTINGFILEToolStripMenuItem_Click);
            // 
            // sAVEFILEToolStripMenuItem
            // 
            this.sAVEFILEToolStripMenuItem.Name = "sAVEFILEToolStripMenuItem";
            this.sAVEFILEToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.sAVEFILEToolStripMenuItem.Text = "SAVE FILE";
            this.sAVEFILEToolStripMenuItem.Click += new System.EventHandler(this.sAVEFILEToolStripMenuItem_Click);
            // 
            // rELATEDUNDERANOTHERNAMEToolStripMenuItem
            // 
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem.Name = "rELATEDUNDERANOTHERNAMEToolStripMenuItem";
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem.Size = new System.Drawing.Size(199, 20);
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem.Text = "RELATED UNDER ANOTHER NAME";
            this.rELATEDUNDERANOTHERNAMEToolStripMenuItem.Click += new System.EventHandler(this.rELATEDUNDERANOTHERNAMEToolStripMenuItem_Click);
            // 
            // pROCESSOPENFILEToolStripMenuItem
            // 
            this.pROCESSOPENFILEToolStripMenuItem.Name = "pROCESSOPENFILEToolStripMenuItem";
            this.pROCESSOPENFILEToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.pROCESSOPENFILEToolStripMenuItem.Text = "PROCESS OPEN FILE";
            this.pROCESSOPENFILEToolStripMenuItem.Click += new System.EventHandler(this.pROCESSOPENFILEToolStripMenuItem_Click);
            // 
            // cLEARPROCESSINGRESULTToolStripMenuItem
            // 
            this.cLEARPROCESSINGRESULTToolStripMenuItem.Name = "cLEARPROCESSINGRESULTToolStripMenuItem";
            this.cLEARPROCESSINGRESULTToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.cLEARPROCESSINGRESULTToolStripMenuItem.Text = "CLEAR PROCESSING RESULT";
            this.cLEARPROCESSINGRESULTToolStripMenuItem.Click += new System.EventHandler(this.cLEARPROCESSINGRESULTToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(381, 182);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(408, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(382, 182);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cREATENEWFILEToolStripMenuItem;
        private ToolStripMenuItem oPENCURRENTFILEToolStripMenuItem;
        private ToolStripMenuItem sAVEFILEToolStripMenuItem;
        private ToolStripMenuItem rELATEDUNDERANOTHERNAMEToolStripMenuItem;
        private ToolStripMenuItem pROCESSOPENFILEToolStripMenuItem;
        private ToolStripMenuItem cLEARPROCESSINGRESULTToolStripMenuItem;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}
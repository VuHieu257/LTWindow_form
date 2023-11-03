namespace B7_1
{
    partial class frmMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelDN = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabControlMain = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelDN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelDN
            // 
            this.toolStripLabelDN.Name = "toolStripLabelDN";
            this.toolStripLabelDN.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelDN.Text = "UserName";
            this.toolStripLabelDN.Click += new System.EventHandler(this.toolStripLabelDN_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabControlMain);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // TabControlMain
            // 
            this.TabControlMain.Location = new System.Drawing.Point(4, 25);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabControlMain.Size = new System.Drawing.Size(792, 381);
            this.TabControlMain.TabIndex = 0;
            this.TabControlMain.Text = "tabPage1";
            this.TabControlMain.UseVisualStyleBackColor = true;
            this.TabControlMain.Click += new System.EventHandler(this.TabControlMain_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabControlMain;
        private System.Windows.Forms.TabPage tabPage2;
    }
}


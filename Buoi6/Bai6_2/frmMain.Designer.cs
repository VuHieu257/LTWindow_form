namespace Bai6_2
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
            this.btnloaiSP = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnDH = new System.Windows.Forms.Button();
            this.btnCTDH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnloaiSP
            // 
            this.btnloaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloaiSP.Location = new System.Drawing.Point(479, 130);
            this.btnloaiSP.Name = "btnloaiSP";
            this.btnloaiSP.Size = new System.Drawing.Size(211, 63);
            this.btnloaiSP.TabIndex = 0;
            this.btnloaiSP.Text = "Loại Sản Phẩm";
            this.btnloaiSP.UseVisualStyleBackColor = true;
            this.btnloaiSP.Click += new System.EventHandler(this.btnloaiSP_Click);
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.Location = new System.Drawing.Point(83, 130);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(206, 63);
            this.btnSP.TabIndex = 0;
            this.btnSP.Text = "Sản Phẩm";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnDH
            // 
            this.btnDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDH.Location = new System.Drawing.Point(83, 233);
            this.btnDH.Name = "btnDH";
            this.btnDH.Size = new System.Drawing.Size(206, 63);
            this.btnDH.TabIndex = 0;
            this.btnDH.Text = "Đơn Hàng";
            this.btnDH.UseVisualStyleBackColor = true;
            this.btnDH.Click += new System.EventHandler(this.btnDH_Click);
            // 
            // btnCTDH
            // 
            this.btnCTDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTDH.Location = new System.Drawing.Point(479, 233);
            this.btnCTDH.Name = "btnCTDH";
            this.btnCTDH.Size = new System.Drawing.Size(211, 63);
            this.btnCTDH.TabIndex = 0;
            this.btnCTDH.Text = "Chi Tiết Đơn Hàng";
            this.btnCTDH.UseVisualStyleBackColor = true;
            this.btnCTDH.Click += new System.EventHandler(this.btnCTDH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(259, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDH);
            this.Controls.Add(this.btnCTDH);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnloaiSP);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloaiSP;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnDH;
        private System.Windows.Forms.Button btnCTDH;
        private System.Windows.Forms.Label label1;
    }
}


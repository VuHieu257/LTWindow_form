namespace Bai2
{
    partial class frmThemKhoa
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
            this.txtThemKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThemKhoa
            // 
            this.txtThemKhoa.Location = new System.Drawing.Point(158, 183);
            this.txtThemKhoa.Multiline = true;
            this.txtThemKhoa.Name = "txtThemKhoa";
            this.txtThemKhoa.Size = new System.Drawing.Size(194, 85);
            this.txtThemKhoa.TabIndex = 0;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(403, 206);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(107, 33);
            this.btnThemKhoa.TabIndex = 1;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // frmThemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.txtThemKhoa);
            this.Name = "frmThemKhoa";
            this.Text = "frmThemKhoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThemKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
    }
}
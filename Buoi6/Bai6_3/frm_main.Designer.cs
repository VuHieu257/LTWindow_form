namespace Bai6_3
{
    partial class frm_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNXB = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.btnloaiSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ NHÀ SÁCH";
            // 
            // btnNXB
            // 
            this.btnNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNXB.Location = new System.Drawing.Point(97, 283);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(206, 63);
            this.btnNXB.TabIndex = 2;
            this.btnNXB.Text = "Nhà Xuất Bản";
            this.btnNXB.UseVisualStyleBackColor = true;
            this.btnNXB.Click += new System.EventHandler(this.btnNXB_Click);
            // 
            // btnNV
            // 
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.Location = new System.Drawing.Point(493, 283);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(211, 63);
            this.btnNV.TabIndex = 3;
            this.btnNV.Text = "Nhân Viên";
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnSp
            // 
            this.btnSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSp.Location = new System.Drawing.Point(97, 180);
            this.btnSp.Name = "btnSp";
            this.btnSp.Size = new System.Drawing.Size(206, 63);
            this.btnSp.TabIndex = 4;
            this.btnSp.Text = "Sách";
            this.btnSp.UseVisualStyleBackColor = true;
            this.btnSp.Click += new System.EventHandler(this.btnSp_Click);
            // 
            // btnloaiSach
            // 
            this.btnloaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloaiSach.Location = new System.Drawing.Point(493, 180);
            this.btnloaiSach.Name = "btnloaiSach";
            this.btnloaiSach.Size = new System.Drawing.Size(211, 63);
            this.btnloaiSach.TabIndex = 5;
            this.btnloaiSach.Text = "Loại Sách";
            this.btnloaiSach.UseVisualStyleBackColor = true;
            this.btnloaiSach.Click += new System.EventHandler(this.btnloaiSach_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNXB);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnSp);
            this.Controls.Add(this.btnloaiSach);
            this.Name = "frm_main";
            this.Text = "QL Nhà Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNXB;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnSp;
        private System.Windows.Forms.Button btnloaiSach;
    }
}
namespace Bai5_4
{
    partial class Form1
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Bai5_4.Properties.Resources.resturantimage4;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(64, 51);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(219, 293);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(64, 380);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(219, 38);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Chọn hình ảnh";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(329, 51);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(443, 293);
            this.txtContent.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(329, 380);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 38);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Chọn Tập Tin";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(489, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu tập Tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(648, 380);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(124, 38);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOut;
    }
}


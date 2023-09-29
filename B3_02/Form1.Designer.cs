namespace B3_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDanhSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbDL = new System.Windows.Forms.CheckBox();
            this.cbMS = new System.Windows.Forms.CheckBox();
            this.mtbMaSV = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbHoTen = new System.Windows.Forms.MaskedTextBox();
            this.mtbNgaySnh = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN SINH VIEN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(437, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(239, 22);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(90, 37);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 37);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa DS";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm DS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(437, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 305);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(26, 33);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.ReadOnly = true;
            this.txtDanhSach.Size = new System.Drawing.Size(375, 245);
            this.txtDanhSach.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sở Thích";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới Tính";
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(102, 215);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(57, 20);
            this.rbtnNam.TabIndex = 4;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(193, 215);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(102, 266);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(85, 20);
            this.cbTT.TabIndex = 5;
            this.cbTT.Text = "Thể thao ";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbDL
            // 
            this.cbDL.AutoSize = true;
            this.cbDL.Location = new System.Drawing.Point(102, 301);
            this.cbDL.Name = "cbDL";
            this.cbDL.Size = new System.Drawing.Size(69, 20);
            this.cbDL.TabIndex = 5;
            this.cbDL.Text = "Du lịch";
            this.cbDL.UseVisualStyleBackColor = true;
            // 
            // cbMS
            // 
            this.cbMS.AutoSize = true;
            this.cbMS.Location = new System.Drawing.Point(102, 339);
            this.cbMS.Name = "cbMS";
            this.cbMS.Size = new System.Drawing.Size(84, 20);
            this.cbMS.TabIndex = 5;
            this.cbMS.Text = "Mua sắm";
            this.cbMS.UseVisualStyleBackColor = true;
            // 
            // mtbMaSV
            // 
            this.mtbMaSV.Location = new System.Drawing.Point(102, 46);
            this.mtbMaSV.Mask = "2100000000";
            this.mtbMaSV.Name = "mtbMaSV";
            this.mtbMaSV.Size = new System.Drawing.Size(148, 22);
            this.mtbMaSV.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbNgaySnh);
            this.groupBox1.Controls.Add(this.mtbHoTen);
            this.groupBox1.Controls.Add(this.mtbMaSV);
            this.groupBox1.Controls.Add(this.cbMS);
            this.groupBox1.Controls.Add(this.cbDL);
            this.groupBox1.Controls.Add(this.cbTT);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(66, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // mtbHoTen
            // 
            this.mtbHoTen.Location = new System.Drawing.Point(102, 98);
            this.mtbHoTen.Name = "mtbHoTen";
            this.mtbHoTen.Size = new System.Drawing.Size(148, 22);
            this.mtbHoTen.TabIndex = 6;
            // 
            // mtbNgaySnh
            // 
            this.mtbNgaySnh.Location = new System.Drawing.Point(102, 153);
            this.mtbNgaySnh.Mask = "00/00/0000";
            this.mtbNgaySnh.Name = "mtbNgaySnh";
            this.mtbNgaySnh.Size = new System.Drawing.Size(148, 22);
            this.mtbNgaySnh.TabIndex = 6;
            this.mtbNgaySnh.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 564);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbDL;
        private System.Windows.Forms.CheckBox cbMS;
        private System.Windows.Forms.MaskedTextBox mtbMaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbNgaySnh;
        private System.Windows.Forms.MaskedTextBox mtbHoTen;
    }
}


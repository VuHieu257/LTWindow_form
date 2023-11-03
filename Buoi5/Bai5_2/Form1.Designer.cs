namespace Bai5_2
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
            this.datagvDS = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbMaSV = new System.Windows.Forms.MaskedTextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagvDS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagvDS
            // 
            this.datagvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.dtName,
            this.dtDiem,
            this.dtKhoa});
            this.datagvDS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagvDS.Location = new System.Drawing.Point(82, 289);
            this.datagvDS.Name = "datagvDS";
            this.datagvDS.ReadOnly = true;
            this.datagvDS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datagvDS.RowHeadersWidth = 51;
            this.datagvDS.RowTemplate.Height = 24;
            this.datagvDS.Size = new System.Drawing.Size(637, 150);
            this.datagvDS.TabIndex = 7;
            this.datagvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvDS_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(82, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(538, 30);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(82, 31);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(374, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(310, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtbMaSV);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(82, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // mtbMaSV
            // 
            this.mtbMaSV.Location = new System.Drawing.Point(131, 17);
            this.mtbMaSV.Mask = "2100000000";
            this.mtbMaSV.Name = "mtbMaSV";
            this.mtbMaSV.Size = new System.Drawing.Size(187, 22);
            this.mtbMaSV.TabIndex = 4;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(417, 52);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(152, 24);
            this.cbKhoa.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 22);
            this.tbName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // tbDiem
            // 
            this.tbDiem.Location = new System.Drawing.Point(419, 17);
            this.tbDiem.Name = "tbDiem";
            this.tbDiem.Size = new System.Drawing.Size(153, 22);
            this.tbDiem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm";
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 135;
            // 
            // dtName
            // 
            this.dtName.HeaderText = "Họ Tên";
            this.dtName.MinimumWidth = 6;
            this.dtName.Name = "dtName";
            this.dtName.ReadOnly = true;
            this.dtName.Width = 135;
            // 
            // dtDiem
            // 
            this.dtDiem.HeaderText = "Điểm Trung Bình";
            this.dtDiem.MinimumWidth = 6;
            this.dtDiem.Name = "dtDiem";
            this.dtDiem.ReadOnly = true;
            this.dtDiem.Width = 135;
            // 
            // dtKhoa
            // 
            this.dtKhoa.HeaderText = "khoa";
            this.dtKhoa.MinimumWidth = 6;
            this.dtKhoa.Name = "dtKhoa";
            this.dtKhoa.ReadOnly = true;
            this.dtKhoa.Width = 135;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagvDS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản Lý SV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagvDS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvDS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbMaSV;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtKhoa;
    }
}


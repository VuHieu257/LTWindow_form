namespace Bai5_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbDV = new System.Windows.Forms.ComboBox();
            this.cbbLoaisp = new System.Windows.Forms.ComboBox();
            this.txtbCount = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbMaSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.datagvDS = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvDS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDV);
            this.groupBox1.Controls.Add(this.cbbLoaisp);
            this.groupBox1.Controls.Add(this.txtbCount);
            this.groupBox1.Controls.Add(this.txtbPrice);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.txtbMaSP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbDV
            // 
            this.cbbDV.FormattingEnabled = true;
            this.cbbDV.Location = new System.Drawing.Point(707, 57);
            this.cbbDV.Name = "cbbDV";
            this.cbbDV.Size = new System.Drawing.Size(173, 24);
            this.cbbDV.TabIndex = 3;
            // 
            // cbbLoaisp
            // 
            this.cbbLoaisp.FormattingEnabled = true;
            this.cbbLoaisp.Location = new System.Drawing.Point(417, 57);
            this.cbbLoaisp.Name = "cbbLoaisp";
            this.cbbLoaisp.Size = new System.Drawing.Size(173, 24);
            this.cbbLoaisp.TabIndex = 3;
            // 
            // txtbCount
            // 
            this.txtbCount.Location = new System.Drawing.Point(417, 25);
            this.txtbCount.Name = "txtbCount";
            this.txtbCount.Size = new System.Drawing.Size(173, 22);
            this.txtbCount.TabIndex = 2;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(707, 22);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(173, 22);
            this.txtbPrice.TabIndex = 2;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(126, 57);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(173, 22);
            this.txtbName.TabIndex = 2;
            // 
            // txtbMaSP
            // 
            this.txtbMaSP.Location = new System.Drawing.Point(126, 25);
            this.txtbMaSP.Name = "txtbMaSP";
            this.txtbMaSP.Size = new System.Drawing.Size(173, 22);
            this.txtbMaSP.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản Phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(62, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(547, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOut.Location = new System.Drawing.Point(732, 30);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(82, 31);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDelete.Location = new System.Drawing.Point(374, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdate.Location = new System.Drawing.Point(209, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(43, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datagvDS
            // 
            this.datagvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.dtName,
            this.dtLoai,
            this.dtCount,
            this.dtPrice,
            this.dtTotal,
            this.dtDV});
            this.datagvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvDS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagvDS.Location = new System.Drawing.Point(3, 18);
            this.datagvDS.Name = "datagvDS";
            this.datagvDS.ReadOnly = true;
            this.datagvDS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datagvDS.RowHeadersWidth = 51;
            this.datagvDS.RowTemplate.Height = 24;
            this.datagvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvDS.Size = new System.Drawing.Size(896, 198);
            this.datagvDS.TabIndex = 8;
            this.datagvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvDS_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagvDS);
            this.groupBox3.Location = new System.Drawing.Point(62, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(902, 219);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 135;
            // 
            // dtName
            // 
            this.dtName.HeaderText = "Tên Sản Phẩm";
            this.dtName.MinimumWidth = 6;
            this.dtName.Name = "dtName";
            this.dtName.ReadOnly = true;
            this.dtName.Width = 135;
            // 
            // dtLoai
            // 
            this.dtLoai.HeaderText = "Loại Sản Phẩm";
            this.dtLoai.MinimumWidth = 6;
            this.dtLoai.Name = "dtLoai";
            this.dtLoai.ReadOnly = true;
            this.dtLoai.Width = 135;
            // 
            // dtCount
            // 
            this.dtCount.HeaderText = "Số Lượng";
            this.dtCount.MinimumWidth = 6;
            this.dtCount.Name = "dtCount";
            this.dtCount.ReadOnly = true;
            this.dtCount.Width = 75;
            // 
            // dtPrice
            // 
            this.dtPrice.HeaderText = "Giá";
            this.dtPrice.MinimumWidth = 6;
            this.dtPrice.Name = "dtPrice";
            this.dtPrice.ReadOnly = true;
            this.dtPrice.Width = 125;
            // 
            // dtTotal
            // 
            this.dtTotal.HeaderText = "Thành Tiền";
            this.dtTotal.MinimumWidth = 6;
            this.dtTotal.Name = "dtTotal";
            this.dtTotal.ReadOnly = true;
            this.dtTotal.Width = 125;
            // 
            // dtDV
            // 
            this.dtDV.HeaderText = "Đơn Vị Tính";
            this.dtDV.MinimumWidth = 6;
            this.dtDV.Name = "dtDV";
            this.dtDV.ReadOnly = true;
            this.dtDV.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvDS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDV;
        private System.Windows.Forms.ComboBox cbbLoaisp;
        private System.Windows.Forms.TextBox txtbCount;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbMaSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagvDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDV;
    }
}


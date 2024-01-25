namespace Work
{
    partial class FHocSinh
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvHsinh = new System.Windows.Forms.DataGridView();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoGT8 = new System.Windows.Forms.RadioButton();
            this.rdoLT8 = new System.Windows.Forms.RadioButton();
            this.rdoLT5 = new System.Windows.Forms.RadioButton();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = " Ho va Ten";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(198, 209);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(195, 501);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvHsinh
            // 
            this.gvHsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHsinh.Location = new System.Drawing.Point(468, 26);
            this.gvHsinh.Name = "gvHsinh";
            this.gvHsinh.RowHeadersWidth = 51;
            this.gvHsinh.RowTemplate.Height = 24;
            this.gvHsinh.Size = new System.Drawing.Size(435, 326);
            this.gvHsinh.TabIndex = 4;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(27, 98);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(48, 16);
            this.lblAdress.TabIndex = 5;
            this.lblAdress.Text = "Dia chi";
            this.lblAdress.Click += new System.EventHandler(this.lblAdress_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(198, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(24, 158);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(47, 16);
            this.lblCMND.TabIndex = 7;
            this.lblCMND.Text = "CMND";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 215);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Ngay thang nam sinh";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(198, 152);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 22);
            this.txtCMND.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 501);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(493, 501);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(642, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Change";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(198, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 323);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 14;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(198, 380);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(200, 22);
            this.txtSdt.TabIndex = 15;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(198, 437);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(200, 22);
            this.txtGioiTinh.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 323);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(24, 386);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(85, 16);
            this.lblSdt.TabIndex = 19;
            this.lblSdt.Text = "So dien thoai";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(24, 440);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Gioi tinh";
            // 
            // rdoGT8
            // 
            this.rdoGT8.AutoSize = true;
            this.rdoGT8.Location = new System.Drawing.Point(468, 370);
            this.rdoGT8.Name = "rdoGT8";
            this.rdoGT8.Size = new System.Drawing.Size(83, 20);
            this.rdoGT8.TabIndex = 21;
            this.rdoGT8.TabStop = true;
            this.rdoGT8.Text = "Điểm >=8";
            this.rdoGT8.UseVisualStyleBackColor = true;
            this.rdoGT8.CheckedChanged += new System.EventHandler(this.rdoGT8_CheckedChanged);
            // 
            // rdoLT8
            // 
            this.rdoLT8.AutoSize = true;
            this.rdoLT8.Location = new System.Drawing.Point(468, 397);
            this.rdoLT8.Name = "rdoLT8";
            this.rdoLT8.Size = new System.Drawing.Size(94, 20);
            this.rdoLT8.TabIndex = 22;
            this.rdoLT8.TabStop = true;
            this.rdoLT8.Text = "5<=Điểm<8";
            this.rdoLT8.UseVisualStyleBackColor = true;
            this.rdoLT8.CheckedChanged += new System.EventHandler(this.rdoLT8_CheckedChanged);
            // 
            // rdoLT5
            // 
            this.rdoLT5.AutoSize = true;
            this.rdoLT5.Location = new System.Drawing.Point(468, 424);
            this.rdoLT5.Name = "rdoLT5";
            this.rdoLT5.Size = new System.Drawing.Size(73, 20);
            this.rdoLT5.TabIndex = 23;
            this.rdoLT5.TabStop = true;
            this.rdoLT5.Text = "Điểm<5";
            this.rdoLT5.UseVisualStyleBackColor = true;
            this.rdoLT5.CheckedChanged += new System.EventHandler(this.rdoLT5_CheckedChanged);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(716, 368);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(187, 22);
            this.txtDiem.TabIndex = 24;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(614, 371);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(57, 16);
            this.lblDiem.TabIndex = 25;
            this.lblDiem.Text = "Diem so";
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.rdoLT5);
            this.Controls.Add(this.rdoLT8);
            this.Controls.Add(this.rdoGT8);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.gvHsinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvHsinh;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoGT8;
        private System.Windows.Forms.RadioButton rdoLT8;
        private System.Windows.Forms.RadioButton rdoLT5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblDiem;
    }
}


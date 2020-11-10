namespace QUANLYTHUVIEN
{
    partial class QuanLyNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvnhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtnv = new System.Windows.Forms.DateTimePicker();
            this.tbdiachinv = new System.Windows.Forms.TextBox();
            this.tbtendnnv = new System.Windows.Forms.TextBox();
            this.tbhotenv = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttimnhanvien = new System.Windows.Forms.Button();
            this.tbtimnhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btxemnhanvien = new System.Windows.Forms.Button();
            this.btkluunhanvien = new System.Windows.Forms.Button();
            this.btsuanhanvien = new System.Windows.Forms.Button();
            this.btluunhanvien = new System.Windows.Forms.Button();
            this.btxoanhanvien = new System.Windows.Forms.Button();
            this.btthemnhanvien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvnhanvien);
            this.panel1.Controls.Add(this.dtnv);
            this.panel1.Controls.Add(this.tbdiachinv);
            this.panel1.Controls.Add(this.tbtendnnv);
            this.panel1.Controls.Add(this.tbhotenv);
            this.panel1.Controls.Add(this.tbmanv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bttimnhanvien);
            this.panel1.Controls.Add(this.tbtimnhanvien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btxemnhanvien);
            this.panel1.Controls.Add(this.btkluunhanvien);
            this.panel1.Controls.Add(this.btsuanhanvien);
            this.panel1.Controls.Add(this.btluunhanvien);
            this.panel1.Controls.Add(this.btxoanhanvien);
            this.panel1.Controls.Add(this.btthemnhanvien);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 610);
            this.panel1.TabIndex = 2;
            // 
            // dtgvnhanvien
            // 
            this.dtgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.TenDangNhap,
            this.NamSinh,
            this.DiaChi});
            this.dtgvnhanvien.Location = new System.Drawing.Point(450, 152);
            this.dtgvnhanvien.MultiSelect = false;
            this.dtgvnhanvien.Name = "dtgvnhanvien";
            this.dtgvnhanvien.RowHeadersWidth = 62;
            this.dtgvnhanvien.RowTemplate.Height = 28;
            this.dtgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvnhanvien.Size = new System.Drawing.Size(596, 396);
            this.dtgvnhanvien.TabIndex = 23;
            this.dtgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvnhanvien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 8;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.MinimumWidth = 8;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // dtnv
            // 
            this.dtnv.Location = new System.Drawing.Point(181, 420);
            this.dtnv.Name = "dtnv";
            this.dtnv.Size = new System.Drawing.Size(251, 26);
            this.dtnv.TabIndex = 22;
            // 
            // tbdiachinv
            // 
            this.tbdiachinv.Location = new System.Drawing.Point(181, 480);
            this.tbdiachinv.Name = "tbdiachinv";
            this.tbdiachinv.Size = new System.Drawing.Size(251, 26);
            this.tbdiachinv.TabIndex = 21;
            // 
            // tbtendnnv
            // 
            this.tbtendnnv.Location = new System.Drawing.Point(181, 353);
            this.tbtendnnv.Name = "tbtendnnv";
            this.tbtendnnv.Size = new System.Drawing.Size(251, 26);
            this.tbtendnnv.TabIndex = 20;
            // 
            // tbhotenv
            // 
            this.tbhotenv.Location = new System.Drawing.Point(181, 288);
            this.tbhotenv.Name = "tbhotenv";
            this.tbhotenv.Size = new System.Drawing.Size(251, 26);
            this.tbhotenv.TabIndex = 19;
            // 
            // tbmanv
            // 
            this.tbmanv.Location = new System.Drawing.Point(181, 229);
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(251, 26);
            this.tbmanv.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Năm Sinh ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // bttimnhanvien
            // 
            this.bttimnhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimnhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.search;
            this.bttimnhanvien.Location = new System.Drawing.Point(878, 92);
            this.bttimnhanvien.Name = "bttimnhanvien";
            this.bttimnhanvien.Size = new System.Drawing.Size(99, 35);
            this.bttimnhanvien.TabIndex = 12;
            this.bttimnhanvien.Text = "Tìm ";
            this.bttimnhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttimnhanvien.UseVisualStyleBackColor = true;
            this.bttimnhanvien.Click += new System.EventHandler(this.bttimnhanvien_Click);
            // 
            // tbtimnhanvien
            // 
            this.tbtimnhanvien.Location = new System.Drawing.Point(466, 97);
            this.tbtimnhanvien.Name = "tbtimnhanvien";
            this.tbtimnhanvien.Size = new System.Drawing.Size(384, 26);
            this.tbtimnhanvien.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::QUANLYTHUVIEN.Properties.Resources.red_x_mark_transparent_background_3;
            this.button7.Location = new System.Drawing.Point(929, 569);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "Thoát";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btxemnhanvien
            // 
            this.btxemnhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxemnhanvien.Location = new System.Drawing.Point(315, 141);
            this.btxemnhanvien.Name = "btxemnhanvien";
            this.btxemnhanvien.Size = new System.Drawing.Size(117, 46);
            this.btxemnhanvien.TabIndex = 6;
            this.btxemnhanvien.Text = "Xem";
            this.btxemnhanvien.UseVisualStyleBackColor = true;
            // 
            // btkluunhanvien
            // 
            this.btkluunhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkluunhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.red_x_mark_transparent_background_3;
            this.btkluunhanvien.Location = new System.Drawing.Point(164, 141);
            this.btkluunhanvien.Name = "btkluunhanvien";
            this.btkluunhanvien.Size = new System.Drawing.Size(117, 46);
            this.btkluunhanvien.TabIndex = 5;
            this.btkluunhanvien.Text = "K.Lưu";
            this.btkluunhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btkluunhanvien.UseVisualStyleBackColor = true;
            // 
            // btsuanhanvien
            // 
            this.btsuanhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuanhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.return_book_png;
            this.btsuanhanvien.Location = new System.Drawing.Point(315, 80);
            this.btsuanhanvien.Name = "btsuanhanvien";
            this.btsuanhanvien.Size = new System.Drawing.Size(117, 47);
            this.btsuanhanvien.TabIndex = 4;
            this.btsuanhanvien.Text = "Sửa";
            this.btsuanhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsuanhanvien.UseVisualStyleBackColor = true;
            this.btsuanhanvien.Click += new System.EventHandler(this.btsuanhanvien_Click);
            // 
            // btluunhanvien
            // 
            this.btluunhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluunhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.save_icon__1;
            this.btluunhanvien.Location = new System.Drawing.Point(16, 141);
            this.btluunhanvien.Name = "btluunhanvien";
            this.btluunhanvien.Size = new System.Drawing.Size(117, 46);
            this.btluunhanvien.TabIndex = 3;
            this.btluunhanvien.Text = "Lưu";
            this.btluunhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluunhanvien.UseVisualStyleBackColor = true;
            this.btluunhanvien.Click += new System.EventHandler(this.btluunhanvien_Click);
            // 
            // btxoanhanvien
            // 
            this.btxoanhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoanhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.xoa;
            this.btxoanhanvien.Location = new System.Drawing.Point(164, 80);
            this.btxoanhanvien.Name = "btxoanhanvien";
            this.btxoanhanvien.Size = new System.Drawing.Size(117, 47);
            this.btxoanhanvien.TabIndex = 2;
            this.btxoanhanvien.Text = "Xoá";
            this.btxoanhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoanhanvien.UseVisualStyleBackColor = true;
            this.btxoanhanvien.Click += new System.EventHandler(this.btxoanhanvien_Click);
            // 
            // btthemnhanvien
            // 
            this.btthemnhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemnhanvien.Image = global::QUANLYTHUVIEN.Properties.Resources.cong1;
            this.btthemnhanvien.Location = new System.Drawing.Point(16, 80);
            this.btthemnhanvien.Name = "btthemnhanvien";
            this.btthemnhanvien.Size = new System.Drawing.Size(117, 47);
            this.btthemnhanvien.TabIndex = 1;
            this.btthemnhanvien.Text = "Thêm";
            this.btthemnhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthemnhanvien.UseVisualStyleBackColor = true;
            this.btthemnhanvien.Click += new System.EventHandler(this.btthemnhanvien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYTHUVIEN.Properties.Resources._0afd2951b10413352a363ea51b4606ac;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 619);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttimnhanvien;
        private System.Windows.Forms.TextBox tbtimnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btxemnhanvien;
        private System.Windows.Forms.Button btkluunhanvien;
        private System.Windows.Forms.Button btsuanhanvien;
        private System.Windows.Forms.Button btluunhanvien;
        private System.Windows.Forms.Button btxoanhanvien;
        private System.Windows.Forms.Button btthemnhanvien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtnv;
        private System.Windows.Forms.TextBox tbdiachinv;
        private System.Windows.Forms.TextBox tbtendnnv;
        private System.Windows.Forms.TextBox tbhotenv;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
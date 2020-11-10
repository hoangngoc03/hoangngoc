namespace QLTHUVIEN
{
    partial class QLy
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnQLTra = new System.Windows.Forms.Button();
            this.btnQLMuon = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QLMuonTra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 557);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Goldenrod;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QLTHUVIEN.Properties.Resources.red_x_mark_transparent_background_31;
            this.btnThoat.Location = new System.Drawing.Point(802, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 50);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox2.Image = global::QLTHUVIEN.Properties.Resources.sachbe;
            this.pictureBox2.Location = new System.Drawing.Point(521, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
     
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.QLMuonTra);
            this.groupBox1.Controls.Add(this.btnQLDocGia);
            this.groupBox1.Controls.Add(this.btnQLTra);
            this.groupBox1.Controls.Add(this.btnQLMuon);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Controls.Add(this.btnQLSach);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLDocGia.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQLDocGia.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDocGia.Location = new System.Drawing.Point(6, 99);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Size = new System.Drawing.Size(344, 60);
            this.btnQLDocGia.TabIndex = 4;
            this.btnQLDocGia.Text = "QL Độc Giả";
            this.btnQLDocGia.UseVisualStyleBackColor = false;
            this.btnQLDocGia.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnQLTra
            // 
            this.btnQLTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLTra.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQLTra.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTra.Location = new System.Drawing.Point(6, 298);
            this.btnQLTra.Name = "btnQLTra";
            this.btnQLTra.Size = new System.Drawing.Size(344, 60);
            this.btnQLTra.TabIndex = 3;
            this.btnQLTra.Text = "QL Trả";
            this.btnQLTra.UseVisualStyleBackColor = false;
            this.btnQLTra.Click += new System.EventHandler(this.btnQLTra_Click);
            // 
            // btnQLMuon
            // 
            this.btnQLMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLMuon.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQLMuon.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMuon.Location = new System.Drawing.Point(6, 232);
            this.btnQLMuon.Name = "btnQLMuon";
            this.btnQLMuon.Size = new System.Drawing.Size(344, 60);
            this.btnQLMuon.TabIndex = 2;
            this.btnQLMuon.Text = "QL Mượn";
            this.btnQLMuon.UseVisualStyleBackColor = false;
            this.btnQLMuon.Click += new System.EventHandler(this.btnQLMuon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhanVien.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNhanVien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(6, 166);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(344, 60);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "QL Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLSach.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQLSach.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.Location = new System.Drawing.Point(6, 33);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(344, 60);
            this.btnQLSach.TabIndex = 0;
            this.btnQLSach.Text = "QL Sách";
            this.btnQLSach.UseVisualStyleBackColor = false;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QLTHUVIEN.Properties.Resources._0afd2951b10413352a363ea51b4606ac;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           
            // QLMuonTra
            // 
            this.QLMuonTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QLMuonTra.BackColor = System.Drawing.Color.Goldenrod;
            this.QLMuonTra.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLMuonTra.Location = new System.Drawing.Point(6, 364);
            this.QLMuonTra.Name = "QLMuonTra";
            this.QLMuonTra.Size = new System.Drawing.Size(344, 60);
            this.QLMuonTra.TabIndex = 5;
            this.QLMuonTra.Text = "QL Mượn Trả";
            this.QLMuonTra.UseVisualStyleBackColor = false;
            this.QLMuonTra.Click += new System.EventHandler(this.QLMuonTra_Click);
            // 
            // QLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 563);
            this.Controls.Add(this.panel1);
            this.Name = "QLy";
            this.Text = "QLSach";
  
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Button btnQLTra;
        private System.Windows.Forms.Button btnQLMuon;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button QLMuonTra;
    }
}
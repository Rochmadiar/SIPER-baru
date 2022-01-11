namespace SIPER.View
{
    partial class Anggota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jurusan_txt = new System.Windows.Forms.TextBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.idanggota_lbl = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.id_anggota_txt = new System.Windows.Forms.TextBox();
            this.jurusan_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alamat_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telepon_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.anggota_dgv = new System.Windows.Forms.DataGridView();
            this.cId_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cari_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anggota_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "FORM ANGGOTA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jurusan_txt);
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.hapus_btn);
            this.groupBox1.Controls.Add(this.ubah_btn);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Controls.Add(this.idanggota_lbl);
            this.groupBox1.Controls.Add(this.nama_txt);
            this.groupBox1.Controls.Add(this.id_anggota_txt);
            this.groupBox1.Controls.Add(this.jurusan_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alamat_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telepon_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 370);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Anggota";
            // 
            // jurusan_txt
            // 
            this.jurusan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusan_txt.Location = new System.Drawing.Point(190, 115);
            this.jurusan_txt.Margin = new System.Windows.Forms.Padding(4);
            this.jurusan_txt.Name = "jurusan_txt";
            this.jurusan_txt.Size = new System.Drawing.Size(200, 27);
            this.jurusan_txt.TabIndex = 55;
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.SystemColors.Control;
            this.batal_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.batal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.batal_btn.Image = global::SIPER.Properties.Resources.batal;
            this.batal_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batal_btn.Location = new System.Drawing.Point(390, 310);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(4);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.batal_btn.Size = new System.Drawing.Size(100, 35);
            this.batal_btn.TabIndex = 54;
            this.batal_btn.Text = "Batal";
            this.batal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.SystemColors.Control;
            this.hapus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hapus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hapus_btn.Image = global::SIPER.Properties.Resources.hapus;
            this.hapus_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapus_btn.Location = new System.Drawing.Point(270, 310);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.hapus_btn.Size = new System.Drawing.Size(110, 36);
            this.hapus_btn.TabIndex = 53;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ubah_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ubah_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubah_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ubah_btn.Image = global::SIPER.Properties.Resources.ubah;
            this.ubah_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubah_btn.Location = new System.Drawing.Point(160, 310);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.ubah_btn.Size = new System.Drawing.Size(100, 35);
            this.ubah_btn.TabIndex = 52;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.SystemColors.Control;
            this.simpan_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpan_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.simpan_btn.Image = global::SIPER.Properties.Resources.simpan;
            this.simpan_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpan_btn.Location = new System.Drawing.Point(30, 310);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.simpan_btn.Size = new System.Drawing.Size(120, 35);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // idanggota_lbl
            // 
            this.idanggota_lbl.AutoSize = true;
            this.idanggota_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idanggota_lbl.Location = new System.Drawing.Point(25, 40);
            this.idanggota_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idanggota_lbl.Name = "idanggota_lbl";
            this.idanggota_lbl.Size = new System.Drawing.Size(102, 20);
            this.idanggota_lbl.TabIndex = 39;
            this.idanggota_lbl.Text = "ID Anggota";
            // 
            // nama_txt
            // 
            this.nama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(190, 75);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(270, 27);
            this.nama_txt.TabIndex = 44;
            // 
            // id_anggota_txt
            // 
            this.id_anggota_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_anggota_txt.Location = new System.Drawing.Point(190, 35);
            this.id_anggota_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_anggota_txt.Name = "id_anggota_txt";
            this.id_anggota_txt.Size = new System.Drawing.Size(130, 27);
            this.id_anggota_txt.TabIndex = 40;
            // 
            // jurusan_lbl
            // 
            this.jurusan_lbl.AutoSize = true;
            this.jurusan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusan_lbl.Location = new System.Drawing.Point(25, 120);
            this.jurusan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jurusan_lbl.Name = "jurusan_lbl";
            this.jurusan_lbl.Size = new System.Drawing.Size(76, 20);
            this.jurusan_lbl.TabIndex = 49;
            this.jurusan_lbl.Text = "Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "No. Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nama Lengkap";
            // 
            // alamat_txt
            // 
            this.alamat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_txt.Location = new System.Drawing.Point(190, 195);
            this.alamat_txt.Margin = new System.Windows.Forms.Padding(4);
            this.alamat_txt.Multiline = true;
            this.alamat_txt.Name = "alamat_txt";
            this.alamat_txt.Size = new System.Drawing.Size(270, 85);
            this.alamat_txt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Alamat";
            // 
            // telepon_txt
            // 
            this.telepon_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telepon_txt.Location = new System.Drawing.Point(190, 155);
            this.telepon_txt.Margin = new System.Windows.Forms.Padding(4);
            this.telepon_txt.Name = "telepon_txt";
            this.telepon_txt.Size = new System.Drawing.Size(200, 27);
            this.telepon_txt.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.anggota_dgv);
            this.groupBox2.Controls.Add(this.cari_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cari_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(580, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(740, 370);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anggota";
            // 
            // anggota_dgv
            // 
            this.anggota_dgv.AllowUserToAddRows = false;
            this.anggota_dgv.AllowUserToDeleteRows = false;
            this.anggota_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anggota_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.anggota_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anggota_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId_anggota,
            this.cNama,
            this.cJurusan,
            this.cTelepon,
            this.cAlamat});
            this.anggota_dgv.Location = new System.Drawing.Point(30, 90);
            this.anggota_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.anggota_dgv.Name = "anggota_dgv";
            this.anggota_dgv.RowHeadersWidth = 51;
            this.anggota_dgv.RowTemplate.Height = 24;
            this.anggota_dgv.Size = new System.Drawing.Size(680, 250);
            this.anggota_dgv.TabIndex = 55;
            this.anggota_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anggota_dgv_CellContentClick);
            // 
            // cId_anggota
            // 
            this.cId_anggota.DataPropertyName = "id_anggota";
            this.cId_anggota.HeaderText = "ID Anggota";
            this.cId_anggota.MinimumWidth = 6;
            this.cId_anggota.Name = "cId_anggota";
            this.cId_anggota.Width = 125;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama";
            this.cNama.HeaderText = "Nama";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.Width = 125;
            // 
            // cJurusan
            // 
            this.cJurusan.DataPropertyName = "jurusan";
            this.cJurusan.HeaderText = "Jurusan";
            this.cJurusan.MinimumWidth = 6;
            this.cJurusan.Name = "cJurusan";
            this.cJurusan.Width = 125;
            // 
            // cTelepon
            // 
            this.cTelepon.DataPropertyName = "telepon";
            this.cTelepon.HeaderText = "No. Telepon";
            this.cTelepon.MinimumWidth = 6;
            this.cTelepon.Name = "cTelepon";
            this.cTelepon.Width = 125;
            // 
            // cAlamat
            // 
            this.cAlamat.DataPropertyName = "alamat";
            this.cAlamat.HeaderText = "Alamat";
            this.cAlamat.MinimumWidth = 6;
            this.cAlamat.Name = "cAlamat";
            this.cAlamat.Width = 125;
            // 
            // cari_btn
            // 
            this.cari_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cari_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cari_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cari_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cari_btn.Image = global::SIPER.Properties.Resources.cari;
            this.cari_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cari_btn.Location = new System.Drawing.Point(300, 30);
            this.cari_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.cari_btn.Size = new System.Drawing.Size(90, 35);
            this.cari_btn.TabIndex = 54;
            this.cari_btn.Text = "Cari";
            this.cari_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cari_btn.UseVisualStyleBackColor = true;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "ID Anggota";
            // 
            // cari_txt
            // 
            this.cari_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txt.Location = new System.Drawing.Point(150, 35);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(130, 27);
            this.cari_txt.TabIndex = 53;
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anggota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anggota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anggota_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idanggota_lbl;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.TextBox id_anggota_txt;
        private System.Windows.Forms.Label jurusan_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telepon_txt;
        private System.Windows.Forms.TextBox jurusan_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView anggota_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button cari_btn;
    }
}
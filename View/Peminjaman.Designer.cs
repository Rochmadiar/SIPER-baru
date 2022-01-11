namespace SIPER.View
{
    partial class Peminjaman
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cetak_btn = new System.Windows.Forms.Button();
            this.nama_petugas_txt = new System.Windows.Forms.TextBox();
            this.id_petugas_txt = new System.Windows.Forms.TextBox();
            this.bts_waktu_dtp = new System.Windows.Forms.DateTimePicker();
            this.tgl_pinjam_dtp = new System.Windows.Forms.DateTimePicker();
            this.id_buku_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.batal_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.idpinjam_lbl = new System.Windows.Forms.Label();
            this.id_anggota_txt = new System.Windows.Forms.TextBox();
            this.id_pinjam_txt = new System.Windows.Forms.TextBox();
            this.id_buku_lbl = new System.Windows.Forms.Label();
            this.id_anggota_lbl = new System.Windows.Forms.Label();
            this.bts_waktu_lbl = new System.Windows.Forms.Label();
            this.tgl_pinjam_lbl = new System.Windows.Forms.Label();
            this.judul_txt = new System.Windows.Forms.TextBox();
            this.peminjaman_dgv = new System.Windows.Forms.DataGridView();
            this.cId_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_buku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTgl_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBts_waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_petugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peminjaman_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 35);
            this.label1.TabIndex = 99;
            this.label1.Text = "FORM PEMINJAMAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cetak_btn);
            this.groupBox1.Controls.Add(this.nama_petugas_txt);
            this.groupBox1.Controls.Add(this.id_petugas_txt);
            this.groupBox1.Controls.Add(this.bts_waktu_dtp);
            this.groupBox1.Controls.Add(this.tgl_pinjam_dtp);
            this.groupBox1.Controls.Add(this.id_buku_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Controls.Add(this.idpinjam_lbl);
            this.groupBox1.Controls.Add(this.id_anggota_txt);
            this.groupBox1.Controls.Add(this.id_pinjam_txt);
            this.groupBox1.Controls.Add(this.id_buku_lbl);
            this.groupBox1.Controls.Add(this.id_anggota_lbl);
            this.groupBox1.Controls.Add(this.bts_waktu_lbl);
            this.groupBox1.Controls.Add(this.tgl_pinjam_lbl);
            this.groupBox1.Controls.Add(this.judul_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(570, 350);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peminjaman";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cetak_btn
            // 
            this.cetak_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cetak_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cetak_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cetak_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cetak_btn.Image = global::SIPER.Properties.Resources.cetak;
            this.cetak_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetak_btn.Location = new System.Drawing.Point(290, 290);
            this.cetak_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cetak_btn.Name = "cetak_btn";
            this.cetak_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.cetak_btn.Size = new System.Drawing.Size(110, 35);
            this.cetak_btn.TabIndex = 62;
            this.cetak_btn.Text = "Cetak";
            this.cetak_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetak_btn.UseVisualStyleBackColor = false;
            this.cetak_btn.Click += new System.EventHandler(this.cetak_btn_Click);
            // 
            // nama_petugas_txt
            // 
            this.nama_petugas_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_petugas_txt.Location = new System.Drawing.Point(330, 235);
            this.nama_petugas_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nama_petugas_txt.Name = "nama_petugas_txt";
            this.nama_petugas_txt.Size = new System.Drawing.Size(200, 27);
            this.nama_petugas_txt.TabIndex = 61;
            // 
            // id_petugas_txt
            // 
            this.id_petugas_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_petugas_txt.Location = new System.Drawing.Point(190, 235);
            this.id_petugas_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_petugas_txt.Name = "id_petugas_txt";
            this.id_petugas_txt.Size = new System.Drawing.Size(130, 27);
            this.id_petugas_txt.TabIndex = 60;
            // 
            // bts_waktu_dtp
            // 
            this.bts_waktu_dtp.CustomFormat = "dd MMM yyyy";
            this.bts_waktu_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bts_waktu_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bts_waktu_dtp.Location = new System.Drawing.Point(190, 195);
            this.bts_waktu_dtp.Margin = new System.Windows.Forms.Padding(4);
            this.bts_waktu_dtp.Name = "bts_waktu_dtp";
            this.bts_waktu_dtp.Size = new System.Drawing.Size(144, 27);
            this.bts_waktu_dtp.TabIndex = 59;
            // 
            // tgl_pinjam_dtp
            // 
            this.tgl_pinjam_dtp.CustomFormat = "dd MMM yyyy";
            this.tgl_pinjam_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_pinjam_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl_pinjam_dtp.Location = new System.Drawing.Point(190, 155);
            this.tgl_pinjam_dtp.Margin = new System.Windows.Forms.Padding(4);
            this.tgl_pinjam_dtp.Name = "tgl_pinjam_dtp";
            this.tgl_pinjam_dtp.Size = new System.Drawing.Size(144, 27);
            this.tgl_pinjam_dtp.TabIndex = 58;
            // 
            // id_buku_txt
            // 
            this.id_buku_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buku_txt.Location = new System.Drawing.Point(190, 115);
            this.id_buku_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_buku_txt.Name = "id_buku_txt";
            this.id_buku_txt.Size = new System.Drawing.Size(130, 27);
            this.id_buku_txt.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Petugas";
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
            this.batal_btn.Location = new System.Drawing.Point(175, 290);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(4);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.batal_btn.Size = new System.Drawing.Size(100, 35);
            this.batal_btn.TabIndex = 54;
            this.batal_btn.Text = "Batal";
            this.batal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
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
            this.simpan_btn.Location = new System.Drawing.Point(40, 290);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.simpan_btn.Size = new System.Drawing.Size(120, 35);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // idpinjam_lbl
            // 
            this.idpinjam_lbl.AutoSize = true;
            this.idpinjam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpinjam_lbl.Location = new System.Drawing.Point(30, 40);
            this.idpinjam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idpinjam_lbl.Name = "idpinjam_lbl";
            this.idpinjam_lbl.Size = new System.Drawing.Size(91, 20);
            this.idpinjam_lbl.TabIndex = 39;
            this.idpinjam_lbl.Text = "ID Pinjam";
            // 
            // id_anggota_txt
            // 
            this.id_anggota_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_anggota_txt.Location = new System.Drawing.Point(190, 75);
            this.id_anggota_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_anggota_txt.Name = "id_anggota_txt";
            this.id_anggota_txt.Size = new System.Drawing.Size(130, 27);
            this.id_anggota_txt.TabIndex = 44;
            // 
            // id_pinjam_txt
            // 
            this.id_pinjam_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pinjam_txt.Location = new System.Drawing.Point(190, 35);
            this.id_pinjam_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_pinjam_txt.Name = "id_pinjam_txt";
            this.id_pinjam_txt.Size = new System.Drawing.Size(130, 27);
            this.id_pinjam_txt.TabIndex = 40;
            // 
            // id_buku_lbl
            // 
            this.id_buku_lbl.AutoSize = true;
            this.id_buku_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buku_lbl.Location = new System.Drawing.Point(30, 120);
            this.id_buku_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_buku_lbl.Name = "id_buku_lbl";
            this.id_buku_lbl.Size = new System.Drawing.Size(76, 20);
            this.id_buku_lbl.TabIndex = 49;
            this.id_buku_lbl.Text = "ID Buku";
            // 
            // id_anggota_lbl
            // 
            this.id_anggota_lbl.AutoSize = true;
            this.id_anggota_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_anggota_lbl.Location = new System.Drawing.Point(30, 80);
            this.id_anggota_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_anggota_lbl.Name = "id_anggota_lbl";
            this.id_anggota_lbl.Size = new System.Drawing.Size(102, 20);
            this.id_anggota_lbl.TabIndex = 41;
            this.id_anggota_lbl.Text = "ID Anggota";
            // 
            // bts_waktu_lbl
            // 
            this.bts_waktu_lbl.AutoSize = true;
            this.bts_waktu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bts_waktu_lbl.Location = new System.Drawing.Point(30, 200);
            this.bts_waktu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bts_waktu_lbl.Name = "bts_waktu_lbl";
            this.bts_waktu_lbl.Size = new System.Drawing.Size(116, 20);
            this.bts_waktu_lbl.TabIndex = 47;
            this.bts_waktu_lbl.Text = "Batas Waktu";
            // 
            // tgl_pinjam_lbl
            // 
            this.tgl_pinjam_lbl.AutoSize = true;
            this.tgl_pinjam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_pinjam_lbl.Location = new System.Drawing.Point(30, 160);
            this.tgl_pinjam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tgl_pinjam_lbl.Name = "tgl_pinjam_lbl";
            this.tgl_pinjam_lbl.Size = new System.Drawing.Size(138, 20);
            this.tgl_pinjam_lbl.TabIndex = 42;
            this.tgl_pinjam_lbl.Text = "Tanggal Pinjam";
            // 
            // judul_txt
            // 
            this.judul_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_txt.Location = new System.Drawing.Point(330, 115);
            this.judul_txt.Margin = new System.Windows.Forms.Padding(4);
            this.judul_txt.Name = "judul_txt";
            this.judul_txt.Size = new System.Drawing.Size(200, 27);
            this.judul_txt.TabIndex = 46;
            // 
            // peminjaman_dgv
            // 
            this.peminjaman_dgv.AllowUserToAddRows = false;
            this.peminjaman_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peminjaman_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.peminjaman_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peminjaman_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId_pinjam,
            this.cId_anggota,
            this.cId_buku,
            this.cTgl_pinjam,
            this.cBts_waktu,
            this.cId_petugas});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peminjaman_dgv.DefaultCellStyle = dataGridViewCellStyle14;
            this.peminjaman_dgv.Location = new System.Drawing.Point(625, 90);
            this.peminjaman_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.peminjaman_dgv.Name = "peminjaman_dgv";
            this.peminjaman_dgv.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peminjaman_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.peminjaman_dgv.RowHeadersWidth = 51;
            this.peminjaman_dgv.RowTemplate.Height = 24;
            this.peminjaman_dgv.Size = new System.Drawing.Size(700, 340);
            this.peminjaman_dgv.TabIndex = 100;
            this.peminjaman_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peminjaman_dgv_CellContentClick);
            // 
            // cId_pinjam
            // 
            this.cId_pinjam.DataPropertyName = "id_pinjam";
            this.cId_pinjam.HeaderText = "ID Pinjam";
            this.cId_pinjam.MinimumWidth = 6;
            this.cId_pinjam.Name = "cId_pinjam";
            this.cId_pinjam.ReadOnly = true;
            this.cId_pinjam.Width = 125;
            // 
            // cId_anggota
            // 
            this.cId_anggota.DataPropertyName = "id_anggota";
            this.cId_anggota.HeaderText = "ID Anggota";
            this.cId_anggota.MinimumWidth = 6;
            this.cId_anggota.Name = "cId_anggota";
            this.cId_anggota.ReadOnly = true;
            this.cId_anggota.Width = 125;
            // 
            // cId_buku
            // 
            this.cId_buku.DataPropertyName = "id_buku";
            this.cId_buku.HeaderText = "ID Buku";
            this.cId_buku.MinimumWidth = 6;
            this.cId_buku.Name = "cId_buku";
            this.cId_buku.ReadOnly = true;
            this.cId_buku.Width = 125;
            // 
            // cTgl_pinjam
            // 
            this.cTgl_pinjam.DataPropertyName = "tgl_pinjam";
            dataGridViewCellStyle12.Format = "dd-MM-yyyy";
            dataGridViewCellStyle12.NullValue = null;
            this.cTgl_pinjam.DefaultCellStyle = dataGridViewCellStyle12;
            this.cTgl_pinjam.HeaderText = "Tanggal Pinjam";
            this.cTgl_pinjam.MinimumWidth = 6;
            this.cTgl_pinjam.Name = "cTgl_pinjam";
            this.cTgl_pinjam.ReadOnly = true;
            this.cTgl_pinjam.Width = 125;
            // 
            // cBts_waktu
            // 
            this.cBts_waktu.DataPropertyName = "bts_waktu";
            dataGridViewCellStyle13.Format = "dd-MM-yyyy";
            dataGridViewCellStyle13.NullValue = null;
            this.cBts_waktu.DefaultCellStyle = dataGridViewCellStyle13;
            this.cBts_waktu.HeaderText = "Batas Waktu";
            this.cBts_waktu.MinimumWidth = 6;
            this.cBts_waktu.Name = "cBts_waktu";
            this.cBts_waktu.ReadOnly = true;
            this.cBts_waktu.Width = 125;
            // 
            // cId_petugas
            // 
            this.cId_petugas.DataPropertyName = "id_petugas";
            this.cId_petugas.HeaderText = "ID Petugas";
            this.cId_petugas.MinimumWidth = 6;
            this.cId_petugas.Name = "cId_petugas";
            this.cId_petugas.ReadOnly = true;
            this.cId_petugas.Width = 125;
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 503);
            this.Controls.Add(this.peminjaman_dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Peminjaman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Peminjaman_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peminjaman_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox id_buku_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idpinjam_lbl;
        private System.Windows.Forms.TextBox id_anggota_txt;
        private System.Windows.Forms.TextBox id_pinjam_txt;
        private System.Windows.Forms.Label id_buku_lbl;
        private System.Windows.Forms.Label id_anggota_lbl;
        private System.Windows.Forms.Label bts_waktu_lbl;
        private System.Windows.Forms.Label tgl_pinjam_lbl;
        private System.Windows.Forms.TextBox judul_txt;
        private System.Windows.Forms.DateTimePicker bts_waktu_dtp;
        private System.Windows.Forms.DateTimePicker tgl_pinjam_dtp;
        private System.Windows.Forms.DataGridView peminjaman_dgv;
        public System.Windows.Forms.TextBox nama_petugas_txt;
        public System.Windows.Forms.TextBox id_petugas_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTgl_pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBts_waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_petugas;
        private System.Windows.Forms.Button cetak_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button simpan_btn;
    }
}
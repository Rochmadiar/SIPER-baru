namespace SIPER.View
{
    partial class DataBuku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cetak_btn = new System.Windows.Forms.Button();
            this.buku_dgv = new System.Windows.Forms.DataGridView();
            this.cId_buku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPengarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPenerbit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cari_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kategori_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stok_txt = new System.Windows.Forms.TextBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.idbuku_lbl = new System.Windows.Forms.Label();
            this.judul_txt = new System.Windows.Forms.TextBox();
            this.id_buku_txt = new System.Windows.Forms.TextBox();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.pengarang_lbl = new System.Windows.Forms.Label();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.penerbit_txt = new System.Windows.Forms.TextBox();
            this.tahun_lbl = new System.Windows.Forms.Label();
            this.tahun_txt = new System.Windows.Forms.TextBox();
            this.penerbit_lbl = new System.Windows.Forms.Label();
            this.pengarang_txt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buku_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cetak_btn);
            this.groupBox2.Controls.Add(this.buku_dgv);
            this.groupBox2.Controls.Add(this.cari_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cari_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(570, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(750, 400);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buku";
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
            this.cetak_btn.Location = new System.Drawing.Point(400, 30);
            this.cetak_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cetak_btn.Name = "cetak_btn";
            this.cetak_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.cetak_btn.Size = new System.Drawing.Size(110, 35);
            this.cetak_btn.TabIndex = 56;
            this.cetak_btn.Text = "Cetak";
            this.cetak_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetak_btn.UseVisualStyleBackColor = false;
            this.cetak_btn.Click += new System.EventHandler(this.cetak_btn_Click);
            // 
            // buku_dgv
            // 
            this.buku_dgv.AllowUserToAddRows = false;
            this.buku_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buku_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buku_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buku_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId_buku,
            this.cKategori,
            this.cJudul,
            this.cPengarang,
            this.cPenerbit,
            this.cTahun,
            this.cStok});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buku_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.buku_dgv.Location = new System.Drawing.Point(30, 90);
            this.buku_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.buku_dgv.Name = "buku_dgv";
            this.buku_dgv.ReadOnly = true;
            this.buku_dgv.RowHeadersWidth = 51;
            this.buku_dgv.RowTemplate.Height = 24;
            this.buku_dgv.Size = new System.Drawing.Size(685, 280);
            this.buku_dgv.TabIndex = 55;
            this.buku_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buku_dgv_CellContentClick);
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
            // cKategori
            // 
            this.cKategori.DataPropertyName = "kategori";
            this.cKategori.HeaderText = "Kategori";
            this.cKategori.MinimumWidth = 6;
            this.cKategori.Name = "cKategori";
            this.cKategori.ReadOnly = true;
            this.cKategori.Width = 125;
            // 
            // cJudul
            // 
            this.cJudul.DataPropertyName = "judul";
            this.cJudul.HeaderText = "Judul";
            this.cJudul.MinimumWidth = 6;
            this.cJudul.Name = "cJudul";
            this.cJudul.ReadOnly = true;
            this.cJudul.Width = 125;
            // 
            // cPengarang
            // 
            this.cPengarang.DataPropertyName = "pengarang";
            this.cPengarang.HeaderText = "Pengarang";
            this.cPengarang.MinimumWidth = 6;
            this.cPengarang.Name = "cPengarang";
            this.cPengarang.ReadOnly = true;
            this.cPengarang.Width = 125;
            // 
            // cPenerbit
            // 
            this.cPenerbit.DataPropertyName = "penerbit";
            this.cPenerbit.HeaderText = "Penerbit";
            this.cPenerbit.MinimumWidth = 6;
            this.cPenerbit.Name = "cPenerbit";
            this.cPenerbit.ReadOnly = true;
            this.cPenerbit.Width = 125;
            // 
            // cTahun
            // 
            this.cTahun.DataPropertyName = "tahun";
            this.cTahun.HeaderText = "Tahun";
            this.cTahun.MinimumWidth = 6;
            this.cTahun.Name = "cTahun";
            this.cTahun.ReadOnly = true;
            this.cTahun.Width = 125;
            // 
            // cStok
            // 
            this.cStok.DataPropertyName = "stok";
            this.cStok.HeaderText = "Stok";
            this.cStok.MinimumWidth = 6;
            this.cStok.Name = "cStok";
            this.cStok.ReadOnly = true;
            this.cStok.Width = 125;
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
            this.cari_btn.UseVisualStyleBackColor = false;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID Buku";
            // 
            // cari_txt
            // 
            this.cari_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txt.Location = new System.Drawing.Point(130, 35);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(150, 27);
            this.cari_txt.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 49;
            this.label1.Text = "FORM BUKU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kategori_cmb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stok_txt);
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.hapus_btn);
            this.groupBox1.Controls.Add(this.ubah_btn);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Controls.Add(this.idbuku_lbl);
            this.groupBox1.Controls.Add(this.judul_txt);
            this.groupBox1.Controls.Add(this.id_buku_txt);
            this.groupBox1.Controls.Add(this.kategori_lbl);
            this.groupBox1.Controls.Add(this.pengarang_lbl);
            this.groupBox1.Controls.Add(this.judul_lbl);
            this.groupBox1.Controls.Add(this.penerbit_txt);
            this.groupBox1.Controls.Add(this.tahun_lbl);
            this.groupBox1.Controls.Add(this.tahun_txt);
            this.groupBox1.Controls.Add(this.penerbit_lbl);
            this.groupBox1.Controls.Add(this.pengarang_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 400);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            // 
            // kategori_cmb
            // 
            this.kategori_cmb.FormattingEnabled = true;
            this.kategori_cmb.Location = new System.Drawing.Point(170, 75);
            this.kategori_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.kategori_cmb.Name = "kategori_cmb";
            this.kategori_cmb.Size = new System.Drawing.Size(250, 28);
            this.kategori_cmb.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Stok";
            // 
            // stok_txt
            // 
            this.stok_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_txt.Location = new System.Drawing.Point(170, 275);
            this.stok_txt.Margin = new System.Windows.Forms.Padding(4);
            this.stok_txt.Name = "stok_txt";
            this.stok_txt.Size = new System.Drawing.Size(130, 27);
            this.stok_txt.TabIndex = 56;
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
            this.batal_btn.Location = new System.Drawing.Point(390, 330);
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
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.SystemColors.Control;
            this.hapus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hapus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hapus_btn.Image = global::SIPER.Properties.Resources.hapus;
            this.hapus_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapus_btn.Location = new System.Drawing.Point(270, 330);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.hapus_btn.Size = new System.Drawing.Size(110, 35);
            this.hapus_btn.TabIndex = 53;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click_1);
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
            this.ubah_btn.Location = new System.Drawing.Point(160, 330);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.ubah_btn.Size = new System.Drawing.Size(100, 35);
            this.ubah_btn.TabIndex = 52;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ubah_btn.UseVisualStyleBackColor = false;
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
            this.simpan_btn.Location = new System.Drawing.Point(30, 330);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.simpan_btn.Size = new System.Drawing.Size(120, 35);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click_1);
            // 
            // idbuku_lbl
            // 
            this.idbuku_lbl.AutoSize = true;
            this.idbuku_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbuku_lbl.Location = new System.Drawing.Point(30, 40);
            this.idbuku_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idbuku_lbl.Name = "idbuku_lbl";
            this.idbuku_lbl.Size = new System.Drawing.Size(76, 20);
            this.idbuku_lbl.TabIndex = 39;
            this.idbuku_lbl.Text = "ID Buku";
            // 
            // judul_txt
            // 
            this.judul_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_txt.Location = new System.Drawing.Point(170, 115);
            this.judul_txt.Margin = new System.Windows.Forms.Padding(4);
            this.judul_txt.Name = "judul_txt";
            this.judul_txt.Size = new System.Drawing.Size(250, 27);
            this.judul_txt.TabIndex = 44;
            // 
            // id_buku_txt
            // 
            this.id_buku_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buku_txt.Location = new System.Drawing.Point(170, 35);
            this.id_buku_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_buku_txt.Name = "id_buku_txt";
            this.id_buku_txt.Size = new System.Drawing.Size(130, 27);
            this.id_buku_txt.TabIndex = 40;
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori_lbl.Location = new System.Drawing.Point(30, 80);
            this.kategori_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(79, 20);
            this.kategori_lbl.TabIndex = 49;
            this.kategori_lbl.Text = "Kategori";
            // 
            // pengarang_lbl
            // 
            this.pengarang_lbl.AutoSize = true;
            this.pengarang_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarang_lbl.Location = new System.Drawing.Point(30, 160);
            this.pengarang_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pengarang_lbl.Name = "pengarang_lbl";
            this.pengarang_lbl.Size = new System.Drawing.Size(98, 20);
            this.pengarang_lbl.TabIndex = 43;
            this.pengarang_lbl.Text = "Pengarang";
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.Location = new System.Drawing.Point(30, 120);
            this.judul_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(54, 20);
            this.judul_lbl.TabIndex = 41;
            this.judul_lbl.Text = "Judul";
            // 
            // penerbit_txt
            // 
            this.penerbit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbit_txt.Location = new System.Drawing.Point(170, 195);
            this.penerbit_txt.Margin = new System.Windows.Forms.Padding(4);
            this.penerbit_txt.Name = "penerbit_txt";
            this.penerbit_txt.Size = new System.Drawing.Size(250, 27);
            this.penerbit_txt.TabIndex = 45;
            // 
            // tahun_lbl
            // 
            this.tahun_lbl.AutoSize = true;
            this.tahun_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun_lbl.Location = new System.Drawing.Point(30, 240);
            this.tahun_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tahun_lbl.Name = "tahun_lbl";
            this.tahun_lbl.Size = new System.Drawing.Size(60, 20);
            this.tahun_lbl.TabIndex = 47;
            this.tahun_lbl.Text = "Tahun";
            // 
            // tahun_txt
            // 
            this.tahun_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun_txt.Location = new System.Drawing.Point(170, 235);
            this.tahun_txt.Margin = new System.Windows.Forms.Padding(4);
            this.tahun_txt.Name = "tahun_txt";
            this.tahun_txt.Size = new System.Drawing.Size(130, 27);
            this.tahun_txt.TabIndex = 48;
            // 
            // penerbit_lbl
            // 
            this.penerbit_lbl.AutoSize = true;
            this.penerbit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbit_lbl.Location = new System.Drawing.Point(30, 200);
            this.penerbit_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.penerbit_lbl.Name = "penerbit_lbl";
            this.penerbit_lbl.Size = new System.Drawing.Size(79, 20);
            this.penerbit_lbl.TabIndex = 42;
            this.penerbit_lbl.Text = "Penerbit";
            // 
            // pengarang_txt
            // 
            this.pengarang_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarang_txt.Location = new System.Drawing.Point(170, 155);
            this.pengarang_txt.Margin = new System.Windows.Forms.Padding(4);
            this.pengarang_txt.Name = "pengarang_txt";
            this.pengarang_txt.Size = new System.Drawing.Size(250, 27);
            this.pengarang_txt.TabIndex = 46;
            // 
            // DataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataBuku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buku_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView buku_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stok_txt;
        private System.Windows.Forms.Label idbuku_lbl;
        private System.Windows.Forms.TextBox judul_txt;
        private System.Windows.Forms.TextBox id_buku_txt;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.Label pengarang_lbl;
        private System.Windows.Forms.Label judul_lbl;
        private System.Windows.Forms.TextBox penerbit_txt;
        private System.Windows.Forms.Label tahun_lbl;
        private System.Windows.Forms.TextBox tahun_txt;
        private System.Windows.Forms.Label penerbit_lbl;
        private System.Windows.Forms.TextBox pengarang_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPengarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPenerbit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStok;
        private System.Windows.Forms.ComboBox kategori_cmb;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button cetak_btn;
        private System.Windows.Forms.Button cari_btn;
    }
}
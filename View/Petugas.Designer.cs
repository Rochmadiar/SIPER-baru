namespace SIPER.View
{
    partial class Petugas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.idpetugas_lbl = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.jabatan_cmb = new System.Windows.Forms.ComboBox();
            this.id_petugas_txt = new System.Windows.Forms.TextBox();
            this.jabatan_lbl = new System.Windows.Forms.Label();
            this.telepon_lbl = new System.Windows.Forms.Label();
            this.nama_lbl = new System.Windows.Forms.Label();
            this.alamat_txt = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.alamat_lbl = new System.Windows.Forms.Label();
            this.telepon_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.petugas_dgv = new System.Windows.Forms.DataGridView();
            this.cId_petugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cari_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petugas_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.hapus_btn);
            this.groupBox1.Controls.Add(this.ubah_btn);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Controls.Add(this.idpetugas_lbl);
            this.groupBox1.Controls.Add(this.nama_txt);
            this.groupBox1.Controls.Add(this.jabatan_cmb);
            this.groupBox1.Controls.Add(this.id_petugas_txt);
            this.groupBox1.Controls.Add(this.jabatan_lbl);
            this.groupBox1.Controls.Add(this.telepon_lbl);
            this.groupBox1.Controls.Add(this.nama_lbl);
            this.groupBox1.Controls.Add(this.alamat_txt);
            this.groupBox1.Controls.Add(this.pass_lbl);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.alamat_lbl);
            this.groupBox1.Controls.Add(this.telepon_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 415);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Petugas";
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
            this.batal_btn.Location = new System.Drawing.Point(390, 360);
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
            this.hapus_btn.Location = new System.Drawing.Point(270, 360);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.hapus_btn.Size = new System.Drawing.Size(110, 35);
            this.hapus_btn.TabIndex = 53;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hapus_btn.UseVisualStyleBackColor = false;
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
            this.ubah_btn.Location = new System.Drawing.Point(160, 360);
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
            this.simpan_btn.Location = new System.Drawing.Point(30, 360);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.simpan_btn.Size = new System.Drawing.Size(120, 35);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = " Simpan";
            this.simpan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // idpetugas_lbl
            // 
            this.idpetugas_lbl.AutoSize = true;
            this.idpetugas_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpetugas_lbl.Location = new System.Drawing.Point(25, 40);
            this.idpetugas_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idpetugas_lbl.Name = "idpetugas_lbl";
            this.idpetugas_lbl.Size = new System.Drawing.Size(102, 20);
            this.idpetugas_lbl.TabIndex = 39;
            this.idpetugas_lbl.Text = "ID Petugas";
            // 
            // nama_txt
            // 
            this.nama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(170, 75);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(270, 27);
            this.nama_txt.TabIndex = 44;
            // 
            // jabatan_cmb
            // 
            this.jabatan_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jabatan_cmb.FormattingEnabled = true;
            this.jabatan_cmb.Items.AddRange(new object[] {
            "Administrator",
            "Pelayanan"});
            this.jabatan_cmb.Location = new System.Drawing.Point(170, 115);
            this.jabatan_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.jabatan_cmb.Name = "jabatan_cmb";
            this.jabatan_cmb.Size = new System.Drawing.Size(200, 28);
            this.jabatan_cmb.TabIndex = 50;
            this.jabatan_cmb.SelectedIndexChanged += new System.EventHandler(this.jabatan_cmb_SelectedIndexChanged);
            // 
            // id_petugas_txt
            // 
            this.id_petugas_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_petugas_txt.Location = new System.Drawing.Point(170, 35);
            this.id_petugas_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_petugas_txt.Name = "id_petugas_txt";
            this.id_petugas_txt.Size = new System.Drawing.Size(130, 27);
            this.id_petugas_txt.TabIndex = 40;
            // 
            // jabatan_lbl
            // 
            this.jabatan_lbl.AutoSize = true;
            this.jabatan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jabatan_lbl.Location = new System.Drawing.Point(25, 120);
            this.jabatan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jabatan_lbl.Name = "jabatan_lbl";
            this.jabatan_lbl.Size = new System.Drawing.Size(75, 20);
            this.jabatan_lbl.TabIndex = 49;
            this.jabatan_lbl.Text = "Jabatan";
            // 
            // telepon_lbl
            // 
            this.telepon_lbl.AutoSize = true;
            this.telepon_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telepon_lbl.Location = new System.Drawing.Point(25, 160);
            this.telepon_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telepon_lbl.Name = "telepon_lbl";
            this.telepon_lbl.Size = new System.Drawing.Size(109, 20);
            this.telepon_lbl.TabIndex = 43;
            this.telepon_lbl.Text = "No. Telepon";
            // 
            // nama_lbl
            // 
            this.nama_lbl.AutoSize = true;
            this.nama_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_lbl.Location = new System.Drawing.Point(25, 80);
            this.nama_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nama_lbl.Name = "nama_lbl";
            this.nama_lbl.Size = new System.Drawing.Size(133, 20);
            this.nama_lbl.TabIndex = 41;
            this.nama_lbl.Text = "Nama Lengkap";
            // 
            // alamat_txt
            // 
            this.alamat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_txt.Location = new System.Drawing.Point(170, 195);
            this.alamat_txt.Margin = new System.Windows.Forms.Padding(4);
            this.alamat_txt.Multiline = true;
            this.alamat_txt.Name = "alamat_txt";
            this.alamat_txt.Size = new System.Drawing.Size(270, 85);
            this.alamat_txt.TabIndex = 45;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.Location = new System.Drawing.Point(25, 300);
            this.pass_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(91, 20);
            this.pass_lbl.TabIndex = 47;
            this.pass_lbl.Text = "Password";
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(170, 295);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(4);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(200, 27);
            this.pass_txt.TabIndex = 48;
            // 
            // alamat_lbl
            // 
            this.alamat_lbl.AutoSize = true;
            this.alamat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_lbl.Location = new System.Drawing.Point(25, 200);
            this.alamat_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alamat_lbl.Name = "alamat_lbl";
            this.alamat_lbl.Size = new System.Drawing.Size(67, 20);
            this.alamat_lbl.TabIndex = 42;
            this.alamat_lbl.Text = "Alamat";
            // 
            // telepon_txt
            // 
            this.telepon_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telepon_txt.Location = new System.Drawing.Point(170, 155);
            this.telepon_txt.Margin = new System.Windows.Forms.Padding(4);
            this.telepon_txt.Name = "telepon_txt";
            this.telepon_txt.Size = new System.Drawing.Size(200, 27);
            this.telepon_txt.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 45;
            this.label1.Text = "FORM PETUGAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petugas_dgv);
            this.groupBox2.Controls.Add(this.cari_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cari_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(570, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(750, 415);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // petugas_dgv
            // 
            this.petugas_dgv.AllowUserToAddRows = false;
            this.petugas_dgv.AllowUserToDeleteRows = false;
            this.petugas_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.petugas_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.petugas_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petugas_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId_petugas,
            this.cNama,
            this.cJabatan,
            this.cTelepon,
            this.cAlamat,
            this.cPassword});
            this.petugas_dgv.Location = new System.Drawing.Point(30, 90);
            this.petugas_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.petugas_dgv.Name = "petugas_dgv";
            this.petugas_dgv.ReadOnly = true;
            this.petugas_dgv.RowHeadersWidth = 51;
            this.petugas_dgv.RowTemplate.Height = 24;
            this.petugas_dgv.Size = new System.Drawing.Size(685, 300);
            this.petugas_dgv.TabIndex = 55;
            this.petugas_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petugas_dgv_CellContentClick);
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
            // cNama
            // 
            this.cNama.DataPropertyName = "nama";
            this.cNama.HeaderText = "Nama";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 125;
            // 
            // cJabatan
            // 
            this.cJabatan.DataPropertyName = "jabatan";
            this.cJabatan.HeaderText = "Jabatan";
            this.cJabatan.MinimumWidth = 6;
            this.cJabatan.Name = "cJabatan";
            this.cJabatan.ReadOnly = true;
            this.cJabatan.Width = 125;
            // 
            // cTelepon
            // 
            this.cTelepon.DataPropertyName = "telepon";
            this.cTelepon.HeaderText = "No. Telepon";
            this.cTelepon.MinimumWidth = 6;
            this.cTelepon.Name = "cTelepon";
            this.cTelepon.ReadOnly = true;
            this.cTelepon.Width = 125;
            // 
            // cAlamat
            // 
            this.cAlamat.DataPropertyName = "alamat";
            this.cAlamat.HeaderText = "Alamat";
            this.cAlamat.MinimumWidth = 6;
            this.cAlamat.Name = "cAlamat";
            this.cAlamat.ReadOnly = true;
            this.cAlamat.Width = 125;
            // 
            // cPassword
            // 
            this.cPassword.DataPropertyName = "password";
            this.cPassword.HeaderText = "Password";
            this.cPassword.MinimumWidth = 6;
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            this.cPassword.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID Petugas";
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
            // Petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Petugas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Petugas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petugas_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idpetugas_lbl;
        private System.Windows.Forms.Label jabatan_lbl;
        private System.Windows.Forms.Label telepon_lbl;
        private System.Windows.Forms.Label nama_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label alamat_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.ComboBox jabatan_cmb;
        private System.Windows.Forms.TextBox id_petugas_txt;
        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox telepon_txt;
        private System.Windows.Forms.DataGridView petugas_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_petugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPassword;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button cari_btn;
    }
}
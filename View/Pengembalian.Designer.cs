namespace SIPER.View
{
    partial class Pengembalian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kembali_dgv = new System.Windows.Forms.DataGridView();
            this.cId_kembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBts_waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTgl_kembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_petugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.cetak_btn = new System.Windows.Forms.Button();
            this.tgl_kembali_dtp = new System.Windows.Forms.DateTimePicker();
            this.bts_waktu_dtp = new System.Windows.Forms.DateTimePicker();
            this.nama_petugas_txt = new System.Windows.Forms.TextBox();
            this.hilang_check = new System.Windows.Forms.CheckBox();
            this.telat_check = new System.Windows.Forms.CheckBox();
            this.rusak_check = new System.Windows.Forms.CheckBox();
            this.tepat_check = new System.Windows.Forms.CheckBox();
            this.id_kembali_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.denda_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.pengarang_lbl = new System.Windows.Forms.Label();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.tgl_pinjam_lbl = new System.Windows.Forms.Label();
            this.id_petugas_txt = new System.Windows.Forms.TextBox();
            this.id_petugas_lbl = new System.Windows.Forms.Label();
            this.id_pinjam_txt = new System.Windows.Forms.TextBox();
            this.id_pinjam_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kembali_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kembali_dgv
            // 
            this.kembali_dgv.AllowUserToAddRows = false;
            this.kembali_dgv.AllowUserToDeleteRows = false;
            this.kembali_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kembali_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kembali_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kembali_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId_kembali,
            this.cId_pinjam,
            this.cBts_waktu,
            this.cTgl_kembali,
            this.cCek,
            this.cDenda,
            this.cId_petugas});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kembali_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.kembali_dgv.GridColor = System.Drawing.SystemColors.Control;
            this.kembali_dgv.Location = new System.Drawing.Point(590, 90);
            this.kembali_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.kembali_dgv.Name = "kembali_dgv";
            this.kembali_dgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kembali_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.kembali_dgv.RowHeadersWidth = 40;
            this.kembali_dgv.RowTemplate.Height = 24;
            this.kembali_dgv.Size = new System.Drawing.Size(730, 410);
            this.kembali_dgv.TabIndex = 69;
            // 
            // cId_kembali
            // 
            this.cId_kembali.DataPropertyName = "id_kembali";
            this.cId_kembali.HeaderText = "ID Kembali";
            this.cId_kembali.MinimumWidth = 6;
            this.cId_kembali.Name = "cId_kembali";
            this.cId_kembali.ReadOnly = true;
            this.cId_kembali.Width = 125;
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
            // cBts_waktu
            // 
            this.cBts_waktu.DataPropertyName = "batas_waktu";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.cBts_waktu.DefaultCellStyle = dataGridViewCellStyle2;
            this.cBts_waktu.HeaderText = "Batas Waktu";
            this.cBts_waktu.MinimumWidth = 6;
            this.cBts_waktu.Name = "cBts_waktu";
            this.cBts_waktu.ReadOnly = true;
            this.cBts_waktu.Width = 125;
            // 
            // cTgl_kembali
            // 
            this.cTgl_kembali.DataPropertyName = "tgl_kembali";
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.cTgl_kembali.DefaultCellStyle = dataGridViewCellStyle3;
            this.cTgl_kembali.HeaderText = "Tanggal Kembali";
            this.cTgl_kembali.MinimumWidth = 6;
            this.cTgl_kembali.Name = "cTgl_kembali";
            this.cTgl_kembali.ReadOnly = true;
            this.cTgl_kembali.Width = 125;
            // 
            // cCek
            // 
            this.cCek.DataPropertyName = "cek";
            this.cCek.HeaderText = "Cek";
            this.cCek.MinimumWidth = 6;
            this.cCek.Name = "cCek";
            this.cCek.ReadOnly = true;
            this.cCek.Width = 125;
            // 
            // cDenda
            // 
            this.cDenda.DataPropertyName = "denda";
            this.cDenda.HeaderText = "Total Denda";
            this.cDenda.MinimumWidth = 6;
            this.cDenda.Name = "cDenda";
            this.cDenda.ReadOnly = true;
            this.cDenda.Width = 125;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.cetak_btn);
            this.groupBox1.Controls.Add(this.tgl_kembali_dtp);
            this.groupBox1.Controls.Add(this.bts_waktu_dtp);
            this.groupBox1.Controls.Add(this.nama_petugas_txt);
            this.groupBox1.Controls.Add(this.hilang_check);
            this.groupBox1.Controls.Add(this.telat_check);
            this.groupBox1.Controls.Add(this.rusak_check);
            this.groupBox1.Controls.Add(this.tepat_check);
            this.groupBox1.Controls.Add(this.id_kembali_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.denda_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.judul_lbl);
            this.groupBox1.Controls.Add(this.pengarang_lbl);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Controls.Add(this.tgl_pinjam_lbl);
            this.groupBox1.Controls.Add(this.id_petugas_txt);
            this.groupBox1.Controls.Add(this.id_petugas_lbl);
            this.groupBox1.Controls.Add(this.id_pinjam_txt);
            this.groupBox1.Controls.Add(this.id_pinjam_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 422);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengembalian";
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.SystemColors.Control;
            this.batal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.batal_btn.Image = global::SIPER.Properties.Resources.batal;
            this.batal_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batal_btn.Location = new System.Drawing.Point(170, 360);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(4);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.batal_btn.Size = new System.Drawing.Size(100, 35);
            this.batal_btn.TabIndex = 107;
            this.batal_btn.Text = "Batal";
            this.batal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // cetak_btn
            // 
            this.cetak_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cetak_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cetak_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cetak_btn.Image = global::SIPER.Properties.Resources.cetak;
            this.cetak_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetak_btn.Location = new System.Drawing.Point(280, 360);
            this.cetak_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cetak_btn.Name = "cetak_btn";
            this.cetak_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.cetak_btn.Size = new System.Drawing.Size(110, 35);
            this.cetak_btn.TabIndex = 106;
            this.cetak_btn.Text = "Cetak";
            this.cetak_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetak_btn.UseVisualStyleBackColor = false;
            this.cetak_btn.Click += new System.EventHandler(this.cetak_btn_Click);
            // 
            // tgl_kembali_dtp
            // 
            this.tgl_kembali_dtp.CustomFormat = "dd MMM yyyy";
            this.tgl_kembali_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_kembali_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl_kembali_dtp.Location = new System.Drawing.Point(190, 155);
            this.tgl_kembali_dtp.Margin = new System.Windows.Forms.Padding(4);
            this.tgl_kembali_dtp.Name = "tgl_kembali_dtp";
            this.tgl_kembali_dtp.Size = new System.Drawing.Size(200, 27);
            this.tgl_kembali_dtp.TabIndex = 105;
            // 
            // bts_waktu_dtp
            // 
            this.bts_waktu_dtp.CustomFormat = "dd MMM yyyy";
            this.bts_waktu_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bts_waktu_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bts_waktu_dtp.Location = new System.Drawing.Point(190, 115);
            this.bts_waktu_dtp.Margin = new System.Windows.Forms.Padding(4);
            this.bts_waktu_dtp.Name = "bts_waktu_dtp";
            this.bts_waktu_dtp.Size = new System.Drawing.Size(200, 27);
            this.bts_waktu_dtp.TabIndex = 104;
            // 
            // nama_petugas_txt
            // 
            this.nama_petugas_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_petugas_txt.Location = new System.Drawing.Point(330, 305);
            this.nama_petugas_txt.Name = "nama_petugas_txt";
            this.nama_petugas_txt.Size = new System.Drawing.Size(150, 27);
            this.nama_petugas_txt.TabIndex = 103;
            // 
            // hilang_check
            // 
            this.hilang_check.AutoSize = true;
            this.hilang_check.Location = new System.Drawing.Point(320, 225);
            this.hilang_check.Margin = new System.Windows.Forms.Padding(4);
            this.hilang_check.Name = "hilang_check";
            this.hilang_check.Size = new System.Drawing.Size(79, 24);
            this.hilang_check.TabIndex = 102;
            this.hilang_check.Text = "Hilang";
            this.hilang_check.UseVisualStyleBackColor = true;
            // 
            // telat_check
            // 
            this.telat_check.AutoSize = true;
            this.telat_check.Location = new System.Drawing.Point(320, 195);
            this.telat_check.Margin = new System.Windows.Forms.Padding(4);
            this.telat_check.Name = "telat_check";
            this.telat_check.Size = new System.Drawing.Size(68, 24);
            this.telat_check.TabIndex = 101;
            this.telat_check.Text = "Telat";
            this.telat_check.UseVisualStyleBackColor = true;
            // 
            // rusak_check
            // 
            this.rusak_check.AutoSize = true;
            this.rusak_check.Location = new System.Drawing.Point(190, 225);
            this.rusak_check.Margin = new System.Windows.Forms.Padding(4);
            this.rusak_check.Name = "rusak_check";
            this.rusak_check.Size = new System.Drawing.Size(78, 24);
            this.rusak_check.TabIndex = 100;
            this.rusak_check.Text = "Rusak";
            this.rusak_check.UseVisualStyleBackColor = true;
            // 
            // tepat_check
            // 
            this.tepat_check.AutoSize = true;
            this.tepat_check.Location = new System.Drawing.Point(190, 195);
            this.tepat_check.Margin = new System.Windows.Forms.Padding(4);
            this.tepat_check.Name = "tepat_check";
            this.tepat_check.Size = new System.Drawing.Size(125, 24);
            this.tepat_check.TabIndex = 99;
            this.tepat_check.Text = "Tepat Waktu";
            this.tepat_check.UseVisualStyleBackColor = true;
            // 
            // id_kembali_txt
            // 
            this.id_kembali_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_kembali_txt.Location = new System.Drawing.Point(190, 35);
            this.id_kembali_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_kembali_txt.Name = "id_kembali_txt";
            this.id_kembali_txt.Size = new System.Drawing.Size(130, 27);
            this.id_kembali_txt.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "ID Kembali";
            // 
            // denda_txt
            // 
            this.denda_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denda_txt.Location = new System.Drawing.Point(190, 265);
            this.denda_txt.Margin = new System.Windows.Forms.Padding(4);
            this.denda_txt.Name = "denda_txt";
            this.denda_txt.Size = new System.Drawing.Size(200, 27);
            this.denda_txt.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Total Denda";
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.Location = new System.Drawing.Point(30, 160);
            this.judul_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(148, 20);
            this.judul_lbl.TabIndex = 93;
            this.judul_lbl.Text = "Tanggal Kembali";
            // 
            // pengarang_lbl
            // 
            this.pengarang_lbl.AutoSize = true;
            this.pengarang_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarang_lbl.Location = new System.Drawing.Point(30, 200);
            this.pengarang_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pengarang_lbl.Name = "pengarang_lbl";
            this.pengarang_lbl.Size = new System.Drawing.Size(41, 20);
            this.pengarang_lbl.TabIndex = 92;
            this.pengarang_lbl.Text = "Cek";
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.SystemColors.Control;
            this.simpan_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.simpan_btn.Image = global::SIPER.Properties.Resources.simpan;
            this.simpan_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpan_btn.Location = new System.Drawing.Point(40, 360);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.simpan_btn.Size = new System.Drawing.Size(120, 35);
            this.simpan_btn.TabIndex = 90;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // tgl_pinjam_lbl
            // 
            this.tgl_pinjam_lbl.AutoSize = true;
            this.tgl_pinjam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_pinjam_lbl.Location = new System.Drawing.Point(30, 123);
            this.tgl_pinjam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tgl_pinjam_lbl.Name = "tgl_pinjam_lbl";
            this.tgl_pinjam_lbl.Size = new System.Drawing.Size(116, 20);
            this.tgl_pinjam_lbl.TabIndex = 88;
            this.tgl_pinjam_lbl.Text = "Batas Waktu";
            // 
            // id_petugas_txt
            // 
            this.id_petugas_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_petugas_txt.Location = new System.Drawing.Point(190, 305);
            this.id_petugas_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_petugas_txt.Name = "id_petugas_txt";
            this.id_petugas_txt.Size = new System.Drawing.Size(130, 27);
            this.id_petugas_txt.TabIndex = 87;
            // 
            // id_petugas_lbl
            // 
            this.id_petugas_lbl.AutoSize = true;
            this.id_petugas_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_petugas_lbl.Location = new System.Drawing.Point(30, 310);
            this.id_petugas_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_petugas_lbl.Name = "id_petugas_lbl";
            this.id_petugas_lbl.Size = new System.Drawing.Size(102, 20);
            this.id_petugas_lbl.TabIndex = 86;
            this.id_petugas_lbl.Text = "ID Petugas";
            // 
            // id_pinjam_txt
            // 
            this.id_pinjam_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pinjam_txt.Location = new System.Drawing.Point(190, 75);
            this.id_pinjam_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_pinjam_txt.Name = "id_pinjam_txt";
            this.id_pinjam_txt.Size = new System.Drawing.Size(130, 27);
            this.id_pinjam_txt.TabIndex = 85;
            // 
            // id_pinjam_lbl
            // 
            this.id_pinjam_lbl.AutoSize = true;
            this.id_pinjam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pinjam_lbl.Location = new System.Drawing.Point(30, 80);
            this.id_pinjam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_pinjam_lbl.Name = "id_pinjam_lbl";
            this.id_pinjam_lbl.Size = new System.Drawing.Size(91, 20);
            this.id_pinjam_lbl.TabIndex = 83;
            this.id_pinjam_lbl.Text = "ID Pinjam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 35);
            this.label1.TabIndex = 100;
            this.label1.Text = "FORM PENGEMBALIAN";
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kembali_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pengembalian";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kembali_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView kembali_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox nama_petugas_txt;
        private System.Windows.Forms.CheckBox hilang_check;
        private System.Windows.Forms.CheckBox telat_check;
        private System.Windows.Forms.CheckBox rusak_check;
        private System.Windows.Forms.CheckBox tepat_check;
        public System.Windows.Forms.TextBox id_kembali_txt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox denda_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label judul_lbl;
        private System.Windows.Forms.Label pengarang_lbl;
        private System.Windows.Forms.Label tgl_pinjam_lbl;
        public System.Windows.Forms.TextBox id_petugas_txt;
        private System.Windows.Forms.Label id_petugas_lbl;
        public System.Windows.Forms.TextBox id_pinjam_txt;
        private System.Windows.Forms.Label id_pinjam_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bts_waktu_dtp;
        private System.Windows.Forms.DateTimePicker tgl_kembali_dtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_kembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBts_waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTgl_kembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCek;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_petugas;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button cetak_btn;
    }
}
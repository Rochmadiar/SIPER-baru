using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPER.View
{
    using Model;

    public partial class Login : Form
    {
        classPetugas petugas = new classPetugas();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bersih();
            textBox_username.Focus();
        }

        //private void textBox_username_KeyPress(object sender, KeyPressEventArgs e){
        //if (e.KeyChar == 13){
        //textBox_pass.Focus();  } }

        //private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e){
        //if (e.KeyChar == 13){
        //login(); } }

        private void checkBox_show_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)
            {
                textBox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pass.UseSystemPasswordChar = true;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin akan keluar dari Sistem?", "KONFIRMASI",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login()
        {
            if (petugas.masukLogin(textBox_username.Text, textBox_pass.Text))
            {
                if (petugas.cekJabatan(textBox_username.Text, textBox_pass.Text) == "Administrator")
                {
                    MenuUtama menu = new MenuUtama();
                    menu.label_namauser.Text = petugas.ambilNamaUser(textBox_username.Text, textBox_pass.Text);
                    menu.label_jabatan.Text = "Administrator";
                    menu.label6.Visible = false;
                    menu.button_peminjaman.Visible = false;
                    menu.label7.Visible = false;
                    menu.button_pengembalian.Visible = false;
                    menu.Show();
                    this.Hide();
                }
                else if (petugas.cekJabatan(textBox_username.Text, textBox_pass.Text) == "Pelayanan")
                {
                    MenuUtama menu = new MenuUtama();
                    menu.id_petugas = textBox_username.Text;
                    menu.label_namauser.Text = petugas.ambilNamaUser(textBox_username.Text, textBox_pass.Text);
                    menu.label_jabatan.Text = "Pelayanan";
                    menu.label3.Visible = false;
                    menu.button_data.Visible = false;
                    menu.label4.Visible = false;
                    menu.button_anggota.Visible = false;
                    menu.label5.Visible = false;
                    menu.button_petugas.Visible = false;
                    menu.Show();
                    this.Hide();
                }
            }
            else if (textBox_username.Text == "" || textBox_pass.Text == "")
            {
                MessageBox.Show("Username atau Password Tidak Boleh Kosong!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bersih();
            }
            else
            {
                MessageBox.Show("Username dan Password Tidak Valid!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bersih();
            }
        }

        private void bersih()
        {
            textBox_pass.UseSystemPasswordChar = true;
            textBox_username.Clear();
            textBox_pass.Clear();
            textBox_username.Focus();
        }
    }
}

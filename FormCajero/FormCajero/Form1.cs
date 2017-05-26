using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormCajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnaceptar_login_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.cuenta == txtnocuenta_login.Text || Properties.Settings.Default.cuenta1 == txtnocuenta_login.Text)
            {
                Properties.Settings.Default.aux = txtnocuenta_login.Text;
                Properties.Settings.Default.Save();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Número de cuenta incorrecto");
                txtnocuenta_login.Text = "";
                txtnocuenta_login.Focus();
            }
        }

        private void btn1_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "1";
        }

        private void btn2_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "2";
        }

        private void btn3_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "3";
        }

        private void btn4_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "4";
        }

        private void btn5_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "5";
        }

        private void btn6_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text +=  "6";
        }

        private void btn7_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text +=  "7";
        }

        private void btn8_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "8";
        }

        private void btn9_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "9";
        }

        private void btn0_login_Click(object sender, EventArgs e)
        {
            txtnocuenta_login.Text += "0";
        }

        private void btnsalir_login_Click(object sender, EventArgs e)
        {
            DialogResult preguntasalir = MessageBox.Show("¿Está seguro de que desea salir?", "", MessageBoxButtons.YesNo);
            if (preguntasalir == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnborrar_login_Click(object sender, EventArgs e)
        {
            if (txtnocuenta_login.Text != "")
            {
                txtnocuenta_login.Text = txtnocuenta_login.Text.Substring(0, txtnocuenta_login.Text.Length - 1);
            }
        }
    }
}

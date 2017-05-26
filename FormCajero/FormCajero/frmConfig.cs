using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCajero
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cuenta = txtcuenta1.Text;
            //Properties.Settings.Default.cuenta1 = txtcuenta2.Text;
            //Properties.Settings.Default.cuenta2 = txtcuenta3.Text;

            Properties.Settings.Default.clave = txtcontrasena1.Text;
            //Properties.Settings.Default.clave1 = txtcontrasena2.Text;
            //Properties.Settings.Default.clave2 = txtcontrasena3.Text;

            Properties.Settings.Default.monto = txtbalance1.Text;
            //Properties.Settings.Default.monto1 = txtbalance2.Text;
            //Properties.Settings.Default.monto2 = txtbalance3.Text;

            Properties.Settings.Default.Save();
            MessageBox.Show("Guardado");
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtcuenta1.Text = Properties.Settings.Default.cuenta;
            //txtcuenta2.Text = Properties.Settings.Default.cuenta1;
            //txtcuenta3.Text = Properties.Settings.Default.cuenta2;

            txtcontrasena1.Text = Properties.Settings.Default.clave;
            //txtcontrasena2.Text = Properties.Settings.Default.clave1;
            //txtcontrasena3.Text = Properties.Settings.Default.clave2;

            txtbalance1.Text = Properties.Settings.Default.monto;
            //txtbalance2.Text = Properties.Settings.Default.monto1;
            //txtbalance3.Text = Properties.Settings.Default.monto2;
        }
    }
}

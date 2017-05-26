using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCajero
{
    public partial class Form3 : Form
    {
        public Form1 frm1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.Controls[0] == tabControl1.SelectedTab)
            {
                if (Properties.Settings.Default.aux == "123")
                {
                    lblBalance.Text = Properties.Settings.Default.monto;
                }
                else if(Properties.Settings.Default.aux == "1234")
                {
                    lblBalance.Text = Properties.Settings.Default.monto1;
                }
                validar();
                tabControl1.SelectTab(3);
                timer1.Start();
                timer2.Start();
            }
            else if (tabControl1.Controls[1] == tabControl1.SelectedTab)
            {
                retirar(1000);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult preguntasalir = MessageBox.Show("¿Está seguro de que desea salir?", "", MessageBoxButtons.YesNo);
            if (preguntasalir == DialogResult.Yes)
            {
                this.Hide();
                frm1.ShowDialog();
                this.Close();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.Controls[0] == tabControl1.SelectedTab)
            {
                tabControl1.SelectTab(1);
                validar();
            }
            else if(tabControl1.Controls[1] == tabControl1.SelectedTab)
            {
                retirar(200);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (tabControl1.Controls[1] == tabControl1.SelectedTab)
            {
                tabControl1.SelectTab(2);
                validar();

            }
            else if(tabControl1.Controls[0] == tabControl1.SelectedTab)
            {
                tabControl1.SelectTab(4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void retirar(int cantidad)
        {
            if (Properties.Settings.Default.aux == "1234")
            {
                if (cantidad <= Int32.Parse(Properties.Settings.Default.monto1))
                {
                    int z = Convert.ToInt32(Properties.Settings.Default.monto1) - cantidad;
                    Properties.Settings.Default.monto1 = Convert.ToString(z);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Retire su cualto");
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Posee Fondos Suficientes, Intente Otra Cantidad");
                }
            }
            else if (Properties.Settings.Default.aux == "123")
            {
                if (cantidad <= Int32.Parse(Properties.Settings.Default.monto))
                {
                    int z = Convert.ToInt32(Properties.Settings.Default.monto) - cantidad;
                    Properties.Settings.Default.monto = Convert.ToString(z);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Retire su cualto");
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Posee Fondos Suficientes, Intente Otra Cantidad");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            retirar(500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retirar(2000);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //if (txtOtra.Text == "")
            //{
            //    MessageBox.Show("Debe completar todos los campos para completar transacción");
            //    txtOtra.Focus();
            //}
            if (tabControl1.Controls[2] == tabControl1.SelectedTab)
            {
                retirar(Int32.Parse(txtOtra.Text));
            }else if(tabControl1.Controls[4] == tabControl1.SelectedTab)
            {
                if (Properties.Settings.Default.aux == txtnumcuentadesti_trans.Text)
                {
                    MessageBox.Show("No puede autotransferirse");
                    txtnumcuentadesti_trans.Text = "";
                    txtcantidad_trans.Text = "";
                }

                else if (txtnumcuentadesti_trans.Text == "123")
                {
                    int z = Convert.ToInt32(Properties.Settings.Default.monto) + Convert.ToInt32(txtcantidad_trans.Text);
                    Properties.Settings.Default.monto = Convert.ToString(z);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Transferencia exitosa");
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                    
                }
                else if (txtnumcuentadesti_trans.Text == "1234")
                {
                    int z = Convert.ToInt32(Properties.Settings.Default.monto1) + Convert.ToInt32(txtcantidad_trans.Text);
                    Properties.Settings.Default.monto1 = Convert.ToString(z);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Transferencia exitosa");
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Número de cuenta invalido");
                    txtnumcuentadesti_trans.Text = "";
                    txtcantidad_trans.Text = "";
                    txtnumcuentadesti_trans.Focus();
                }
            }
        }

        int count = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                this.Hide();
                frm1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count--;
            lblconteo.Text = Convert.ToString(count);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            validar();
        }
        private void validar()
        {
            if (tabControl1.Controls[1] != tabControl1.SelectedTab)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}

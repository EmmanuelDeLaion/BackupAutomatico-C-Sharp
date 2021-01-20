using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ABCBackup.Clases;

namespace ABCBackup
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Registros_Load(object sender, EventArgs e)
        {
            tablaDatos.DataSource = sql.MostrarDatos();
        }

        private void Registros_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
      
        }


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text =="" || txtUsuario.Text == "" || txtCorreo.Text ==""|| txtContraseña.Text =="")
            {
                MessageBox.Show("Ingrese todos los datos correctamente");
            }
            else
            {
                txtId.Text = tablaDatos.Rows.Count.ToString();
                if (sql.Insertar(txtId.Text, txtNombre.Text, txtUsuario.Text, txtCorreo.Text, txtContraseña.Text))
                {
                    MessageBox.Show("Se Agregó correctamente");
                    tablaDatos.DataSource = sql.MostrarDatos();
                    vaciartxt();
                }
                else
                {
                    MessageBox.Show("No se han podido agregar correctamente");
                    vaciartxt();
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(txtId.Text, txtNombre.Text, txtUsuario.Text, txtCorreo.Text, txtContraseña.Text))
            {
                MessageBox.Show("Se Actualizó correctamente");
                tablaDatos.DataSource = sql.MostrarDatos();
                vaciartxt();
            }
            else
            {
                MessageBox.Show("No se han podido actualizar correctamente");
                vaciartxt();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(txtId.Text))
            {
                MessageBox.Show("Se Eliminó correctamente");
                tablaDatos.DataSource = sql.MostrarDatos();
                vaciartxt();
            }
            else
            {
                MessageBox.Show("No se han podido eliminar correctamente");
                vaciartxt();
            }

        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tablaDatos.DataSource = sql.Buscar(txtBuscar.Text);
            }
            else
            {
                tablaDatos.DataSource = sql.MostrarDatos() ;
            }
        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = tablaDatos.Rows[e.RowIndex];
            txtId.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtUsuario.Text = Convert.ToString(fila.Cells[2].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells[3].Value);
            txtContraseña.Text = Convert.ToString(fila.Cells[4].Value);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {

        }


        public void vaciartxt()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
        }
    }
}

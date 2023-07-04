using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//base de de datos access

namespace PRPERSONAL
{
    public partial class FRM_ELIMINACIÓN : Form
    {
        public FRM_ELIMINACIÓN()
        {
            InitializeComponent();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FRM_ELIMINACIÓN_Load(object sender, EventArgs e)
        {
            para_buscar();
        }
        private void para_buscar()
        {
            txtdireccion.Enabled = false;
            txtedad.Enabled = false;
            txtnom.Enabled = false;
            txtid.Enabled = true;
            BTNBUSCAR.Enabled = true;
            BTNSALIR.Enabled = true;
            txtid.Focus();
        }
        private void para_registrar()
        {
            txtdireccion.Enabled = true;
            txtedad.Enabled = true;
            txtnom.Enabled = true;
            txtid.Enabled = false;
            BTNBUSCAR.Enabled = false;
            BTNSALIR.Enabled = true;
        }
        private void limpiar()
        {

            txtedad.Clear();
            txtdireccion.Clear();
            txtid.Clear();
            txtnom.Clear();
            txtnom.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            para_registrar();
            if (BUSCAR_REGISTRO(txtid.Text) == true)
            {
                para_registrar();
                //si encuentra el registro
                DialogResult res=  MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO ACTUAL?", "ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(res==DialogResult.Yes)
                {
                    BR(txtid.Text);
                    MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ELIMINACIÓN DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    txtid.Focus();
                }
                else
                {
                    limpiar();
                    txtid.Focus();
                }
            }
            else
            {
                MessageBox.Show("EL REGISTRO NO EXISTE");
                txtid.Focus();

            }

        }
        private bool BUSCAR_REGISTRO(string codigo)
        {
            //convertir de cadena a numero
            int cod = Convert.ToInt32(codigo);
            //coneccion
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BDM\\dbm.accdb; Persist Security Info = false; ";

            //cadena sql
            string csql = "SELECT * FROM PERSONAL WHERE ID=" + cod;
            //adaptador
            OleDbDataAdapter adaptador = new OleDbDataAdapter(csql, conexion);
            //dataset
            DataSet ds = new DataSet();
            //llenar dataset
            conexion.Open();
            adaptador.Fill(ds);
            conexion.Close();
            //llenar registros
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;//NO SE ENCONTRO
            }
            else
            {
                //CARGA LOS DATOS A LOS TXTBOX
                txtnom.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                txtdireccion.Text = ds.Tables[0].Rows[0]["DIRECCIÓN"].ToString();
                txtedad.Text = ds.Tables[0].Rows[0]["EDAD"].ToString();
                ds.Dispose();
                return true;//EL REGISTRO EXISTE
            }
            //fin

        }
        //final de metodo buscar registro
        private bool BR(string codigo)
        {
            //transformar de cade3na a texto
            int cod = Convert.ToInt32(codigo);
            
            //conexion
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BDM\\dbm.accdb; Persist Security Info = false; ";

            //instruccion sql
            string csql = "DELETE FROM PERSONAL WHERE ID = " + cod;

            //crear comando
            OleDbCommand com = conexion.CreateCommand();
            com.CommandText = csql;

            //ejecutar consulta
            conexion.Open();
            com.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //metodo para cambiar el foco cuando el usuario presione enter
            if(e.KeyChar==(char)13)
            {
                e.Handled = true;
                BTNBUSCAR.Focus();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {

        }
    }
}

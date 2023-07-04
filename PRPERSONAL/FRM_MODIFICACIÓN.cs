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
    public partial class FRM_MODIFICACIÓN : Form
    {
        public FRM_MODIFICACIÓN()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //metodo para cambiar el foco cuando el usuario presione enter
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                txtdireccion.Focus();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //metodo para cambiar el foco cuando el usuario presione enter
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                txtedad.Focus();
            }
            else
            {
                e.Handled = false;
            }
            
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            if (br(txtid.Text) == true)
            {
                para_registrar();
            }
            else
            {
                MessageBox.Show("EL REGISTRO NO EXISTE");
                txtid.Focus();

            }
        }
        private bool br(string codigo)
        {
            //convertir de cadena a numero
            int codi = Convert.ToInt32(codigo);
            //coneccion
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BDM\\dbm.accdb; Persist Security Info = false; ";

            //cadena sql
            string csql = "SELECT * FROM PERSONAL WHERE ID = " + codi;
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

         //interfaces
        private void para_buscar()
        {
            txtdireccion.Enabled = false;
            txtedad.Enabled = false;
            txtnom.Enabled = false;
            BTNMODIFICAR.Enabled = false;
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
            BTNMODIFICAR.Enabled = true;
            txtid.Enabled = false;
            BTNBUSCAR.Enabled = false;
            BTNSALIR.Enabled = true;
            txtedad.Clear();
            txtdireccion.Clear();
            txtnom.Clear();
            txtnom.Focus();
        }
        //interfaces
        private bool MR(string cod, string nom, string dir, string edad)
        {
            //transformar de cade3na a texto
            int codi = Convert.ToInt32(cod);
            int ed = Convert.ToInt32(edad);
            //conexion
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BDM\\dbm.accdb; Persist Security Info = false; ";

            //instruccion sql
            string csql = " UPDATE PERSONAL SET ";
            csql = csql + " NOMBRE      = '" + nom + "',";
            csql = csql + " DIRECCIÓN   = '" + dir + "',";
            csql = csql + " EDAD        =  " + ed + " ";
            csql = csql + " WHERE ID =    " + codi;

            //crear comando
            OleDbCommand com = conexion.CreateCommand();
            com.CommandText = csql;

            //ejecutar consulta
            conexion.Open();
            com.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            //llenamos la funcion//
            MR(txtid.Text, txtnom.Text, txtdireccion.Text, txtedad.Text);
            //mensaje
            MessageBox.Show("DATOS MODIFICADOS CORRECTAMENTE", "MODIFICAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            para_buscar();
        }
    }
}

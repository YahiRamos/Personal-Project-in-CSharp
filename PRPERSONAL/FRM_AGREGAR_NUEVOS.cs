using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//base de de datos access}

namespace PRPERSONAL
{
    public partial class FRM_AGREGAR_NUEVOS : Form
    {
        public FRM_AGREGAR_NUEVOS()
        {
            InitializeComponent();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿DESEA SALIR?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void FRM_AGREGAR_NUEVOS_Load(object sender, EventArgs e)
        {
            //instrucciones
            para_buscar();
        }
        private void para_buscar()
        {
            txtdireccion.Enabled = false;
            txtedad.Enabled = false;
            txtnom.Enabled = false;
            BTNGUARDAR.Enabled = false;
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
            BTNGUARDAR.Enabled = true;
            txtid.Enabled = false;
            BTNBUSCAR.Enabled = false;
            BTNSALIR.Enabled = true;
            txtedad.Clear();
            txtdireccion.Clear();
            txtnom.Clear();
            txtnom.Focus();

        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            
           if(br(txtid.Text)==false)
            {
                para_registrar();
            }
           else
            {
                MessageBox.Show("EL REGISTRO YA EXISTE");
                txtid.Focus();
                    
            }
            
        }
        //inicio de metodo buscar registro
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
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        { 
            //llenamos la funcion//
            AR(txtid.Text, txtnom.Text, txtdireccion.Text, txtedad.Text);
            //mensaje
            MessageBox.Show("DATOS AGREGADOS CORRECTAMENTE", "GUARDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            para_buscar();

        }
        private bool AR(string cod, string nom, string dir, string edad)
        {
            //transformar de cade3na a texto
            int codi = Convert.ToInt32(cod);
            int ed = Convert.ToInt32(edad);
            //conexion
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BDM\\dbm.accdb; Persist Security Info = false; ";

            //instruccion sql
            string csql = "INSERT INTO PERSONAL (ID, NOMBRE, DIRECCIÓN, EDAD) ";
            csql = csql + " VALUES (" + codi + ",";
            csql = csql + "        '" + nom + "',";
            csql = csql + "        '" + dir + "',";
            csql = csql + "         " + ed  +  ")";

            //crear comando
            OleDbCommand com = conexion.CreateCommand();
            com.CommandText = csql;

            //ejecutar consulta
            conexion.Open();
            com.ExecuteNonQuery();
            conexion.Close();

            return true;
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

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //metodo para cambiar el foco cuando el usuario presione enter
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                BTNGUARDAR.Focus();
            }
            else
            {
                e.Handled = false;
            }
            e.Handled = validadores.num(e.KeyChar);
        }
    }
}

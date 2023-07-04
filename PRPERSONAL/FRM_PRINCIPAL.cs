using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPERSONAL
{
    public partial class FRM_PRINCIPAL : Form
    {
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aGREGARNUEVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AGREGAR NUEVOS REGISTROS
            FRM_AGREGAR_NUEVOS FRM_AGREGAR = new FRM_AGREGAR_NUEVOS();
            FRM_AGREGAR.Show(this);

        }

        private void mODIFICACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODIFICACION DE REGISTROS
            FRM_MODIFICACIÓN FRM_MODI = new FRM_MODIFICACIÓN();
            FRM_MODI.Show(this);
        }

        private void eLIMINACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ELIMINACION DE REGISTROS
            FRM_ELIMINACIÓN FRM_ELIM = new FRM_ELIMINACIÓN();
            FRM_ELIM.Show(this);
        }

        private void iNFORMACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INFORMACION
            FRM_INFORMACIÓN FRM_INFO = new FRM_INFORMACIÓN();
            FRM_INFO.Show(this);
        }

        private void vIDEOOMUSICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIDEOS frmvideos = new VIDEOS();
            frmvideos.Show(this);
        }
    }
}

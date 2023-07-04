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
    public partial class FRM_INFORMACIÓN : Form
    {
        public FRM_INFORMACIÓN()
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
    }
}

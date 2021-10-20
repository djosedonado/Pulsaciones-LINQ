
using System;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPersona frmRegistroPersona = new FrmRegistroPersona();
            frmRegistroPersona.MdiParent = this;
            frmRegistroPersona.Show();
      
        }

        private void consutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPersona frmConsultaPersona= new FrmConsultaPersona();
            frmConsultaPersona.MdiParent = this;
            frmConsultaPersona.Show();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

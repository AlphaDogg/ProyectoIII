using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaData
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }


        private void finalizarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login LoginOut = new Login();
            LoginOut.Show();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Facturacion F = new Facturacion();
            F.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento M = new Mantenimiento();
            M.ShowDialog();
        }

        private void btnLogoutLogico_Click(object sender, EventArgs e)
        {
            this.Close();
            Login LoginOut = new Login();
            LoginOut.Show();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...");
        }

        private void abrirFormulario(Form f)
        {

            f.MdiParent = this;
            f.Icon = this.Icon;
            f.Show();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosDeUsuario DDU = new DatosDeUsuario();
            DDU.Show();
        }
    }
}

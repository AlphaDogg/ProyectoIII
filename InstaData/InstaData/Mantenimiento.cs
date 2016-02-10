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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form f)
        {
            
            f.MdiParent = this;
            f.Icon = this.Icon;
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new MantProducto());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new MantClientes());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new MantProveedores());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new MantUsuarios());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

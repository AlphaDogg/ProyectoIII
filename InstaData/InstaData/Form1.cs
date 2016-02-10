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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MS = new MainScreen();
            MS.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxPass.Clear();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxUsuario.Clear();
        }

        private void txtBoxUsuario_Leave(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this;
            userForm.Show();

        }

        private void ProductosToolStripButton2_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this; // abrir formulario de la pestana dentro del formulario principal
            productosForm.Show();
        }
    }
}

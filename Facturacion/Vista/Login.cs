using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un usuario");
                UsuarioTextBox.Focus();
                return;
            }

            if (ContrasenaTextBox.Text == "")
            {

                errorProvider1.SetError(ContrasenaTextBox, "Ingrese una contrasena");
                UsuarioTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            Menu menuFormulario = new Menu();
            Hide(); //Oculta formulario 
            menuFormulario.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ContrasenaTextBox.PasswordChar == '*')
            {
                ContrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContrasenaTextBox.PasswordChar = '*';
            }
        }
    }
}

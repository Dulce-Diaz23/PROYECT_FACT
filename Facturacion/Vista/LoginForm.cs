using Datos;
using Entidades;
using System;
using System.Windows.Forms;




namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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

            //Validar en BD

            Login login = new Login(UsuarioTextBox.Text, ContrasenaTextBox.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();


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

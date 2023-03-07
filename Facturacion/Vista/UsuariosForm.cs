using Datos;
using Entidades;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        string tipoOperacion;
        public UsuariosForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();   //recibe metodo devolver usuario
        UsuarioDB UsuarioDB = new UsuarioDB();     // ejecutar de varias partes

        private void NuevoButton_Click(object sender, System.EventArgs e)
        {
            CodigoTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";

        }

        private void CancelarButton_Click(object sender, System.EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }


        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            ContrasenaTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AdjuntarFotoButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;

        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            ContrasenaTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AdjuntarFotoButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;

        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            CorreoTextBox.Clear();
            ContrasenaTextBox.Clear();
            RolComboBox.Text = string.Empty;
            EstaActivoCheckBox.Checked = false;
            pictureBox1.Image = null;


        }

        private void GuardarButton_Click(object sender, System.EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
                    CodigoTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                    NombreTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ContrasenaTextBox.Text))
                {
                    errorProvider1.SetError(ContrasenaTextBox, "Ingrese un contrasena");
                    ContrasenaTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolComboBox.Text))
                {
                    errorProvider1.SetError(RolComboBox, "Ingrese un rol");
                    RolComboBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                Usuario user = new Usuario();

                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contrasena = ContrasenaTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.EstaActivo = EstaActivoCheckBox.Checked;

                if (pictureBox1.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // pasa la fotografia a MemorySream
                    user.Foto = ms.GetBuffer();
                }

                //Insertar en BD

                bool inserto = UsuarioDB.Insertar(user);
                if (inserto)
                {
                    MessageBox.Show("Registro guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }

            }
            else if (tipoOperacion == "Modificar")
            {

            }
        }

        private void ModificarButton_Click(object sender, System.EventArgs e)
        {
            tipoOperacion = "Modificar";  //identificar si es para modificar o nuevo
        }

        private void AdjuntarFotoButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void UsuariosForm_Load(object sender, System.EventArgs e)
        {
            TraerUsuario();

        }

        private void TraerUsuario()
        {
            dt = UsuarioDB.DevolverUsuarios();
            UsuarioDataGridView.DataSource = dt;
        }
    }

}

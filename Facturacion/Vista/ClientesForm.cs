using Datos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClientesForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;

        ClienteDB clienteDB = new ClienteDB();
        DataTable dt = new DataTable();


        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            IdentidadClienteTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }


        private void HabilitarControles()
        {
            IdentidadClienteTextBox.Enabled = true;
            NombreClienteTextBox.Enabled = true;
            TelefonoClienteTextBox.Enabled = true;
            CorreoClienteTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            FechaNacimientoTextBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;

        }

        private void DesabilitarControles()
        {
            IdentidadClienteTextBox.Enabled = false;
            NombreClienteTextBox.Enabled = false;
            TelefonoClienteTextBox.Enabled = false;
            CorreoClienteTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
            FechaNacimientoTextBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            IdentidadClienteTextBox.Clear();
            NombreClienteTextBox.Clear();
            TelefonoClienteTextBox.Clear();
            CorreoClienteTextBox.Clear();
            DireccionTextBox.Clear();
            FechaNacimientoTextBox.Clear();
            EstaActivoCheckBox.Checked = false;

        }

        private void GuardarButton_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (tipoOperacion == "Nuevo")
            {

                if (string.IsNullOrEmpty(IdentidadClienteTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadClienteTextBox, "Ingrese numero de identidad");
                    IdentidadClienteTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienteTextBox, "Ingrese un nombre");
                    NombreClienteTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();


                if (string.IsNullOrEmpty(TelefonoClienteTextBox.Text))
                {
                    errorProvider1.SetError(TelefonoClienteTextBox, "Ingrese un numero telefonico");
                    TelefonoClienteTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreoClienteTextBox.Text))
                {
                    errorProvider1.SetError(CorreoClienteTextBox, "Ingrese un correo");
                    CorreoClienteTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente.Identidad = IdentidadClienteTextBox.Text;
                cliente.Nombre = NombreClienteTextBox.Text;
                cliente.Telefono = TelefonoClienteTextBox.Text;
                cliente.Correo = CorreoClienteTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(FechaNacimientoTextBox.Text);
                cliente.EstaActivo = EstaActivoCheckBox.Checked;

                //Insertar en BD

                bool inserto = clienteDB.Insertar(cliente);

                if (inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerCliente();

                    MessageBox.Show("Registro guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }

            }
            else if (tipoOperacion == "Modificar")
            {
                cliente.Identidad = IdentidadClienteTextBox.Text;
                cliente.Nombre = NombreClienteTextBox.Text;
                cliente.Telefono = TelefonoClienteTextBox.Text;
                cliente.Correo = CorreoClienteTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(FechaNacimientoTextBox.Text);
                cliente.EstaActivo = EstaActivoCheckBox.Checked;

                bool modifico = clienteDB.Editar(cliente);
                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerCliente();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
            }
        }


        private void ModificarButton_Click_1(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                IdentidadClienteTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                NombreClienteTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonoClienteTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreoClienteTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DireccionTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                FechaNacimientoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                EstaActivoCheckBox.Text = ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value.ToString();

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }


        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerCliente();
        }

        private void TraerCliente()
        {
            dt = clienteDB.DevolverClientes();
            ClientesDataGridView.DataSource = dt;
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)       //Validar para que al querer modificar un usuario se seleccione un registro
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar registro?", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerCliente();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }

            }
        }


    }

}

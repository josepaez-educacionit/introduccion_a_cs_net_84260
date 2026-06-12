using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazGraficaWinForm
{
    // OPERACIONES CRUD ESENCIALES
    // CREATE: Nuevo() - Permite Nuevo nuevos registros a la base de datos.
    // READ: ActualizarVista() - Permite recuperar y mostrar datos almacenados en la base de datos.
    // UPDATE: Actualizar() - Permite modificar registros existentes en la base de datos.
    // DELETE: Eliminar() - Permite eliminar registros de la base de datos.

    public partial class CrudPersona : Form
    {
        public List<Persona> personas = new List<Persona>();
        private int proximoId = 1;
        private int idEnEdicion = 0;

        public CrudPersona()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha = dtpFecha.Value;
            string documento = txtDocumento.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            MessageBox.Show($"Nombre: {nombre}\nApellido: {apellido}\nFecha de Nacimiento: {fecha.ToShortDateString()}\nNúmero de Documento: {documento}\nDomicilio: {domicilio}\nTeléfono: {telefono}", "Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?",
                "Confirmar Cierre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        #region CRUD
        private void Agregar()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha = dtpFecha.Value;
            string documento = txtDocumento.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            Persona persona = new Persona
            {
                Id = proximoId++,
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fecha,
                NumeroDocumento = documento,
                Domicilio = domicilio,
                Telefono = telefono
            };
            personas.Add(persona);
        }

        private void Actualizar()
        {
            Persona personaAActualizar = personas.FirstOrDefault(p => p.Id == idEnEdicion);
            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = txtNombre.Text;
                personaAActualizar.Apellido = txtApellido.Text;
                personaAActualizar.FechaNacimiento = dtpFecha.Value;
                personaAActualizar.NumeroDocumento = txtDocumento.Text;
                personaAActualizar.Domicilio = txtDomicilio.Text;
                personaAActualizar.Telefono = txtTelefono.Text;
            }
        }

        private void Guardar()
        {

            if (idEnEdicion > 0) 
                { Actualizar(); } 
            else 
                { Agregar(); }

            ActualizarGrilla();
            Limpiar();
        }

        private void Nuevo()
        {
            idEnEdicion = 0;
            Limpiar();
            txtNombre.Focus();
        }

        private void Editar()
        {
            if (dgvPersonas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un registro para actualizar.", "No hay selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvPersonas.SelectedRows[0].Cells["ColId"].Value);
            idEnEdicion = idSeleccionado;

            Persona personaAActualizar = personas.FirstOrDefault(p => p.Id == idSeleccionado);
            if (personaAActualizar != null)
            {
                txtNombre.Text = personaAActualizar.Nombre;
                txtApellido.Text = personaAActualizar.Apellido;
                dtpFecha.Value = personaAActualizar.FechaNacimiento;
                txtDocumento.Text = personaAActualizar.NumeroDocumento;
                txtDomicilio.Text = personaAActualizar.Domicilio;
                txtTelefono.Text = personaAActualizar.Telefono;
            }

        }

        private void Eliminar()
        {
            if (dgvPersonas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.", "No hay selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idSeleccionado = Convert.ToInt32(dgvPersonas.SelectedRows[0].Cells["ColId"].Value);
                Persona personaAEliminar = personas.FirstOrDefault(p => p.Id == idSeleccionado);
                if (personaAEliminar != null)
                {
                    personas.Remove(personaAEliminar);
                    ActualizarGrilla();
                }
            }
        }

        private void ActualizarGrilla()
        {
            dgvPersonas.DataSource = "";
            dgvPersonas.DataSource = personas;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFecha.Value = DateTime.Now;
            txtDocumento.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
        }

        private void CargarDatosIniciales()
        {
            personas.Add(new Persona
            {
                Id = proximoId++,
                Nombre = "Juan",
                Apellido = "Pérez",
                FechaNacimiento = new DateTime(1990, 5, 15),
                NumeroDocumento = "12345678",
                Domicilio = "Calle Falsa 123",
                Telefono = "555-1234"
            });

            personas.Add(new Persona
            {
                Id = proximoId++,
                Nombre = "María",
                Apellido = "Gómez",
                FechaNacimiento = new DateTime(1985, 8, 20),
                NumeroDocumento = "87654321",
                Domicilio = "Avenida Siempre Viva 456",
                Telefono = "555-5678"
            });
        }

        #endregion

        private void CrudPersona_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            ConfigurarDataGridView();
            ActualizarGrilla();
        }

        private void ConfigurarDataGridView()
        {
            // Configuración base
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.MultiSelect = false;
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersVisible = false;

            // Definir columnas manualmente
            dgvPersonas.Columns.Clear();

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColId",
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColNombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 130
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColApellido",
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 130
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColFechaNacimiento",
                DataPropertyName = "FechaNacimiento",
                HeaderText = "Fecha Nac.",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColNumeroDocumento",
                DataPropertyName = "NumeroDocumento",
                HeaderText = "Documento",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColDomicilio",
                DataPropertyName = "Domicilio",
                HeaderText = "Domicilio",
                Width = 170
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColTelefono",
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}

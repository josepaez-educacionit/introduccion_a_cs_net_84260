using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazGraficaWinForm
{
    public partial class CrudPersona : Form
    {
        public List<Persona> personas = new List<Persona>();


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
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha = dtpFecha.Value;
            string documento = txtDocumento.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            Persona persona = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fecha,
                NumeroDocumento = documento,
                Domicilio = domicilio,
                Telefono = telefono
            };

            personas.Add(persona);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFecha.Value = DateTime.Now;
            txtDocumento.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
        }
    }
}

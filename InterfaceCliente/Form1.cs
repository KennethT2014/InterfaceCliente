using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapData;


namespace InterfaceCliente
{
    public partial class Form1 : Form
    {

         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PuntoMuerto();
        }

        public void PuntoMuerto()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtPais.Enabled = false;

            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEstado.Enabled = false;
            btnCancelar.Enabled = false;
            ckEstado.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtPais.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
            ckEstado.Enabled = true;

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PuntoMuerto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exame_2p.Controller;

namespace Exame_2p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ControllerPersona c = new ControllerPersona();
            dgvTabla.DataSource = null;
            dgvTabla.DataSource = c.ObtenerInfo();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControllerPersona c = new ControllerPersona();
            try
            {
                if ((txbNombre.Text != string.Empty) && (txbEdad.Text != string.Empty) && (txbCorreo.Text != string.Empty) && (txbFechaNacim.Text != null))
                {
                    if (c.InsertarPersona(txbNombre.Text,Convert.ToInt32(txbEdad.Text),txbCorreo.Text,Convert.ToDateTime(txbFechaNacim.Text)))
                    {
                        MessageBox.Show("Agregado con exito");
                        txbNombre.Text = string.Empty;
                        txbEdad.Text = string.Empty;
                        txbCorreo.Text = string.Empty;
                        txbFechaNacim.Text = string.Empty;
                    }
                    else
                        MessageBox.Show("Hubo un problema ");
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txbID.Text != string.Empty)
            {
                ControllerPersona c = new ControllerPersona();
                if (c.EliminarPersona(Convert.ToInt32(txbID.Text)))
                {
                    MessageBox.Show("Persona eliminada con exito!");
                }
                else
                {
                    MessageBox.Show("Id no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Ingrese matricula");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ControllerPersona persona = new ControllerPersona();
            try
            {
                if (txbID.Text != string.Empty)
                {
                    if (persona.ActualizarPersona(Convert.ToInt32(txbID.Text),txbNombre.Text, Convert.ToInt32(txbEdad.Text), txbCorreo.Text, Convert.ToDateTime(txbFechaNacim.Value)))
                        MessageBox.Show("Datos actualizados");
                    else
                        MessageBox.Show("Error en datos ingresados");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llene los campos correspondientes");
            }
        }
    }
}

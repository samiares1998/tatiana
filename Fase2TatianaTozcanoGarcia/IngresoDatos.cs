using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2TatianaTozcanoGarcia
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.Identificacion = txtIdentificacion.Text;
            estudiante.NombreCompleto = txtNombreCompleto.Text;

            if (rtbnMasculino.Checked)
            {
                estudiante.Genero = "Masculino";
            }
            else if (rtbnFemenino.Checked)
            {
                estudiante.Genero = "Femenino";
            }

            //Aqui vamos a tener la actividad seleccionada
            estudiante.Instrumento = cmbInstrumento.SelectedItem.ToString();

            // Aqui obtendremos el numero de clases tomadas
            estudiante.NumeroClases = Convert.ToInt32(txtNumeroClases.Text);

            //Aqui obtenemos el costo por calse que se muestra en el Textbox(se llea automaticamente)
            estudiante.CostoPorClase = Convert.ToInt32(txtCostoPorClase.Text);

            //Aqui obtenemos la fecha de registro
            estudiante.FechaRegistro = dtpFechaRegistro.Value;

            //Aqui mostrarems un mensaje de confirmacion
            MessageBox.Show("Registro guardado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas salir de la aplicacion?", "Confirmacion de la salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.NumeroClases = Convert.ToInt32(txtNumeroClases.Text);
            estudiante.CostoPorClase = Convert.ToInt32(txtCostoPorClase.Text);

            //Caclcular el costo total
            decimal costoTotal = estudiante.CalcularCostoTotal();

            //Crear una instancia al formulario de reporte
            Reporte reporteform = new Reporte();

            //Pasar los datos del estudiante al formulario de reporte
            reporteform.txtIdentificacion.Text = txtIdentificacion.Text;
            reporteform.txtNombreCompleto.Text = txtNombreCompleto.Text;

            if (rtbnMasculino.Checked)
            {
                reporteform.rtbnMasculino.Checked = true;
            }
            else if (rtbnFemenino.Checked)
            {
                reporteform.rtbnFemenino.Checked = true;
            }


            reporteform.cmbInstrumento.Text = cmbInstrumento.SelectedItem.ToString();
            reporteform.txtNumeroClases.Text = txtNumeroClases.Text;
            reporteform.txtCostoPorClase.Text = txtCostoPorClase.Text;
            reporteform.txtCostoTotal.Text = costoTotal.ToString();

            //Mostrar el formulario de reporte
            reporteform.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Crear una nueva instancia del formulario Ingresar Datos
            IngresoDatos ingresoform = new IngresoDatos();

            //Cerrar el formulario actual Reporte
            this.Close();

            //Mostrar de nuevo el formulario de ingreso de datos en blanco
            ingresoform.Show();
        }

        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInstrumento.SelectedItem.ToString())
            {
                case "Piano":
                    txtCostoPorClase.Text = "100000";
                    break;
                case "Guitarra":
                    txtCostoPorClase.Text = "80000";
                    break;
                case "Violín":
                    txtCostoPorClase.Text = "90000";
                    break;
                case "Batería":
                    txtCostoPorClase.Text = "85000";
                    break;
                case "Canto":
                    txtCostoPorClase.Text = "95000";
                    break;

                default:
                    txtCostoPorClase.Text = "0";
                    break;
            }
        }
    }
}

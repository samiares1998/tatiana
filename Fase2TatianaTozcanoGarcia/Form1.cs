using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2TatianaTozcanoGarcia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string contraseñaCorrecta = "123";

            if (txtInicio.Text == contraseñaCorrecta)
            {
                MessageBox.Show("Contraseña correcta, bienvenido.", "acceso concedido",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Aqui vamos a abrir el siguiente formulario
                IngresoDatos ingreso = new IngresoDatos();
                ingreso.Show();

                //Cerrar el formulario de inicio si es necesario
                this.Hide();
            }

            else
            {
                MessageBox.Show("Contraseña incorrecta, intentalo nuevamente.", "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Limpiar el campo de texto para que el usuario intente nuevamente
                txtInicio.Clear();
                txtInicio.Focus();
            }

        }
    }
}

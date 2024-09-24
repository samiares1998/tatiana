using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2TatianaTozcanoGarcia
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Prueba" + cmbInstrumento.SelectedItem.ToString());
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

// Form1.cs
using AplicacionMDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            VentanaHijo ventanaHijo = Application.OpenForms.OfType<VentanaHijo>().FirstOrDefault();

            if (ventanaHijo != null)
            {
                ventanaHijo.RecibirMensaje("Nuevo mensaje con la ventana ya abierta");
                ventanaHijo.BringToFront();
                ventanaHijo.Focus();
            }
            else
            {
                ventanaHijo = new VentanaHijo();
                ventanaHijo.MdiParent = this;
                ventanaHijo.Show();
                ventanaHijo.RecibirMensaje("Mensaje inicial");
            }
        }
    }
}

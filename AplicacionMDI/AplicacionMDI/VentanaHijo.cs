// VentanaHijo.cs
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
    public partial class VentanaHijo : Form
    {
        public VentanaHijo()
        {
            InitializeComponent();
        }

        public void RecibirMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }


        private void lblMensaje_Click_1(object sender, EventArgs e)
        {
            VentanaHijo ventanaHijo = Application.OpenForms.OfType<VentanaHijo>().FirstOrDefault();

            if (ventanaHijo != null)
            {
                // Si ya está abierta, simplemente le envías el nuevo mensaje
                ventanaHijo.BringToFront();
            }
            else
            {
                ventanaHijo = new VentanaHijo();
                ventanaHijo.MdiParent = this;
                ventanaHijo.Show();
            }
        }
    }
}

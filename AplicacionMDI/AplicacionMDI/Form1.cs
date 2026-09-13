// Form1.cs
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
            // 1. Busca si ya existe una instancia abierta de VentanaHijo
            VentanaHijo ventanaHijo = Application.OpenForms.OfType<VentanaHijo>().FirstOrDefault();

            if (ventanaHijo != null)
            {
                // 2. Si ya existe, tráela al frente y dale foco
                ventanaHijo.BringToFront();
                ventanaHijo.Focus();
            }
            else
            {
                // 3. Si no existe, crea una nueva, asigna el MdiParent y muéstrala
                ventanaHijo = new VentanaHijo();
                ventanaHijo.MdiParent = this;
                ventanaHijo.Show();
            }
        }
    }
}

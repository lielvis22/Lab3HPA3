using System;
using System.Collections;
using System.Windows.Forms;

namespace EjemploGrid
{
    public partial class Form1 : Form
    {
        //ArrayList para almacenar los objetos Persona
        //ArrayList esta en el espacio de nombres System.Collections

        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodriguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);

            listaPersonas.Add(miColaborador1);
            dgvdatos.DataSource = listaPersonas;
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(
                    txtNombres,
                    "Ingrese los nombres del Colaborador"
                );
                txtNombres.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(
                    txtApellidos,
                    "Ingrese los apellidos del Colaborador"
                );
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }

            if (Utilidades.EsCorreoValido(txtCorreo.Text) == false)
            {
                errorProvider1.SetError(
                    txtCorreo,
                    "Ingrese un correo válido"
                );
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            decimal salario1;

            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(
                    txtSalario,
                    "Ingrese un salario válido"
                );
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona colaborador1 = new Persona();

            colaborador1.Id = int.Parse(txtID.Text);
            colaborador1.Nombres = txtNombres.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Correo = txtCorreo.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value;

            listaPersonas.Add(colaborador1);

            dgvdatos.DataSource = null; // Limpiar el DataSource antes de asignar la nueva lista
            dgvdatos.DataSource = listaPersonas;
        }
    }
}
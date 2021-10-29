using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace PresentacionGUI
{

    public partial class FrmConsultaPersona : Form
    {
        private PersonaService personaService;
       

        public FrmConsultaPersona()
        {
            InitializeComponent();
            personaService = new PersonaService();
            ConfiguraionInicalGrid();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            var filtro = cmbFiltro.Text;
            if (filtro.Equals(""))
            {
                MessageBox.Show("Escoja una Opción de Filtrado");
            }
            else
            {
              var respuesta = SeleccionDeConsulta(filtro);
               ValidarRespuestadeConsulta(respuesta);
            }
        }

        private ConsultaResponse SeleccionDeConsulta(string filtro)
        {
            if (filtro.Equals("Todos"))
            {
                return personaService.Consultar();
            }
            string sexo = MapearSexo(filtro);
            return personaService.ConsultarPorSexo(sexo);
        }

        private void ValidarRespuestadeConsulta(ConsultaResponse respuetsa)
        {
            if (respuetsa.Error)
            {
                MessageBox.Show(respuetsa.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarGrid(respuetsa.Personas);
            }
        }

       

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private string MapearSexo(string sexo)
        {
            if (sexo.Equals("Mujeres"))
            {
                return "F";
            }
            else
            {
                return "M";
            }
        }

        public void LlenarGrid(List<Persona> personas)
        {
            dgvPersonas.Rows.Clear();
          
                foreach (var item in personas)
                {
                    dgvPersonas.Rows.Add(item.Identificacion, item.Nombre, item.Edad, item.Sexo, item.Pulsacion);
                }
       
            dgvPersonas.Refresh();


        }

        private void ConfiguraionInicalGrid()
        {
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.Columns.Add("columNombre", "Identificacion");
            dgvPersonas.Columns.Add("columNombre", "Nombre");
            dgvPersonas.Columns.Add("columEdad", "Edad");
            dgvPersonas.Columns.Add("columSexo", "Sexo");
            dgvPersonas.Columns.Add("columPulsacion", "Pulsacion");

            dgvPersonas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvPersonas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPersonas.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvPersonas.Font, FontStyle.Bold);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            var respuesta = personaService.ConsultarPorPalabra(txtNombre.Text);
            ValidarRespuestadeConsulta(respuesta);
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_AW_Departamentos
{
    public partial class EliminarDepartamento : Form
    {
        // Objeto de tipo Departamentos que contiene la funcionalidad
        // para listar, insertar y eliminar
        Departamentos departamentos = new Departamentos();

        public EliminarDepartamento()
        {
            InitializeComponent();
        }

        private void btnCargarDepartamentos_Click(object sender, EventArgs e)
        {
            // Obtener una lista de todos los departamentos de la tabla
            List<Departamento> listaDepartamentos = departamentos.LeerTodos();

            // Limpiar el listView
            lstDepartamentos.Items.Clear();

            // Verificar si existen departamentos
            if (listaDepartamentos.Any())
                listaDepartamentos.ForEach(depto => lstDepartamentos.Items.Add(depto.name));
            else
                lstDepartamentos.Items.Add("¡Error al momento de cargar los departamentos!");

            btnEliminarDepartamento.Enabled = true;
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            // Objeto de tipo departamento
            Departamento elDepartamento = new Departamento();

            // Verificar que se seleccionó un elemento de la lista
            if (lstDepartamentos.SelectedIndex == -1)
                MessageBox.Show("Favor seleccionar un departamento de la lista antes de ejecutar la acción de eliminar", "Información");
            else
            {
                // Obtener el departamento seleccionado en el list view
                elDepartamento.name = lstDepartamentos.SelectedItem.ToString();

                if (departamentos.Eliminar(elDepartamento))
                {
                    lblEstadoEliminacion.Text = "¡Departamento eliminado satisfactoriamente!";
                    btnEliminarDepartamento.Enabled = false;
                }
                else
                    lblEstadoEliminacion.Text = "¡Ocurrió un error al momento de eliminar el departamento!";
            }
        }

        private void EliminarDepartamento_Load(object sender, EventArgs e)
        {
            btnEliminarDepartamento.Enabled = false;
        }
    }
}

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
    public partial class InsertarDepartamento : Form
    {
        public InsertarDepartamento()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Objeto con las funcionalidades de listar, insertar y eliminar
            Departamentos departamentos = new Departamentos();

            // Objeto con las propiedades de la tabla HumanResources.Department
            Departamento elDepartamento = new Departamento();

            // Obtener los valores del formulario
            // Nota: Siempre verificar que los valores requeridos sean ingresados
            elDepartamento.name = txtNombre.Text;
            elDepartamento.groupName = txtNombreGrupo.Text;
            elDepartamento.modifiedDate = dtpFechaCreacion.Value;

            // Insertar el registro en la tabla HumanResources.Department
            if (departamentos.Insertar(elDepartamento))
                lblEstadoInsercion.Text = "¡Nuevo departamento agregado satisfactoriamente!";
            else
                lblEstadoInsercion.Text = "¡Ocurrió un error al momento de insertar el departamento...";
        }
    }
}

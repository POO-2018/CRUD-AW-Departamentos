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
    public partial class ListarDepartamentos : Form
    {
        public ListarDepartamentos()
        {
            InitializeComponent();
        }

        private void ListarDepartamentos_Load(object sender, EventArgs e)
        {
            // Objeto de tipo Departamentos
            Departamentos departamentos = new Departamentos();

            // Almacenar todos los departamentos existentes
            List<Departamento> listaDepartamentos = departamentos.LeerTodos();

            // Si la lista contiene algún objeto
            if (listaDepartamentos.Any())
            {
                txtDepartamentos.AppendText("Id\t\t Nombre\t\t\t Nombre del grupo\n");

                // LINQ to Objects
                listaDepartamentos.ForEach(depto => txtDepartamentos.AppendText(depto.id.ToString() + "\t\t " + depto.name.ToString() + "\t\t\t " + depto.groupName.ToString() + "\n"));
            }
            else
            {
                txtDepartamentos.AppendText("Error al obtener los registros para los departamentos");
            }
        }
    }
}

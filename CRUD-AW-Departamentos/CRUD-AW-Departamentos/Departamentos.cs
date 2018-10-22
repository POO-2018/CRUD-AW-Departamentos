using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios para acceder
// a SQL Server
using System.Data;
using System.Data.SqlClient;

namespace CRUD_AW_Departamentos
{
    class Departamentos
    {
        // Variables miembro
        protected SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
            integrated security = true; database = AdventureWorks2014");
        protected string sql;

        // Constructor
        public Departamentos() { }

        /// <summary>
        /// Obtiene todos los registros existentes en la tabla
        /// HumanResources.Deparment
        /// </summary>
        /// <returns>List<Departamento></returns>
        public List<Departamento> LeerTodos()
        {
            // Lista una de tipo de Departamento
            List<Departamento> resultados = new List<Departamento>();

            sql = @"SELECT DepartmentID, Name, GroupName, ModifiedDate
                    FROM HumanResources.Department";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                // Ejecutar el query via un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorrer los elementos del Reader y almacenarlos
                // en la lista de tipo Departamento
                while (rdr.Read())
                {
                    Departamento departamento = new Departamento();
                    // Asignar los valores de Reader al objeto Departamento
                    departamento.id = rdr.GetInt16(0);
                    departamento.name = rdr.GetString(1);
                    departamento.groupName = rdr.GetString(2);
                    departamento.modifiedDate = rdr.GetDateTime(3);

                    // Agregar el Departamento a la List<Departamento>
                    resultados.Add(departamento);
                }

                return resultados;
            }
            catch (SqlException)
            {
                return resultados;
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}

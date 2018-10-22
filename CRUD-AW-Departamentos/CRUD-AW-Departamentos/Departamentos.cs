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

        public bool Insertar(Departamento departamento)
        {
            // Creación del query de inserción
            sql = @"INSERT INTO HumanResources.Department(Name, GroupName, ModifiedDate)
                    VALUES (@name, @groupName, @modifiedDate";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                using (cmd)
                {
                    // Cambiando los paránetros del query de inserción
                    // por los valores a insertar
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = departamento.name;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = departamento.groupName;
                    cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = departamento.modifiedDate;

                    cmd.ExecuteNonQuery();
                }

                // Como el query de inserción se ejecutó correctamente retornar true
                return true;
            }
            catch (SqlException)
            {
                Console.WriteLine("Error al momento de realizar la inserción");
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}

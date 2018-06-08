using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Producto
{
    public static class ProductoDAO
    {
        private static SqlConnection sqlConexion;
        private static SqlCommand sqlComando;

        static ProductoDAO()
        {
            sqlConexion = new SqlConnection(@"Data Source=LAB3PC11\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True");
            sqlComando = new SqlCommand();
            sqlComando.CommandType = System.Data.CommandType.Text;
            sqlComando.Connection = sqlConexion;
        }

        public static List<Producto> ObtenerProducto()
        {
            List<Producto> productos = null;
            bool todoOk = false;
            try
            {
                ProductoDAO.sqlComando.CommandText = "SELECT LocationId,Name FROM Production.Location";
                ProductoDAO.sqlConexion.Open();
                SqlDataReader sqlReader = ProductoDAO.sqlComando.ExecuteReader();

                while (sqlReader.Read())
                {
                    productos.Add(new Producto(int.Parse(sqlReader["LocationId"].ToString()), sqlReader["Name"].ToString()));
                }
                sqlReader.Close();

                todoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (todoOk)
                    ProductoDAO.sqlConexion.Close();
            }          

            return productos;
            
        }

        public static bool AgregarProducto(Producto p)
        {
            string sql = "INSERT INTO Production.Product (ProductId, Name) VALUES(";
            sql = sql + "'" + p.Id + "','" + p.Nombre + "')";

            return EjecutarNonQuery(sql);
        }

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                ProductoDAO.sqlComando.CommandText = sql;
                ProductoDAO.sqlConexion.Open();
                ProductoDAO.sqlComando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductoDAO.sqlConexion.Close();
            }
            return todoOk;
        }
    }
}

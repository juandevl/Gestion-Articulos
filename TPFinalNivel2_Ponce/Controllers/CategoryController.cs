using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ConnectionDB;

namespace Controllers
{
    public class CategoryController
    {
        public CategoryController() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Connection conn = new Connection();
            try
            {
                string query = "SELECT Id, Descripcion FROM CATEGORIAS";
                conn.SetQuery(query);
                conn.ReaderExecute();
                while (conn.Reader.Read())
                {
                    Category aux = new Category();
                    aux.Id = (int)conn.Reader["Id"];
                    aux.Description = (string)conn.Reader["Descripcion"];
                    categories.Add(aux);
                }

                return categories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }

        }

        public bool InsertNewCategory(string category_name)
        {
            if (string.IsNullOrWhiteSpace(category_name)) return false;
            Connection conn = new Connection();
            try
            {
                string query = "INSERT INTO CATEGORIAS (Descripcion) VALUES (@category_name)";
                conn.SetQuery(query);
                conn.SetParam("@category_name", category_name);

                //Valido si una fila fue modificada
                return conn.QueryExecute() == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}

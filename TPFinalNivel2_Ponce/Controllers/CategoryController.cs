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
                conn.setQuery(query);
                conn.readerExecute();
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
                conn.closeConnection();
            }

        }
    }
}

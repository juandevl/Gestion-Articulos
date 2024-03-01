using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ConnectionDB;

namespace Controllers
{
    public class BrandController
    {
        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            Connection conn = new Connection();
            try
            {
                string query = "SELECT Id, Descripcion FROM MARCAS";
                conn.setQuery(query);
                conn.readerExecute();
                while (conn.Reader.Read())
                {
                    Brand aux = new Brand();
                    aux.Id = (int)conn.Reader["Id"];
                    aux.Description = (string)conn.Reader["Descripcion"];

                    brands.Add(aux);
                }

                return brands;
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

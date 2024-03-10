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
        public BrandController() { }
        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            Connection conn = new Connection();
            try
            {
                string query = "SELECT Id, Descripcion FROM MARCAS";
                conn.SetQuery(query);
                conn.ReaderExecute();
                while (conn.Reader.Read())
                {
                    Brand aux = new Brand();
                    aux.Id = (int)conn.Reader["Id"];
                    aux.Description = (string)conn.Reader["Descripcion"];

                    brands.Add(aux);
                }

                return brands??null;
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

        public bool InsertNewBrand(string brand_name)
        {
            if (string.IsNullOrWhiteSpace(brand_name)) return false;

                Connection conn = new Connection();
            try
            {
                string query = "INSERT INTO MARCAS (Descripcion) VALUES (@brand_name)";
                conn.SetQuery(query);
                conn.SetParam("@brand_name", brand_name);

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

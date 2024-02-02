using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ConnectionDB;


namespace Controllers
{
    public class ArticleController
    {
        public List<Article> articleList()
        {
            List<Article> articles = new List<Article>();
            Connection conn = new Connection();
            try
            {
                //string query = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                string query = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca IdMarca, M.Descripcion Marca, A.IdCategoria IdCategoria, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                conn.readerExecute(query);

                while(conn.Reader.Read())
                {
                    Article art = new Article();
                    art.Id = (int)conn.Reader["Id"];
                    art.Code = (string)conn.Reader["Codigo"];
                    art.Price = (decimal)conn.Reader["Precio"];
                    art.Name = (string)conn.Reader["Nombre"];
                    art.Description = (string)conn.Reader["Descripcion"];
                    //Validamos si la url que esta cargada en la base de datos es null
                    if (!(conn.Reader["Imagen"] is DBNull))
                        art.ImageUrl = (string)conn.Reader["Imagen"];
                    art.BrandName.Id = (int)conn.Reader["IdMarca"];
                    art.BrandName.Description = (string)conn.Reader["Marca"];
                    art.Category.Id = (int)conn.Reader["IdCategoria"];
                    art.Category.Description = (string)conn.Reader["Categoria"];

                    articles.Add(art);
                }

                return articles;
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

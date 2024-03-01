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
        public ArticleController()
        {
        }
        //Get articles from table ARTICULOS
        public List<Article> GetArticles()
        {
            List<Article> articles = new List<Article>();
            Connection conn = new Connection();
            try
            {
                //string query = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                string query = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca IdMarca, M.Descripcion Marca, A.IdCategoria IdCategoria, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                conn.setQuery(query);
                conn.readerExecute();
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
                    else
                        art.ImageUrl = "imageDefault";

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


        //Metodo para obtener un articulo solo
        public Article GetArticle(Article name)
        {
            Article aux = null;

            return aux;
        }
    
        public bool insertArticle(Article art)
        {
            //Si el articulo no es null y Si no existe articulo, procedemos a ingresarlo en la base de datos
            if (art != null && !this.existsArticle(art))
            {
                Connection conn = new Connection();
                try
                {
                    //Descomentar esto para ejecutar una consulta de prueba
                    //conn.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES ('I12P', 'Iphone 12 Pro', 'Todavia sirve', 2, 1, 'imagen_iphone12pro', 800.00)");

                    //Comentar esto para no interferir
                    string query = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Code, @Name, @Description, @IdBrand, @IdCategory, @ImageUrl, @Price)";
                    conn.setQuery(query);
                    conn.setParam("@Code", art.Code);
                    conn.setParam("@Name", art.Name);
                    conn.setParam("@Description", art.Description);
                    conn.setParam("@IdBrand", art.BrandName.Id);
                    conn.setParam("@IdCategory", art.Category.Id);
                    conn.setParam("@ImageUrl", art.ImageUrl);
                    conn.setParam("@Price", art.Price);


                    //QueryExecute retorna la cantidad de filas afectadas en la consulta
                    //Si es igual a 1, significa que el articulo se ingreso correctamente
                    return conn.queryExecute() == 1;
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
            else
            {
                //Si ya existe el articulo o el argumento es null, retornamos false
                return false;
            }

            //Funcion en sql para comprobar si existe un argumento en una tabla de sqlserver
            /*
             IF EXISTS (SELECT 1 FROM MARCAS WHERE Descripcion = 'Motorola')
                PRINT 'Existe'
            ELSE
                PRINT 'No Existe'
            */
        }

        public bool existsArticle(Article art)
        {
            Connection conn = new Connection();
            try
            {
                string query = "SELECT Id FROM ARTICULOS WHERE Codigo = @Code";
                conn.setQuery(query);
                conn.setParam("@Code", art.Code);
                conn.readerExecute();

                return conn.Reader.HasRows;
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

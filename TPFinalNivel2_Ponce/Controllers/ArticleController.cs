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
                conn.SetQuery(query);
                conn.ReaderExecute();
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
                conn.CloseConnection();
            }

        }

        //Update article from table ARTICULOS
        public bool UpdateArticle(Article art)
        {
            if (art == null) return false;

            Connection con = new Connection();
            try
            {
                string query = "UPDATE ARTICULOS SET Codigo = @code, Nombre = @name, Descripcion = @description, IdMarca = @idbrand, IdCategoria = @idcategory, ImagenUrl = @urlimage, Precio = @price WHERE Id = @id";
                con.SetQuery(query);
                con.SetParam("@code", art.Code);
                con.SetParam("@name", art.Name);
                con.SetParam("@description", art.Description);
                con.SetParam("@idbrand", art.BrandName.Id);
                con.SetParam("@idcategory", art.Category.Id);
                con.SetParam("@urlimage", art.ImageUrl);
                con.SetParam("@price", art.Price);
                con.SetParam("@id", art.Id);

                //queryExecute retorna la cantidad de filas afectadas en la consulta
                return con.QueryExecute() == 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }

        }

        public bool DeleteArticle(int id)
        {
            if (id <= 0) return false;
            Connection conn = new Connection();
            try
            {
                string query = "DELETE FROM ARTICULOS WHERE Id = @id";
                conn.SetQuery(query);
                conn.SetParam("@id", id);
                
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
        public bool InsertArticle(Article art)
        {
            //Si el articulo no es null y Si no existe articulo, procedemos a ingresarlo en la base de datos
            if (art == null || this.ExistsArticle(art)) return false;
            
            Connection conn = new Connection();
            try
            {
                //Descomentar esto para ejecutar una consulta de prueba
                //conn.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES ('I12P', 'Iphone 12 Pro', 'Todavia sirve', 2, 1, 'imagen_iphone12pro', 800.00)");

                //Comentar esto para no interferir
                string query = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Code, @Name, @Description, @IdBrand, @IdCategory, @ImageUrl, @Price)";
                conn.SetQuery(query);
                conn.SetParam("@Code", art.Code);
                conn.SetParam("@Name", art.Name);
                conn.SetParam("@Description", art.Description);
                conn.SetParam("@IdBrand", art.BrandName.Id);
                conn.SetParam("@IdCategory", art.Category.Id);
                conn.SetParam("@ImageUrl", art.ImageUrl);
                conn.SetParam("@Price", art.Price);


                //QueryExecute retorna la cantidad de filas afectadas en la consulta
                //Si es igual a 1, significa que el articulo se ingreso correctamente
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
        
        public bool ExistsArticle(Article art)
        {
            Connection conn = new Connection();
            try
            {
                string query = "SELECT Id FROM ARTICULOS WHERE Codigo = @Code";
                conn.SetQuery(query);
                conn.SetParam("@Code", art.Code);
                conn.ReaderExecute();

                return conn.Reader.HasRows;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Helper
{
    public static class Helper
    {
        //----------------------------------------------
        //Metodos para obtener informacion de la base de datos
        public static List<Article> _GetArticles()
        {
            ArticleController control = new ArticleController();
            return control.GetArticles();
        }
        public static List<Brand> _GetBrands()
        {
            BrandController control = new BrandController();
            return control.GetBrands();
        }
        public static List<Category> _GetCategories()
        {
            CategoryController control = new CategoryController();
            return control.GetCategories();
        }


        //----------------------------------------------
        //Metodos para completar los ComboBox de Filtrado avanzado
        public static void FillDropDownCategories(List<Category> categories, ComboBox cboxCategories)
        {
            if (categories == null || categories.Count == 0) return;

            categories.Insert(0, new Category(0, "Todos"));
            cboxCategories.DataSource = categories;
            cboxCategories.ValueMember = "Id";
            cboxCategories.DisplayMember = "Description";

        }
        public static void FillDropDownBrands(List<Brand> brands, ComboBox cboxBrands)
        {
            if (brands == null || brands.Count == 0) return;

            brands.Insert(0, new Brand(0, "Todos"));
            cboxBrands.DataSource = brands;
            cboxBrands.ValueMember = "Id";
            cboxBrands.DisplayMember = "Description";
        }
        public static void FillDropDownFilterOrder(ComboBox cboxOrder)
        {
            string[] list = { "Por defecto", "Menor precio", "Mayor precio" };
            cboxOrder.DataSource = list;

        }

    }
}

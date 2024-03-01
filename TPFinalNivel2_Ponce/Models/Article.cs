using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Code { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Marca")]
        public Brand BrandName { get; set; }
        [DisplayName("Categoría")]
        public Category Category { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        [DisplayName("Precio")]
        public decimal Price { get; set; }
        public string ImageUrl {  get; set; }

        public Article()
        {
            this.Category = new Category();
            this.BrandName = new Brand();
        }

    }
}

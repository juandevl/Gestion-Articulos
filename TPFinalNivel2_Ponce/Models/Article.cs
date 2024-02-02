using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand BrandName { get; set; }
        public Category Category { get; set; }
        public string ImageUrl {  get; set; }
        public double Price { get; set; }

    }
}

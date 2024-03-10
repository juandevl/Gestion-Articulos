using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Category() { }
        public Category(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
        
    }
}

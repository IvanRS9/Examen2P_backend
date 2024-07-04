using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2P.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Gama { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

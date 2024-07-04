using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2P.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Components { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }
    }
}

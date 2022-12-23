using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Range(0, 10000000)]
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Category { get; set; }
        [Range(0, 10)]
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}

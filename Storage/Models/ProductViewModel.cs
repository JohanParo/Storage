using System.Reflection.Metadata.Ecma335;
using Microsoft.Build.Evaluation;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}

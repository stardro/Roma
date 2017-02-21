using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public class WarehouseTovar : IdShopEntity
    {
        [Required]
        public virtual Tovar Tovar { get; set; } 
        [Required]
        public int Count { get; set; }
    }
}
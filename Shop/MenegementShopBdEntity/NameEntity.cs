using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public abstract class NameEntity : IdShopEntity
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
    }
}
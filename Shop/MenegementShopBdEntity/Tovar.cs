using System.ComponentModel.DataAnnotations;
using MenegementShopBdEntity.Enums;

namespace MenegementShopBdEntity
{
    public class Tovar : NameEntity
    {
        [Required]
       public virtual TovarSize Size { get; set; }
        [Required]
        public virtual TovarType Type { get; set; }
    }
}
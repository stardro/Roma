using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public class Seller : NameEntity
    {
        [Required]
        [MaxLength(13)]
        public string Cod { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public virtual ICollection<Phone> Phones { get; set; }
        [Required]
        public virtual ICollection<Document> Dorument { get; set; }
    }
}
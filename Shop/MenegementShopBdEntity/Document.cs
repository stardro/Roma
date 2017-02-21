using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public class Document : NameEntity
    {
        [Required]
        [MaxLength(10)]
        public string Date { get; set; }
        [Required, MaxLength(5)]
        public string NabmerDoc { get; set; }
        [Required]
        [MaxLength(13)]
        public string Cod { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Phone> Phones { get; set; }

        [Required, MaxLength(20)]
        public string Foods { get; set; }
        [Required, MaxLength(5)]
        public int Quantity { get; set; }
        [Required, MaxLength(5)]
        public int Price { get; set; }
        [Required, MaxLength(10)]
        public int Sun { get; set; }
        [Required, MaxLength(10)]
        public int TotalSum { get; set; }
        
         
    }
}
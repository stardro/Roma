using System.ComponentModel.DataAnnotations;
using MenegementShopBdEntity.Enums;

namespace MenegementShopBdEntity
{
    public class User : NameEntity
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Login { get; set; }
        [Required]
        [MinLength(5), MaxLength(20)]
        public string Password { get; set; }
        [Required]
        public Workman Work { get; set; }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public class Order : IdShopEntity
    {
        [Required, MaxLength(20)]
        public string Number { get; set; }
        [Required]
        public virtual ICollection<WarehouseTovar> OrderTovar { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public virtual Clients Clients { get; set; }
        [Required]
        public  virtual Seller Seller { get; set; }
        [Required]
        public DateTime GreateDate { get; set; }
        [Required]
        public virtual User Author { get; set; }
    }
}
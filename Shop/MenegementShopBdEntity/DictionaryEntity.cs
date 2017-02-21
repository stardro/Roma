﻿using System.ComponentModel.DataAnnotations;

namespace MenegementShopBdEntity
{
    public abstract class DictionaryEntity : NameEntity
    {
        [Required]
        public int Code { get; set; }
       [MaxLength(1000)]

       public string Description { get; set; }
    }
}
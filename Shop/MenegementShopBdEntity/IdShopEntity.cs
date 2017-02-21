using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenegementShopBdEntity
{
    public abstract class IdShopEntity
    {
        [Key]
        public Guid Id { get; protected set; }

        protected IdShopEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}

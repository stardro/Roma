using System.Collections;
using System.Collections.Generic;

namespace MenegementShopBdEntity
{
    public class Warehouse : IdShopEntity
    {
         public virtual ICollection<WarehouseTovar> Tovar { get; set; }
    }
}
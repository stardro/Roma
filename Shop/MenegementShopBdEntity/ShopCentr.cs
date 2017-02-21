using MenegementShopBdEntity;

namespace MenegementShopBdEntity
{
    ///ShopCentr where we can by tovars 
    public class ShopCentr : NameEntity
    {
        public virtual Warehouse Warehouse { get; set; }

    }
}
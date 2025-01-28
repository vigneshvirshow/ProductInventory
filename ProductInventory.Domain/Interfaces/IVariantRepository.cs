using ProductInventory.Domain.Entities;

namespace ProductInventory.Domain.Interfaces
{
    public interface IVariantRepository
    {
        IEnumerable<Variant> GetVariants();
        public bool CreateVariant(Variant variant);
        public bool UpdateVariant(Variant variant);
        public bool DeleteVariant(Guid id);
    }
}

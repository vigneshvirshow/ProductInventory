using ProductInventory.Domain.Entities;

namespace ProductInventory.Domain.Interfaces
{
    public interface ISubVariantRepository
    {
        IEnumerable<SubVariant> GetSubVariant();
        public bool CreateSubVariant(string name);
        public bool UpdateSubVariant(SubVariant subVariant);
        public bool DeleteSubVariant(Guid id);
    }
}

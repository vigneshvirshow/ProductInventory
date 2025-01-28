using ProductInventory.Infrastructure.Dto;

namespace ProductInventory.Application.Interfaces
{
    public interface ISubVariantService
    {
        public IEnumerable<SubVariantDto> GetSubVariants();
        public bool AddSubVariant(string name);
        public bool UpdateSubVariant(SubVariantDto variant);
        public bool DeleteSubVariant(Guid id);
    }
}
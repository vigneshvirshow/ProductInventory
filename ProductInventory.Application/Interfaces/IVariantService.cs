using ProductInventory.Infrastructure.Dto;

namespace ProductInventory.Application.Interfaces
{
    public interface IVariantService
    {
        public IEnumerable<VariantDto> GetVariants();
        public bool AddVariant(VariantDto variant);
        public bool UpdateVariant(VariantDto variant);
        public bool DeleteVariant(Guid id);
    }
}

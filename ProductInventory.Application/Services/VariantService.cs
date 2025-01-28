using ProductInventory.Application.Dto;
using ProductInventory.Application.Interfaces;
using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Application.Services
{
    public class VariantService(IVariantRepository variantRepository) : IVariantService
    {
        public bool AddVariant(VariantDto variant)
        {
            return variantRepository.CreateVariant(variant);
        }

        public bool DeleteVariant(Guid id)
        {
            return variantRepository.DeleteVariant(id);
        }

        public IEnumerable<VariantDto> GetVariants()
        {
            return MapVariant(variantRepository.GetVariants());
        }


        public bool UpdateVariant(VariantDto variant)
        {
            return variantRepository.UpdateVariant(variant);
        }

        #region PRIVATE METHODS

        private IEnumerable<VariantDto> MapVariant(IEnumerable<Variant> variants)
        {
            var variantList = new List<VariantDto>();

            if (variants is not null && variants.Any())
            {
                foreach (var variant in variants)
                {
                    variantList.Add(new VariantDto()
                    {
                        Id = variant.Id,
                        Name = variant.Name,
                    });
                }
            }
            return variantList;
        }
        #endregion
    }
}

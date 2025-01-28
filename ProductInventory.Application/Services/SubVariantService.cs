using ProductInventory.Application.Dto;
using ProductInventory.Application.Interfaces;
using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Application.Services
{
    public class SubVariantService(ISubVariantRepository subVariantRepository) : ISubVariantService
    {
        public bool AddSubVariant(string name)
        {
            return subVariantRepository.CreateSubVariant(name);
        }

        public bool DeleteSubVariant(Guid id)
        {
            return subVariantRepository.DeleteSubVariant(id);
        }

        public IEnumerable<SubVariantDto> GetSubVariants()
        {
            return MapSubVariant(subVariantRepository.GetSubVariant());
        }

        public bool UpdateSubVariant(SubVariantDto subVariant)
        {
            return subVariantRepository.UpdateSubVariant(subVariant);
        }

        #region PRIVATE METHODS

        private IEnumerable<SubVariantDto> MapSubVariant(IEnumerable<SubVariant> subVariants)
        {
            var subVariantList = new List<SubVariantDto>();

            if (subVariants is not null && subVariants.Any())
            {
                foreach (var subVariant in subVariants)
                {
                    subVariantList.Add(new SubVariantDto()
                    {
                        Id = subVariant.Id,
                        Name = subVariant.Name,
                    });
                }
            }
            return subVariantList;
        }
        #endregion
    }
}
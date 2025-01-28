using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Domain.Repositories
{
    public class VariantRepository(ProductDbContext dbContext) : IVariantRepository
    {
        public bool CreateVariant(Variant variant)
        {
            dbContext.Variants.Add(variant);
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteVariant(Guid id)
        {
            var itemToDelete = dbContext.Variants.FirstOrDefault(x => x.Id == id);

            if (itemToDelete is null) throw new KeyNotFoundException($"Variant with id: {id} does not exist");

            dbContext.Variants.Remove(itemToDelete);
            return dbContext.SaveChanges() > 0;
        }

        public IEnumerable<Variant> GetVariants()
        {
            return dbContext.Variants;
        }

        public bool UpdateVariant(Variant variant)
        {
            dbContext.Variants.Update(variant);
            return dbContext.SaveChanges() > 0;
        }
    }
}

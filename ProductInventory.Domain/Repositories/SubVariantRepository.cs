using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Domain.Repositories
{
    public class SubVariantRepository(ProductDbContext dbContext) : ISubVariantRepository
    {
        public bool CreateSubVariant(string name)
        {

            dbContext.SubVariants.Add(new SubVariant { Name = name});
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteSubVariant(Guid id)
        {
            var itemToDelete = dbContext.SubVariants.FirstOrDefault(x => x.Id == id);

            if (itemToDelete is null) throw new KeyNotFoundException($"SubVariant with id: {id} does not exist");

            dbContext.SubVariants.Remove(itemToDelete);
            return dbContext.SaveChanges() > 0;
        }

        public IEnumerable<SubVariant> GetSubVariant()
        {
            return dbContext.SubVariants;
        }

        public bool UpdateSubVariant(SubVariant subVariant)
        {
            dbContext.SubVariants.Update(subVariant);
            return dbContext.SaveChanges() > 0;
        }
    }
}
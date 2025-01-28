using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Domain.Repositories
{
    public class ProductRepository (ProductDbContext dbContext) : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products;
        }

        public bool CreateProduct (Product product)
        {
            dbContext.Products.Add(product);
            return dbContext.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product product) 
        {
            dbContext.Products.Update(product);
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteProduct(Guid id)
        {
            var itemToDelete = dbContext.Products.FirstOrDefault(x => x.Id == id);

            if (itemToDelete is null) throw new KeyNotFoundException($"Product with id: {id} does not exist");

            dbContext.Products.Remove(itemToDelete);
            return dbContext.SaveChanges() > 0;
        }
    }
}

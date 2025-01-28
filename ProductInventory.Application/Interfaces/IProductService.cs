using ProductInventory.Infrastructure.Dto;

namespace ProductInventory.Application.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<ProductDto> GetProducts();
        public bool AddProduct(ProductDto product);
        public bool UpdateProduct(ProductDto product);
        public bool DeleteProduct(Guid id);
    }
}

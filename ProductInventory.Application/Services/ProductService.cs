using ProductInventory.Application.Dto;
using ProductInventory.Application.Interfaces;
using ProductInventory.Domain.Entities;
using ProductInventory.Domain.Interfaces;

namespace ProductInventory.Application.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public bool AddProduct(ProductDto product)
        {
            return productRepository.CreateProduct(product);
        }

        public bool DeleteProduct(Guid id)
        {
            return productRepository.DeleteProduct(id);
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            return MapProducts(productRepository.GetProducts());
        }

        public bool UpdateProduct(ProductDto product)
        {
            return productRepository.UpdateProduct(product);
        }


        #region PRIVATE METHODS
        private IEnumerable<ProductDto> MapProducts(IEnumerable<Product> products)
        {
            var productList = new List<ProductDto>();

            if (products is not null && products.Any())
            {
                foreach (var product in products)
                {
                    productList.Add(new ProductDto()
                    {
                        Active = product.Active,
                        CreatedDate = product.CreatedDate,
                        CreatedUser = product.CreatedUser,
                        HSNCode = product.HSNCode,
                        Id = product.Id,
                        IsFavourite = product.IsFavourite,
                        ProductCode = product.ProductCode,
                        ProductImage = product.ProductImage,
                        ProductName = product.ProductName,
                        TotalStock = product.TotalStock,
                        UpdatedDate = product.UpdatedDate,
                        User = product.User,
                        Variant = product.Variant,
                        VariantId = product.VariantId,
                    });
                }
            }
            return productList;
        }
        #endregion
    }
}

using MyAcademyECommerce.Services.Catalog.Dtos.ProductDtos;

namespace MyAcademyECommerce.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<ResultProductDto> GetProductByIdAsync(string id);

        Task CreateProductAsync(CreateProductDto createProductDto);

        Task DeleteProductAsync(string id);

        Task UpdateProductAsync(UpdateProductDto updateProductDto);
    }
}

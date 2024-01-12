using AutoMapper;
using MongoDB.Driver;
using MyAcademyECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAcademyECommerce.Services.Catalog.Models;
using MyAcademyECommerce.Services.Catalog.Settings;

namespace MyAcademyECommerce.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {

        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            _mapper = mapper;

            var client = new MongoClient();
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.Product);
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var newProduct = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(newProduct);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            var products = await _productCollection.AsQueryable().ToListAsync();

            return _mapper.Map<List<ResultProductDto>>(products);
        }

        public async Task<ResultProductDto> GetProductByIdAsync(string id)
        {
            var product = await _productCollection.Find(x => x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultProductDto>(product);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var updateProduct = _mapper.Map<Product>(updateProductDto);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDto.ProductId, updateProduct);
        }
    }
}

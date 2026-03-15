using tiendasApi.Dto;
using tiendasApi.Dto;

namespace tiendasApi.Interface
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoDto>> GetAllProductosAsync();

        Task<ProductoDto> GetProductoByIdAsync(int id);

        Task<ProductoDto> CreateProductoAsync(CreateProductoDto dto);

        Task<ProductoDto> UpdateProductoAsync(int id, UpdateProductoDto dto);

        Task<bool> DeleteProductoAsync(int id);
    }
}
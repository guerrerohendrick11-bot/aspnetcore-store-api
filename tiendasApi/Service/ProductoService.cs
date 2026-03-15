using Microsoft.EntityFrameworkCore;
using tiendasApi.Data;
using tiendasApi.Dto;
using tiendasApi.Entiti;
using tiendasApi.Interface;

namespace tiendasApi.Service
{
    public class ProductoService : IProductoService
    {
        private readonly TiendaDbContext _context;

        public ProductoService(TiendaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductoDto>> GetAllProductosAsync()
        {
            var productos = await _context.Productos.ToListAsync();

            return productos.Select(p => new ProductoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                Stock = p.Stock
            });
        }

        public async Task<ProductoDto> GetProductoByIdAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return null;

            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock
            };
        }

        public async Task<ProductoDto> CreateProductoAsync(CreateProductoDto dto)
        {
            var producto = new Productos
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock
            };
        }

        public async Task<ProductoDto> UpdateProductoAsync(int id, UpdateProductoDto dto)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return null;

            producto.Nombre = dto.Nombre;
            producto.Precio = dto.Precio;
            producto.Stock = dto.Stock;

            await _context.SaveChangesAsync();

            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock
            };
        }

        public async Task<bool> DeleteProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return false;

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
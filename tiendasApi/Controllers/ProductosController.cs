using Microsoft.AspNetCore.Mvc;
using tiendasApi.Dto;
using tiendasApi.Interface;

namespace tiendasApi.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetAllProductos()
        {
            var productos = await _productoService.GetAllProductosAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoDto>> GetProductoById(int id)
        {
            var producto = await _productoService.GetProductoByIdAsync(id);

            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult<ProductoDto>> CreateProducto(CreateProductoDto dto)
        {
            var producto = await _productoService.CreateProductoAsync(dto);

            return CreatedAtAction(
                nameof(GetProductoById),
                new { id = producto.Id },
                producto
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductoDto>> UpdateProducto(int id, UpdateProductoDto dto)
        {
            var producto = await _productoService.UpdateProductoAsync(id, dto);

            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var deleted = await _productoService.DeleteProductoAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
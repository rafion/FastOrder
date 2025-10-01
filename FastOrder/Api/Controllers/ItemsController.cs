using FastOrder.Api.Assemblers;
using FastOrder.Api.Models;
using FastOrder.Api.Models.Input;
using FastOrder.Domain.Models;
using FastOrder.Domain.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FastOrder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemModel>>> GetAll()
        {
            var products = await _itemService.GetAllAsync();
            return Ok(products.Select(e => e.ToModel() ));
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetById(int id)
        {
            var product = await _itemService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product.ToModel());
        }

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Item>> Create(ItemInput itemInput)
        {
            if (!ModelState.IsValid) // Validações do Product.cs (Required, Range, etc.)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createdItem = await _itemService.CreateAsync(itemInput.ToDomainObject());
                // Retorna 201 Created e o URI do novo recurso
                return CreatedAtAction(nameof(Create), new { id = createdItem.Id }, createdItem);
            }
            catch (ArgumentException ex)
            {
                // Captura a exceção da regra de negócio do Service
                return BadRequest(new { message = ex.Message });
            }
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ItemInput item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var success = await _itemService.UpdateAsync(item.ToDomainObject());

            if (!success)
            {
                return NotFound();
            }

            return NoContent(); // Retorna 204 No Content para um update bem-sucedido
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _itemService.DeleteAsync(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }

}

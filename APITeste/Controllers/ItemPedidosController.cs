using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APITeste.Data;
using APITeste.Models;

namespace APITeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidosController : ControllerBase
    {
        private readonly APIDbContext _context;

        public ItemPedidosController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemPedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPedido>>> GetItemPedido()
        {
            return await _context.ItemPedido.ToListAsync();
        }

        // GET: api/ItemPedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemPedido>> GetItemPedido(int id)
        {
            var itemPedido = await _context.ItemPedido.FindAsync(id);

            if (itemPedido == null)
            {
                return NotFound();
            }

            return itemPedido;
        }

        // PUT: api/ItemPedidos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemPedido(int id, ItemPedido itemPedido)
        {
            if (id != itemPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemPedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ItemPedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemPedido>> PostItemPedido(ItemPedido itemPedido)
        {
            _context.ItemPedido.Add(itemPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemPedido", new { id = itemPedido.Id }, itemPedido);
        }

        // DELETE: api/ItemPedidos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemPedido(int id)
        {
            var itemPedido = await _context.ItemPedido.FindAsync(id);
            if (itemPedido == null)
            {
                return NotFound();
            }

            _context.ItemPedido.Remove(itemPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemPedidoExists(int id)
        {
            return _context.ItemPedido.Any(e => e.Id == id);
        }
    }
}

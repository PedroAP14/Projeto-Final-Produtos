using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;
using ProjetoFinal.Model;
namespace ProjetoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase 
    {
        private readonly DataContext _context; 
        
        public ProdutosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
              List<Produto> produtos = await _context.TB_PRODUTOS.ToListAsync();
              return Ok(produtos);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PORTFOLOSITE.Data;
using PORTFOLOSITE.Mappers;



namespace PORTFOLOSITE.Controllers
{
    [Route("PORTFOLOSITE/Stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext   _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList()
                .Select(s => s.ToStockDto());

            return Ok(stocks);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById([FromRoute] int Id)
        {
            var stock = _context.Stocks.Find(Id);   

            if(stock == null)
            {
                return NotFound();
            }

            return Ok(stock.ToStockDto());
        }
    }
}
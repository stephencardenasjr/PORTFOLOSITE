using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PORTFOLOSITE.DTOs.Stock;
using PORTFOLOSITE.Models;

namespace PORTFOLOSITE.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchace = stockModel.Purchace,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap

            };
        }
    }
}
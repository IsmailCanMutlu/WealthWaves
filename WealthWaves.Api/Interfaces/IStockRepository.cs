using WealthWaves.Api.Dtos.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WealthWaves.Api.Helpers;
using WealthWaves.Api.Models;

namespace WealthWaves.Api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
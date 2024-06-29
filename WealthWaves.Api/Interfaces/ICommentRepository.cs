using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WealthWaves.Api.Models;

namespace WealthWaves.Api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        Task<Comment?> DeleteAsync(int id);
    }
}
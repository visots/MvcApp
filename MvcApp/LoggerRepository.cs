using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcApp.Models.DB;

namespace MvcApp
{
    public class LoggerRepository : ILoggerRepository
    {
        private readonly BlogContext _context;

        public LoggerRepository (BlogContext context)
        {
            _context = context;
        }
        
        public async Task WriteMessage(Request request)
        {
            request.Date=DateTime.Now;
            request.Id = Guid.NewGuid();

            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request);

            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetLog()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}

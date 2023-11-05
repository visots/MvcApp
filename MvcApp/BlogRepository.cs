using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcApp.Models.DB;

namespace MvcApp
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;
  
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }  
        public async Task AddUser(User user)
        {
            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
                await _context.Users.AddAsync(user);
            
            await _context.SaveChangesAsync();
        }
    }
}

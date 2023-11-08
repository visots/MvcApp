using System.Threading.Tasks;
using MvcApp.Models.DB;

namespace MvcApp
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}

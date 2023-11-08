using System.Threading.Tasks;
using MvcApp.Models.DB;

namespace MvcApp
{
    public interface ILoggerRepository
    {
        public Task WriteMessage(Request request);

        public Task<Request[]> GetLog();

    }
}

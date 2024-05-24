using System.Collections.Generic;
using System.Threading.Tasks;
using Thebigbash.Models;

namespace Thebigbash.Data
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetAllBlogs();
    }
}

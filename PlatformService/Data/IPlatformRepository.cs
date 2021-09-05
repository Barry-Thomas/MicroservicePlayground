using System.Collections.Generic;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepository
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAll();
        Platform GetById(int id);
        Task Create(Platform platform);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepository
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Platform> GetAll()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public async Task Create(Platform platform)
        {
            if (platform == null) throw new ArgumentNullException(nameof(platform));

            await _context.Platforms.AddAsync(platform);
        }
    }
}
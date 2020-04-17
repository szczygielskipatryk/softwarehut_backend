using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoronaWirusMonitor3.Models;
using KoronaWirusMonitor3.Repository;
using Microsoft.EntityFrameworkCore;

namespace KWMonitor.Services
{
    public class RegionService
    {

        private readonly KWMContext _context;

        public RegionService(KWMContext context)
        {
            _context = context;
        }

        public async Task<bool> PutRegion(int id,Region region)
        {
            _context.Entry(region).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    }
}


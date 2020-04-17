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
    public class DistrictService
    {

        private readonly KWMContext _context;

            public DistrictService(KWMContext context)
            {
                _context = context;
            }

            public async Task<bool> PutDistrict(int id, District district)
            {
                _context.Entry(district).State = EntityState.Modified;

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

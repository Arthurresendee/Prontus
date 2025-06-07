using Microsoft.EntityFrameworkCore;
using Prontus.Core.Entities;
using Prontus.Core.Interfaces;
using Prontus.Infrastructure.Data;
using System.Threading.Tasks;

namespace Prontus.Infrastructure.Repositories
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        public PlanoRepository(ProntusDbContext context) : base(context)
        {
        }

        public async Task<Plano?> GetPlanoComPacientesAsync(int id)
        {
            return await _dbSet
                .Include(p => p.PacientePlanos)
                    .ThenInclude(pp => pp.Paciente)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
} 
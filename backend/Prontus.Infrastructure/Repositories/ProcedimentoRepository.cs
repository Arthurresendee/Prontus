using Microsoft.EntityFrameworkCore;
using Prontus.Core.Entities;
using Prontus.Core.Interfaces;
using Prontus.Infrastructure.Data;
using System.Threading.Tasks;

namespace Prontus.Infrastructure.Repositories
{
    public class ProcedimentoRepository : Repository<Procedimento>, IProcedimentoRepository
    {
        public ProcedimentoRepository(ProntusDbContext context) : base(context)
        {
        }

        public async Task<Procedimento?> GetProcedimentoComPacientesAsync(int id)
        {
            return await _dbSet
                .Include(p => p.PacienteProcedimentos)
                    .ThenInclude(pp => pp.Paciente)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
} 
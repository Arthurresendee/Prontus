using Microsoft.EntityFrameworkCore;
using Prontus.Core.Entities;
using Prontus.Core.Interfaces;
using Prontus.Infrastructure.Data;
using System.Threading.Tasks;

namespace Prontus.Infrastructure.Repositories
{
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(ProntusDbContext context) : base(context)
        {
        }

        public async Task<Paciente?> GetPacienteComDentistaAsync(int id)
        {
            return await _dbSet
                .Include(p => p.Dentista)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Paciente?> GetPacienteComPlanosAsync(int id)
        {
            return await _dbSet
                .Include(p => p.PacientePlanos)
                    .ThenInclude(pp => pp.Plano)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Paciente?> GetPacienteComProcedimentosAsync(int id)
        {
            return await _dbSet
                .Include(p => p.PacienteProcedimentos)
                    .ThenInclude(pp => pp.Procedimento)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
} 
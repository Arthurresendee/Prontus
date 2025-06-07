using Microsoft.EntityFrameworkCore;
using Prontus.Core.Entities;
using Prontus.Core.Interfaces;
using Prontus.Infrastructure.Data;
using System.Threading.Tasks;

namespace Prontus.Infrastructure.Repositories
{
    public class DentistaRepository : Repository<Dentista>, IDentistaRepository
    {
        public DentistaRepository(ProntusDbContext context) : base(context)
        {
        }

        public async Task<Dentista?> GetDentistaComPacientesAsync(int id)
        {
            return await _dbSet
                .Include(d => d.Pacientes)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Dentista?> GetDentistaComEnderecoAsync(int id)
        {
            return await _dbSet
                .Include(d => d.Endereco)
                .FirstOrDefaultAsync(d => d.Id == id);
        }
    }
} 
using Prontus.Core.Entities;
using System.Threading.Tasks;

namespace Prontus.Core.Interfaces
{
    public interface IProcedimentoRepository : IRepository<Procedimento>
    {
        Task<Procedimento?> GetProcedimentoComPacientesAsync(int id);
    }
} 
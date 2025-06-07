using Prontus.Core.Entities;
using System.Threading.Tasks;

namespace Prontus.Core.Interfaces
{
    public interface IPlanoRepository : IRepository<Plano>
    {
        Task<Plano?> GetPlanoComPacientesAsync(int id);
    }
} 
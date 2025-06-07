using Prontus.Core.Entities;
using System.Threading.Tasks;

namespace Prontus.Core.Interfaces
{
    public interface IDentistaRepository : IRepository<Dentista>
    {
        Task<Dentista?> GetDentistaComPacientesAsync(int id);
        Task<Dentista?> GetDentistaComEnderecoAsync(int id);
    }
} 
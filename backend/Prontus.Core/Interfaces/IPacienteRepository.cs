using Prontus.Core.Entities;
using System.Threading.Tasks;

namespace Prontus.Core.Interfaces
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        Task<Paciente?> GetPacienteComDentistaAsync(int id);
        Task<Paciente?> GetPacienteComPlanosAsync(int id);
        Task<Paciente?> GetPacienteComProcedimentosAsync(int id);
    }
} 
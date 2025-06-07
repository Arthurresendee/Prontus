using System;
using System.Threading.Tasks;

namespace Prontus.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPacienteRepository Pacientes { get; }
        IDentistaRepository Dentistas { get; }
        IProcedimentoRepository Procedimentos { get; }
        IPlanoRepository Planos { get; }
        Task<int> CompleteAsync();
    }
} 
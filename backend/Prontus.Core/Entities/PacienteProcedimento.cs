namespace Prontus.Core.Entities
{
    public class PacienteProcedimento
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }
        public int IdProcedimento { get; set; }
        public Procedimento? Procedimento { get; set; }
        public DateTime? DataProcedimento { get; set; }
    }
} 
namespace Prontus.Core.Entities
{
    public class PacientePlano
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }
        public int IdPlano { get; set; }
        public Plano? Plano { get; set; }
    }
} 
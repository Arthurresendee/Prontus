using System.Collections.Generic;

namespace Prontus.Core.Entities
{
    public class Dentista
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cro { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Whatsapp { get; set; }
        public int? IdEndereco { get; set; }
        public Endereco? Endereco { get; set; }
        public ICollection<Paciente>? Pacientes { get; set; }
    }
} 
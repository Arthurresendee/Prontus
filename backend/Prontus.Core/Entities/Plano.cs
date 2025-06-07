using System.Collections.Generic;

namespace Prontus.Core.Entities
{
    public class Plano
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public ICollection<PacientePlano>? PacientePlanos { get; set; }
    }
} 
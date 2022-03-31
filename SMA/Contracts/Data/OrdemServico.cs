using SMA.Data;
using System;

namespace SMA.Contracts.Data
{
    public class OrdemServico
    { 
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int AparelhoId { get; set; }
        public Aparelho Aparelho { get; set; }
        public DateTime DataGarantia { get; set; } = DateTime.Today.AddDays(90);
    }
}

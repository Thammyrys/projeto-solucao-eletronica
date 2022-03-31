using System.Collections.Generic;

namespace SMA.Contracts.Data
{
    public class Atendente : Funcionario
    {
        public int Id { get; set; }
        public List<Orcamento> Orcamento { get; set; }
        public List<OrdemServico> OrdemServico { get; set; }
    }
}

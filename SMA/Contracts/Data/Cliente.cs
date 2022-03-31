using SMA.Data;
using System.Collections.Generic;

namespace SMA.Contracts.Data
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public int TelefoneCliente { get; set; }
        public int CepCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public List<Aparelho> Aparelhos { get; set; }
        public List<Orcamento> Orcamento { get; set; }
        public List<OrdemServico> OrdemServico { get; set; }
    }
}

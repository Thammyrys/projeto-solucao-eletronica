using SMA.Data;
using System.Collections.Generic;

namespace SMA.Contracts.Data
{
    public class Tecnico : Funcionario
    {
        public int Id { get; set; }
        public List<Aparelho> Aparelhos { get; set; }
    }
}

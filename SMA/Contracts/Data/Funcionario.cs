namespace SMA.Contracts.Data
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
    }
}

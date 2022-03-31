using System;

namespace SMA.Data
{
    public class Aparelho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroDeSerie { get; set; }
        public bool EstaNaGarantia { get; set; }
        public string DescricaoDoDefeito { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public DateTime DataDeSaida { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportacaoDeContratos.Classes
{
    public class Contratos
    {

        private Contratos()
        { }

        public Contratos(int id)
        {
            Id = id;
        }
        public Contratos(int id, string? nome, string? cPF, string? contrato, string? produto, string? vencimento, string? valor)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Contrato = contrato;
            Produto = produto;
            Vencimento = vencimento;
            Valor = valor;
        }

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? CPF { get; set; }
        public string? Contrato { get; set; }
        public string? Produto { get; set; }
        public string? Vencimento { get; set; }
        public string? Valor { get; set; }
    }
}

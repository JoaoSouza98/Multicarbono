using prjMultiCarbono.Entities.Enums;
using System;
using System.Collections.Generic;

namespace prjMultiCarbono.Entities
{
    public class Cliente : Entity
    {
        public long Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string InscricaoEstadual { get; set; }

        public double Saldo { get; set; }

        public SituacaoCliente Situcao { get; set; }

        public DateTime DataCadastro { get; set; }

        public List<Telefone> ListaTelefone { get; set; }

        public Contato Contato { get; set; }
        public int IdContato { get; set; }

        public List<EnderecoCliente> ListaEnderecoCliente { get; set; }
        public List<int> ListaIdEnderecoCliente { get; set; }

        //public MaisCarbono MaisCarbono { get; set; }
    }
}

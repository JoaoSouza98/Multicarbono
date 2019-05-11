using prjMultiCarbono.Entities.Enums;
using System;

namespace prjMultiCarbono.Entities
{
    class Funcionario : Entity, ILogavel
    {
        public long Cpf { get; set; }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public SituacaoFuncionario Situacao { get; set; }

        public string Nacionalidade { get; set; }

        public DateTime DtNascimento { get; set; }

        public string Cargo { get; set; }

        public DateTime DtCadastro { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public string Senha { get; set; }

        public Endereco Endereco { get; set; }
        public int IdEndereco { get; set; }

        bool ILogavel.Login(string login, string senha)
        {
            return true;
        }
    }
}

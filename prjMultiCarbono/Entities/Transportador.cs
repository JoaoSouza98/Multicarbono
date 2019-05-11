using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class Transportador : Entity
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int CodAntt { get; set; }
        public string InscricaoEstadual { get; set; }

        public Endereco Endereco { get; set; }
        public int IdEndereco { get; set; }
    }
}

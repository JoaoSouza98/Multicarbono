using prjMultiCarbono.Entities.Enums;

namespace prjMultiCarbono.Entities
{
    public class Endereco : Entity
    {
      public int Cep { get; set; }
      public string Logradouro { get; set; }
      public int Numero { get; set; } 
      public string Cidade { get; set; }
      public UF UF { get; set; }
      public string Pais { get; set; }
    }
}

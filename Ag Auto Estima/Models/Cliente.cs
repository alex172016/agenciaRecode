using System.ComponentModel.DataAnnotations;

namespace Ag_Auto_Estima.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int telefone { get; set; }
        public string rua { get; set; }
        public int cpf { get; set; }
        public int rg { get; set; }
        public DateTime data_nasc { get; set; }
        public string email { get; set; }
        public int cep { get; set; }
    }


}

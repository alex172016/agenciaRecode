using System.ComponentModel.DataAnnotations;

namespace Ag_Auto_Estima.Models
{
    public class Reserva
    {
        public string nome { get; set; }
        public string origem { get; set; }
        public string destino { get; set; }
        public string email { get; set; }
        [Key]
        public int id_reserva { get; set; }
        public int telefone { get; set; }
        public DateTime data_ida { get; set; }
        public DateTime data_volta { get; set; }
        public int cpf { get; set; }

    }
}

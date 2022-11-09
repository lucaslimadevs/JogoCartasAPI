using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("carta")]
    public class Carta
    {
        [Dapper.Contrib.Extensions.Key]
        public int seq_carta { get; set; }
        [Required(ErrorMessage = "descrição é obrigatória")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Jogo é obrigatório")]
        public int seq_fkjogo { get; set; }
        public string qualidadecarta { get; set; }
        public string efeitofacilitador { get; set; }
        public string categoria { get; set; }
        public string banlist { get; set; }
        public string tributos { get; set; }
        public string atributo { get; set; }
        public string caracteristica { get; set; }
        public string tipo { get; set; }
        public string extra { get; set; }
        public string velocidade { get; set; }
        public string item { get; set; }
        public string armadilha { get; set; }

        [Dapper.Contrib.Extensions.Write(false)]
        public Jogo fkjogo { get; set; }
    }
}

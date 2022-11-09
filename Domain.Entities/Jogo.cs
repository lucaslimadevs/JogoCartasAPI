using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Dapper.Contrib.Extensions.Table("jogo")]
    public class Jogo
    {
        [Dapper.Contrib.Extensions.Key]
        public int seq_jogo { get; set; }
        [Required(ErrorMessage = "descrição é obrigatória")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Tipo de jogo é obrigatório")]
        public int seq_fktipojogo { get; set; }

        [Dapper.Contrib.Extensions.Write(false)]
        public TipoJogo fktipojogo { get; set; }
    }
}

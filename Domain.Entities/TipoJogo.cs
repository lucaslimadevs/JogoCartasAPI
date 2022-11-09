using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("tipojogo")]
    public class TipoJogo
    {
        [Dapper.Contrib.Extensions.Key]
        public int seq_tipojogo { get; set; }
        [Required(ErrorMessage = "descrição é obrigatória")]
        public string descricao { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MInhaViagem.Models
{
    public class Produto
    {
        [Key]

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
        public string NomeDaImagem { get; set; }
    }
}

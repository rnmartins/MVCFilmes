using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }

        [
            Display(Name = "Título do Filme"),
            Required(ErrorMessage = "Este campo é obrigatório"),
            MaxLength(100)
        ]
        public string Titulo { get; set; } = string.Empty;

        [
            Display(Name = "Data de Lançamento"),
            DataType(DataType.Date),
            Required(ErrorMessage = "Este campo é obrigatório")
        ]
        public DateTime DataLancamento { get; set; }

        [
            Display(Name = "Gênero"),
            Required(ErrorMessage = "Este campo é obrigatório"),
            StringLength(15),
            RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Somente letras")
        ]
        public string Genero { get; set; } = string.Empty;

        [
            Display(Name = "Preço"),
            Column(TypeName = "decimal(18, 2)"),
            Required(ErrorMessage = "Este campo é obrigatório"),
            DataType(DataType.Currency)
        ]
        public decimal Preco { get; set; }

        [Range(0,5, ErrorMessage = "Pontos de 0 - 5")]
        public int ? Pontos { get; set; }
    }
}

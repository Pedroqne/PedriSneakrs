using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PedrISnekears.Models
{
	[Table("Marcas")]
	public class Marca
	{
		[Key]
		public int MarcaId { get; set; }
		[Required(ErrorMessage = "Insira o nome da marca")]
		[Display(Name = "Nome da marca")]
		[StringLength(50,ErrorMessage = "O nome da marca deve ter no máximo 50 caracteres")]
        public string MarcaNome { get; set; }
		[Required(ErrorMessage = "Insira uma descrição para marca")]
		[Display(Name = "Descrição da marca")]
		[StringLength(100,MinimumLength = 30,ErrorMessage = "A descrição deve conter no minimo 30 caracteres e no máximo 100")]
        public string Descricao { get; set; }

		public List<Sneaker> Sneakers{ get; set; }
    }
}

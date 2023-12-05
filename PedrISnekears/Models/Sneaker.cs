namespace PedrISnekears.Models
{
	public class Sneaker
	{
        public int SneakerId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public string ImgUrl { get; set; }  
        public string ImgThumbnailUrl { get; set;}
        public bool IsDestaque { get; set; }
        public bool EmEstoque { get; set; }
    }
}

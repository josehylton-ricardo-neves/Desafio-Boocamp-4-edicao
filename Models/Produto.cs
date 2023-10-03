namespace Produto.Models
{
    public class Produto
    {


    public Produto(string nome)
    {
        Id = contadorIds++;
        Nome = nome;
    }

        private static int contadorIds = 1;

        public int Id { get; set; }
        public string? Nome { get; set; }
        
    }
}
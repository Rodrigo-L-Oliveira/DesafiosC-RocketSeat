namespace bookStoreAPI.Models
{
    public class Book
    {
        // Template de dados do livro
        public int Id { get; set; } // Id único
        public string Title { get; set; } // Titulo
        public string Author { get; set; } // Autor
        public string Genre { get; set; } // Gênero
        public decimal Price { get; set; } // Preço
        public int Stock { get; set; } // Quantidade em estoque
    }
}

namespace InheritanceTask.Models;

public class Library
{
    private readonly List<Book> _books = new List<Book>();
    
    public void AddBook(Book book)
    {
        _books.Add(book);
    }
    
    public void PrintBooks()
    {
        Console.WriteLine("Books in the library:");
       _books.ForEach(book => Console.WriteLine($"Name: {book.Name}, Genre: {book.Genre}"));
    }

    public void PrintFilteredBooksByGenre(string genre)
    {
        // var filteredBooks = _books.Where(book=> book.Genre.ToLower() == genre.ToLower()).ToList();
        var filteredBooks = _books.Where(book => book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        
        Console.WriteLine("Filtered Books by Genre in the library:");
       filteredBooks.ForEach(book => Console.WriteLine($"Name: {book.Name}, Genre: {book.Genre}"));
    }

    public void PrintFilteredBooksByPrice(int minPrice, int maxPrice)
    {
        var filteredBooks = _books.Where(book => book.Price >= minPrice && book.Price <= maxPrice).ToList();
        
        Console.WriteLine("Filtered Books by Genre in the library:");
        filteredBooks.ForEach(book => Console.WriteLine($"Name: {book.Name}, Genre: {book.Genre}"));
    }
}
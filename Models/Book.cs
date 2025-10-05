namespace ProfileManager.Models
{
    public class Book
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public string Author { get; set; }
       public string Genre { get; set; }
       public int YearPublished { get; set; }
       public string ISBN { get; set; }

       public static List<Book> books = new List<Book>
         {
              new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", YearPublished = 1925, ISBN = "9780743273565" },
              new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", YearPublished = 1960, ISBN = "9780061120084" },
              new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", YearPublished = 1949, ISBN = "9780451524935" }
         };

    }
}

using InheritanceTask.Models;

           var book1 = new Book { Name = "The War", Genre = "Drama", Price = 100};
           var book2 = new Book { Name = "Aladdin", Genre = "Adventure", Price = 200 };
           var book3 = new Book { Name = "Romeo and Juliet", Genre = "Drama", Price = 300};

           var library = new Library();
           
           library.AddBook(book1);
           library.AddBook(book2);
           library.AddBook(book3);
           
           // library.PrintBooks();

           // library.PrintFilteredBooksByGenre("Drama");
           
           library.PrintFilteredBooksByPrice(190, 250);
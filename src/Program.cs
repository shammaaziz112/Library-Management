using library_management.src;

internal class Program
{
    private static void Main()
    {
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob", new DateTime(2023, 2, 1));
        var user3 = new User("Charlie", new DateTime(2023, 3, 1));
        var user4 = new User("David", new DateTime(2023, 4, 1));
        var user5 = new User("Eve", new DateTime(2024, 5, 1));
        var user6 = new User("Fiona", new DateTime(2024, 6, 1));
        var user7 = new User("George", new DateTime(2024, 7, 1));
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");
        var user10 = new User("Julia");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        var book19 = new Book("The Iliad", BooksTypes.TextBook);
        var book20 = new Book("Anna Karenina");

        var emailService = new EmailNotificationService();
        var smsService = new SMSNotificationService();

        var lib = new Library(emailService);
        // lib = new Library(smsService);

        Console.WriteLine("\n===Add Book/User===");
        lib.AddBook(book1);
        lib.AddBook(book2);
        lib.AddBook(book3);
        lib.AddBook(book4);
        lib.AddBook(book5);
        lib.AddBook(book6);
        lib.AddBook(book7);
        lib.AddBook(book8);
        lib.AddBook(book9);
        lib.AddBook(book10);
        lib.AddBook(book11);
        lib.AddBook(book12);
        lib.AddBook(book13);
        lib.AddBook(book14);
        lib.AddBook(book15);
        lib.AddBook(book16);
        lib.AddBook(book17);
        lib.AddBook(book18);
        lib.AddBook(book19);
        lib.AddBook(book20);

        lib.AddUser(user1);
        lib.AddUser(user2);
        lib.AddUser(user3);
        lib.AddUser(user4);
        lib.AddUser(user5);
        lib.AddUser(user6);
        lib.AddUser(user7);
        lib.AddUser(user8);
        lib.AddUser(user9);
        lib.AddUser(user10);

        Console.ResetColor();
        Console.WriteLine("\n===Find Book/User===");
        lib.FindBook(book1.Name);
        lib.FindBook(book4.Name);
        lib.FindUser(user2.Name);
        lib.FindUser("shama");

        Console.ResetColor();
        Console.WriteLine("\n===Delete Book/User===");
        lib.DeleteUser(user1.Id);

        Console.ResetColor();

        Console.WriteLine("\n===Get Books===");
        lib.GetBooks();

        Console.WriteLine("\n===pagination Books===");
        Console.WriteLine("\n---Page 1---");
        lib.GetBooks(1);
        Console.WriteLine("\n---Page 2---");
        lib.GetBooks(2);
        Console.WriteLine("\n---Page 3---");
        lib.GetBooks(3);
        Console.WriteLine("\n---Page 4---");
        lib.GetBooks(4);

        Console.WriteLine("\n===Get Users===");
        lib.GetUsers();

        Console.WriteLine("\n===Sort Books by Created Date===");
        lib.SortBooks();

        Console.WriteLine("\n===Sort Users by Created Date===");
        lib.SortUsers();
    }
}
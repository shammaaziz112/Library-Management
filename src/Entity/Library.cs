namespace library_management.src.Entity
{
    public class Library
    {
        List<Book> books;
        List<User> users;

        public Library()
        {
            books = new List<Book>();
            users = new List<User>();
        }

        public void add<T>(T item)
        {
            if (typeof(T) == typeof(Book))
            {
                books.Add(item as Book);
                Console.WriteLine("added book");

            }
            else if (typeof(T) == typeof(User))
            {
                users.Add(item as User);
                Console.WriteLine("added user");
            }
        }


        public void Find<T>(T name)
        {
            Book? foundBook = books.Find(book => book.Title == name as string);

            if (foundBook != null)
            {
                Console.WriteLine($"Founded the book: {foundBook.Title}");
            }
            else
            {
                User? foundUser = users.Find(user => user.Name == name as string);
                Console.WriteLine($"Founded the user: {foundUser.Name}");
            }
        }

        public void Delete(Guid id)
        {
            Book? foundBook = books.Find(book => book.Id == id);
            if (foundBook is not null)
            {
                books.Remove(foundBook);
                Console.WriteLine($"Hey, {foundBook.Title} book with Id {id} deleted ");
                return;
            }

            User? foundUser = users.Find(user => user.Id == id);
            if (foundUser is not null)
            {
                users.Remove(foundUser);
                Console.WriteLine($"Hey, {foundUser.Name} user with Id {id} deleted ");
                return;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void GetBooks()
        {
            var sortedBooks = from book in books
                              orderby book.CreateDate
                              select book;
            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Type: {book.Type}, Date: {book.CreateDate} \n");
            }
        }
        public void GetUsers()
        {
            var sortedUsers = from user in users
                              orderby user.CreateDate
                              select user;
            foreach (var user in users)
            {
                Console.WriteLine($"Title: {user.Name}, Date: {user.CreateDate} \n");
            }
        }

    }
}
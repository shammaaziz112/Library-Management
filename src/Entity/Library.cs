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

        public void Add<T>(T item)
        {
            if (item is Book book)
            {
                books.Add(book);
                Console.WriteLine($"Added book: {book.Title}");
                return;
            }
            else if (item is User user)
            {
                users.Add(user);
                Console.WriteLine($"Added user: {user.Name}");
                return;
            } 
            Console.WriteLine("Didn't add successfully");
            
        }
        public void Find<T>(T name)
        {
            if (name is string searchName)
            {
                var foundBook = books.Find(book => book.Title.Equals(searchName, StringComparison.OrdinalIgnoreCase));
                if (foundBook != null)
                {
                    Console.WriteLine($"Found the book: {foundBook.Title}");
                    return;
                }

                var foundUser = users.Find(user => user.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
                if (foundUser != null)
                {
                    Console.WriteLine($"Found the user: {foundUser.Name}");
                    return;
                }
            }

            Console.WriteLine($"{name} not found");
        }

        public void Delete(Guid id)
        {
            var foundBook = books.FirstOrDefault(book => book.Id == id);
            if (foundBook != null)
            {
                books.Remove(foundBook);
                Console.WriteLine($"Deleted book: {foundBook.Title} with Id {id}");
                return;
            }

            var foundUser = users.FirstOrDefault(user => user.Id == id);
            if (foundUser != null)
            {
                users.Remove(foundUser);
                Console.WriteLine($"Deleted user: {foundUser.Name} with Id {id}");
                return;
            }

            Console.WriteLine("Id not found");
        }

        public void GetBooks()
        {
            var sortedBooks = books.OrderBy(book => book.CreateDate);
            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Type: {book.Type}, Date: {book.CreateDate} \n");
            }
        }
        public void GetUsers()
        {
            var sortedUsers = users.OrderBy(user => user.CreateDate);
            foreach (var user in users)
            {
                Console.WriteLine($"Title: {user.Name}, Date: {user.CreateDate} \n");
            }
        }

    }
}
namespace library_management.src.Entity
{
    public class Library
    {
        public INotificationService Notification;
        public List<Book> books;
        public List<User> users;

        public Library(INotificationService notification)
        {
            Notification = notification;
            books = new List<Book>();
            users = new List<User>();
        }
        public void AddBook(Book book)
        {
            var foundBook = books.Find(books => books.Name.Equals(book.Name));
            if (foundBook == null)
            {
                books.Add(book);
                Notification.SendNotificationOnSucess($"Book '{book.Name}' added to Library");
            }
            else
            {
                Notification.SendNotificationOnFailure("Didn't add the book successfully");
            }
        }
        public void AddUser(User user)
        {
            var foundUser = users.Find(users => users.Name.Equals(user.Name));
            if (foundUser == null)
            {
                users.Add(user);
                Notification.SendNotificationOnSucess($"User '{user.Name}' added to Library");
            }
            else
            {
                Notification.SendNotificationOnFailure("Didn't add the user successfully");
            }
        }
        public void FindBook(string searchName)
        {
            var foundBook = books.Find(book => book.Name.Equals(searchName));
            if (foundBook != null)
            {
                Notification.SendNotificationOnSucess($"Found the book: {foundBook.Name}");
            }
            else
            {

                Notification.SendNotificationOnFailure($"{searchName} book not found");
            }
        }
        public void FindUser(string searchName)
        {
            var foundUser = users.Find(user => user.Name.Equals(searchName));
            if (foundUser != null)
            {
                Console.WriteLine($"Found the user: {foundUser.Name}");
            }
            Console.WriteLine($"{searchName} user not found");
        }

        public void DeleteBook(Guid id)
        {
            var foundBook = books.FirstOrDefault(book => book.Id == id);
            if (foundBook != null)
            {
                books.Remove(foundBook);
                Notification.SendNotificationOnSucess($"Book '{foundBook.Name}' with Id {id} deleted");
            }
            else
            {
                Notification.SendNotificationOnFailure($"Book with Id {id} not found");
            }
        }
        public void DeleteUser(Guid id)
        {
            var foundUser = users.FirstOrDefault(user => user.Id == id);
            if (foundUser != null)
            {
                users.Remove(foundUser);
                Notification.SendNotificationOnSucess($"Deleted user: {foundUser.Name} with Id {id}");
                return;
            }

            Notification.SendNotificationOnFailure($"User with Id {id} not found");
        }

        public void GetBooks()
        {
            var sortedBooks = books.OrderBy(book => book.CreateDate);
            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"Title: {book.Name}, Type: {book.Type}, Date: {book.CreateDate} \n");
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
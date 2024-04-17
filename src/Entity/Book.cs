namespace library_management.src.Entity
{
    public class Book : BaseEntity
    {
        public BooksTypes Type;

        public Book(string title, DateTime? CreateDate = null) : base(title, CreateDate)
        {
            Type = BooksTypes.NoType;
        }
        public Book(string title, BooksTypes type, DateTime? CreateDate = null) : base(title, CreateDate)
        {
            Type = type;
        }
    }
}
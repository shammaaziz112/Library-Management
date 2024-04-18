namespace library_management.src.Entity
{
    public class Book : BaseEntity
    {
        public BooksTypes Type;

        public Book(string title, DateTime? createDate = null) : base(title, createDate)
        {
            Type = BooksTypes.NoType;
        }
        public Book(string title, BooksTypes type, DateTime? createDate = null) : base(title, createDate)
        {
            Type = type;
        }
    }
}
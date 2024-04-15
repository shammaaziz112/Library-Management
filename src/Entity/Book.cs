namespace library_management.src.Entity
{
    public class Book : BaseEntity
    {
        public string Title;
        public BooksTypes Type;

        public Book(string title, DateTime? CreateDate = null) : base(CreateDate)
        {
            Title = title;
            Type = BooksTypes.NoType;
        }
        public Book(string title, BooksTypes type, DateTime? CreateDate = null) : base(CreateDate)
        {
            Title = title;
            Type = type;
        }
    }
}
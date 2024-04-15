
namespace library_management.src.Entity
{
    public class User : BaseEntity
    {
        public string Name;

        public User(string name, DateTime? CreateDate = null) : base(CreateDate)
        {
            Name = name;
        }

    }
}
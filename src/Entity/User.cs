
namespace library_management.src.Entity
{
    public class User : BaseEntity
    {
        public User(string name, DateTime? CreateDate = null) : base(name, CreateDate)
        {
        }

    }
}
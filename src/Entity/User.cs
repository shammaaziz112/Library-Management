
namespace library_management.src.Entity
{
    public class User : BaseEntity
    {
        public User(string name, DateTime? createDate = null) : base(name, createDate)
        {
        }

    }
}
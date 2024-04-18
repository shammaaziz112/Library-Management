
namespace library_management.src
{
    public class User : BaseEntity
    {
        public User(string name, DateTime? createDate = null) : base(name, createDate)
        {
        }

    }
}
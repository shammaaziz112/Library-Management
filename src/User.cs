
namespace library_management.src
{
    public class User : BaseClass
    {
        public string Name;

        public User(string name, DateTime? CreateDate = null) : base(CreateDate)
        {
            Name = name;
        }

    }
}
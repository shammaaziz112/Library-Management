namespace library_management.src
{
    public class BaseClass
    {
        public Guid Id = Guid.NewGuid();
        public DateTime CreateDate;


        public BaseClass(DateTime? createDate = null)
        {
            CreateDate = createDate is null ? DateTime.Now : (DateTime)createDate;
        }
    }
}
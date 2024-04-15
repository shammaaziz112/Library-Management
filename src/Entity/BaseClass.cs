namespace library_management.src.Entity
{
    public class BaseEntity
    {
        public Guid Id = Guid.NewGuid();
        public DateTime CreateDate;


        public BaseEntity(DateTime? createDate = null)
        {
            CreateDate = createDate is null ? DateTime.Now : (DateTime)createDate;
        }
    }
}
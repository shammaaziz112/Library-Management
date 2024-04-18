namespace library_management.src.Entity
{
    public  class BaseEntity
    {
        public Guid Id = Guid.NewGuid();
        public string Name; 
        public DateTime CreateDate;


        public BaseEntity(string name, DateTime? createDate = null)
        {
            Name = name;
            CreateDate = createDate is null ? DateTime.Now : (DateTime)createDate;
        }
    }
}
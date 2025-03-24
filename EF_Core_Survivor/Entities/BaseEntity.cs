namespace EF_Core_Survivor.Entities
{
    public class BaseEntity
    {

        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }


    }
}

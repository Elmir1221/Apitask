namespace fiorellopb101.Models
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
        public bool SoftDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}

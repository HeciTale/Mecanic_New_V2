namespace MecanicNew.Model
{
    public class RepairSelects 
    
    {

        public int Id { get; set; }
        public int CarId { get; set; }
        public int CarOwnerId {  get; set; }
        public int DriverId { get; set; }
        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public virtual Car Car { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual User User { get; set; }
        public virtual CarOwner Owner { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

    }
}

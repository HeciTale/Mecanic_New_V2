namespace MecanicNew.Model
{
    public class Repair
    {
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public string CarOwner { get; set; }
        public string Mecanic {  get; set; }
        public DateTime AddTime { get; set; }
        public int TotalPrice { get; set; }
        public int? Paid { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

    }
}

namespace MecanicNew.Model
{
    public class RepairDesciription
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public string Type { get; set; }
        public string RepairDesc {  get; set; }
        public int RepairCount { get; set; }
        public int RepairPrice { get; set; }
        public int RepairTotalPrice { get; set; }

      
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}

namespace MecanicNew.Model
{
    public class RepairTotalPrices
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

    }
}

namespace Parking_Management_V3.Models
{
    public class TblPricingPolicy
    {
        public int id { get; set; }
        public string PlanName { get; set; }
        public long EntrancPrice { get; set; }
        public long Hour { get; set; }
        public string Description { get; set; }

        public TblPricingPolicy(int id, string planName, long entrancPrice, long hour, string description)
        {
            this.id = id;
            PlanName = planName;
            EntrancPrice = entrancPrice;
            Hour = hour;
            Description = description;
        }

        public TblPricingPolicy(string planName, long entrancPrice, long hour, string description)
        {
            PlanName = planName;
            EntrancPrice = entrancPrice;
            Hour = hour;
            Description = description;
        }

        public TblPricingPolicy(int id)
        {
            this.id = id;
        }

        public TblPricingPolicy()
        {
        }
    }
}

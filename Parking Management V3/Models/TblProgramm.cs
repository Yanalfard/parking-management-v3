namespace Parking_Management_V3.Models
{
    public class TblProgramm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeHold { get; set; }
        public long Price { get; set; }
        public string Discription { get; set; }

        public TblProgramm(int id, string name, int timeHold, long price, string discription)
        {
            Id = id;
            Name = name;
            TimeHold = timeHold;
            Price = price;
            Discription = discription;
        }

        public TblProgramm(string name, int timeHold, long price, string discription)
        {
            Name = name;
            TimeHold = timeHold;
            Price = price;
            Discription = discription;
        }

        public TblProgramm(int id)
        {
            Id = id;
        }

        public TblProgramm()
        {
        }
    }
}
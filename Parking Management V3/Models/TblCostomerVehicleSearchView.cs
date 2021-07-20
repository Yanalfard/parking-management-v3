namespace Parking_Management_V3.Models
{
    public class TblCostomerVehicleSearchView
    {
        public string Name { get; set; }
        public string VehicleId { get; set; }
        public int Floor { get; set; }
        public string PositionId { get; set; }

        public TblCostomerVehicleSearchView(string name, string vehicleId, int floor, string positionId)
        {
            Name = name;
            VehicleId = vehicleId;
            Floor = floor;
            PositionId = positionId;
        }
    }
}

namespace Parking_Management_V3.Models
{
    public class TblFloor_i
    {
        public int SpotId { get; set; }
        public int SpotStatus { get; set; }
        public string VehicleId { get; set; }

        public TblFloor_i(int spotId, int spotStatus, string vehicleId)
        {
            SpotId = spotId;
            SpotStatus = spotStatus;
            VehicleId = vehicleId;
        }

        public TblFloor_i()
        {
        }
    }
}
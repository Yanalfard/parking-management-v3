using System;

namespace Parking_Management_V3.Models
{
    public class TblCostomerVehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleId { get; set; }
        public DateTime TimeArrived { get; set; }
        public DateTime TimeGone { get; set; }
        public string TimeStayed { get; set; }
        public long Price { get; set; }
        public int Floor { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string PositionId { get; set; }

        public TblCostomerVehicle(int id, string name, string vehicleId, DateTime timeArrived, DateTime timeGone, string timeStayed, long price, int floor, int column, int row, string positionId)
        {
            Id = id;
            Name = name;
            VehicleId = vehicleId;
            TimeArrived = timeArrived;
            TimeGone = timeGone;
            TimeStayed = timeStayed;
            Price = price;
            Floor = floor;
            Column = column;
            Row = row;
            PositionId = positionId;
        }

        public TblCostomerVehicle(string name,  string vehicleId, DateTime timeArrived, DateTime timeGone, string timeStayed, long price, int floor, int column, int row, string positionId)
        {
            Name = name;
            VehicleId = vehicleId;
            TimeArrived = timeArrived;
            TimeGone = timeGone;
            TimeStayed = timeStayed;
            Price = price;
            Floor = floor;
            Column = column;
            Row = row;
            PositionId = positionId;
        }

        public TblCostomerVehicle(int id)
        {
            Id = id;
        }
        public TblCostomerVehicle()
        {
        }
    }
}
using System;

namespace Parking_Management_V3.Models
{
    public class TblVip
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VehicleId { get; set; }
        public DateTime TimeHoldFrom { get; set; }
        public DateTime TimeHoldTo { get; set; }
        public int Floor { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string PositionId { get; set; }
        public int ProgrammId { get; set; }

        public TblVip(int id, string firstName, string lastName, string vehicleId, DateTime timeHoldFrom, DateTime timeHoldTo, int floor, int column, int row, string positionId, int programmId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            VehicleId = vehicleId;
            TimeHoldFrom = timeHoldFrom;
            TimeHoldTo = timeHoldTo;
            Floor = floor;
            Column = column;
            Row = row;
            PositionId = positionId;
            ProgrammId = programmId;
        }

        public TblVip(string firstName, string lastName, string vehicleId, DateTime timeHoldFrom, DateTime timeHoldTo, int floor, int column, int row, string positionId, int programmId)
        {
            FirstName = firstName;
            LastName = lastName;
            VehicleId = vehicleId;
            TimeHoldFrom = timeHoldFrom;
            TimeHoldTo = timeHoldTo;
            Floor = floor;
            Column = column;
            Row = row;
            PositionId = positionId;
            ProgrammId = programmId;
        }

        public TblVip(int id)
        {
            Id = id;
        }

        public TblVip()
        {
        }
    }
}
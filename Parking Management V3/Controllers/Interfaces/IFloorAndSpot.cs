using System.Collections.Generic;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface IFloorAndSpot
    {
        bool AddFloor();
        bool DeleteFloor();
        bool AddSpot(int floorNumber);
        bool DeleteSpot(int floorNumber);
        List<TblFloor_i> FetchSpots(int floor);
        int FetchFloorCount();
        bool EnterSpot(int id, int floor, string vehicleId);
        bool ExitSpot(int id, int floor);
        bool EnterVip(int id, int floor, string vehicleId);

    }
}

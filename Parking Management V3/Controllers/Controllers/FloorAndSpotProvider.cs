using System.Collections.Generic;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class FloorAndSpotProvider : IFloorAndSpot
    {
        public bool AddFloor()
        {
            MainProvider main = new MainProvider();
            return main.AddDeleteFloor(0);
        }

        public bool DeleteFloor()
        {
            MainProvider main = new MainProvider();
            return main.AddDeleteFloor(1);
        }

        public bool AddSpot(int floorNumber)
        {
            MainProvider main = new MainProvider();
            return main.AddDeleteSpot(0, floorNumber);
        }

        public bool DeleteSpot(int floorNumber)
        {
            MainProvider main = new MainProvider();
            return main.AddDeleteSpot(1, floorNumber);
        }

        public List<TblFloor_i> FetchSpots(int floor)
        {
            MainProvider main = new MainProvider();
            return main.FetchSpots(floor);
        }

        public int FetchFloorCount()
        {
            MainProvider main = new MainProvider();
            return main.FetchFloorCount();
        }

        public bool EnterSpot(int id, int floor, string vehicleId)
        {
            MainProvider main = new MainProvider();
            return main.EnterSpot(id, floor, vehicleId);
        }

        public bool ExitSpot(int id, int floor)
        {
            MainProvider main = new MainProvider();
            return main.ExitSpot(id, floor);
        }

        public bool EnterVip(int id, int floor, string vehicleId)
        {
            MainProvider main = new MainProvider();
            return main.EnterVip(id, floor, vehicleId);
        }
    }
}
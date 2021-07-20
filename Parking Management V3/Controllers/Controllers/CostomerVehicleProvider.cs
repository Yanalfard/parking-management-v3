using System;
using System.Collections.Generic;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class CostomerVehicleProvider : ICostomerVehicle
    {
        public TblCostomerVehicle FetchCostomerAndVehicleByVehicleId(string vehicleId)
        {
            MainProvider main = new MainProvider();
            return main.FetchTblCostomerVehicle(vehicleId);
        }

        public bool AddCostomerVehicle(TblCostomerVehicle costomerVehicle)
        {
            MainProvider main = new MainProvider();
            return main.Insert(costomerVehicle, 1);
        }

        public bool DeleteCostomerVehicle(TblCostomerVehicle costomerVehicle)
        {
            MainProvider main = new MainProvider();
            return main.Delete(1, costomerVehicle.VehicleId);
        }

        public bool EditCostomerVehicle(TblCostomerVehicle newCostomerVehicle, TblCostomerVehicle oldCostomerVehicle)
        {
            MainProvider main = new MainProvider();
            return main.Update(newCostomerVehicle, 1, oldCostomerVehicle.VehicleId);
        }

        public TblCostomerVehicle FetchCostomerAndVehicleByPosition(int positionId, int floor)
        {
            MainProvider main = new MainProvider();
            return main.FetchCostomerVehicleByPosition(positionId, floor);
        }

        public List<TblCostomerVehicle> FetchAllCostomerVehicles()
        {
            MainProvider main = new MainProvider();
            return main.FetchAllCostomerVehicles();
        }

        public List<TblCostomerVehicle> FetchTimedCostomerVehicles(DateTime fromTime, DateTime toTime)
        {
            MainProvider main = new MainProvider();
            return main.FetchTimedCostomerVehicles(fromTime, toTime);
        }

        public List<TblCostomerVehicleSearchView> FetchCostomerVehicleSearch(string vehicleIdOrName)
        {
            MainProvider main = new MainProvider();
            return main.FetchCostomerVehicleSearch(vehicleIdOrName);
        }
    }
}
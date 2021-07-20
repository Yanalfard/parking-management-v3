using System;
using System.Collections.Generic;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface ICostomerVehicle
    {
        TblCostomerVehicle FetchCostomerAndVehicleByVehicleId(string vehicleId);
        bool AddCostomerVehicle(TblCostomerVehicle costomerVehicle);
        bool DeleteCostomerVehicle(TblCostomerVehicle costomerVehicle);
        bool EditCostomerVehicle(TblCostomerVehicle newCostomerVehicle, TblCostomerVehicle oldCostomerVehicle);
        TblCostomerVehicle FetchCostomerAndVehicleByPosition(int positionId, int floor);
        List<TblCostomerVehicle> FetchAllCostomerVehicles();
        List<TblCostomerVehicle> FetchTimedCostomerVehicles(DateTime fromTime, DateTime toTime);

    }
}

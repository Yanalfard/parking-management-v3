using System;
using System.Collections.Generic;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface ITblvip
    {
        TblVip FetchVipWithVehicleId(TblVip vip);
        bool AddVip(TblVip vip);
        List<TblVip> FetchAllVips();
        bool EditVip(TblVip newVip, TblVip oldVip);
        List<TblVip> FetchCurrentVips();
        List<TblVip> FetchTimedVips(DateTime fromTime, DateTime toTime);

    }
}

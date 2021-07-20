using System;
using System.Collections.Generic;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class VipProvider : ITblvip
    {
        public TblVip FetchVipWithVehicleId(TblVip vip)
        {
            return new MainProvider().FetchVipWithVehicleId(vip.VehicleId);
        }
        public bool AddVip(TblVip vip)
        {
            MainProvider main = new MainProvider();
            return main.Insert(vip, 2);
        }

        public bool DeleteVip(TblVip vip)
        {
            MainProvider main = new MainProvider();
            return main.Delete(2, vip.VehicleId);
        }
        public bool EditVip(TblVip newVip, TblVip oldVip)
        {
            MainProvider main = new MainProvider();
            return main.Update(newVip, 2, oldVip.VehicleId);
        }

        public List<TblVip> FetchCurrentVips()
        {
            MainProvider main = new MainProvider();
            return main.FetchCurrentVips();
        }

        public List<TblVip> FetchTimedVips(DateTime fromTime, DateTime toTime)
        {
            MainProvider main = new MainProvider();
            return main.FetchTimedVips(fromTime, toTime);
        }

        public List<TblVip> FetchAllVips()
        {
            MainProvider main = new MainProvider();
            return main.FetchAllVips();
        }

    }
}
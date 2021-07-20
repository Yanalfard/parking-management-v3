using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class SettingProvider : ISetting
    {
        public bool ResetTblAgent()
        {
            MainProvider main = new MainProvider();
            return main.DeleteAllDataInTblAgent();
        }

        public bool ResetFloorsAndSpots()
        {
            MainProvider main = new MainProvider();
            return main.ReseteAllFloorsAndSpots();
        }

        public bool ResetTblCostomerVehicle()
        {
            MainProvider main = new MainProvider();
            return main.DeleteAllDataInTblCostomerVehicle();
        }
    }
}
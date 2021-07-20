using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface IAgent
    {
        TblAgent LoginAgent(TblAgent agent);
        bool AddAgent(TblAgent agent);
        bool DeleteAgent(TblAgent agent);
        bool EditAgent(TblAgent newAgent, TblAgent oldAgent);
    }
}

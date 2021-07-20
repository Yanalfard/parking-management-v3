using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    public class AgentProvider : IAgent
    {
        public TblAgent LoginAgent(TblAgent agent)
        {
            MainProvider main = new MainProvider();
            return main.Login(agent);
        }

        public bool AddAgent(TblAgent agent)
        {
            MainProvider main = new MainProvider();
            return main.Insert(agent, 0);
        }

        public bool DeleteAgent(TblAgent agent)
        {
            MainProvider main = new MainProvider();
            return main.Delete(0, agent.Identification.ToString());
        }

        public bool EditAgent(TblAgent newAgent, TblAgent oldAgent)
        {
            MainProvider main = new MainProvider();
            return main.Update(newAgent, 0, oldAgent.Identification.ToString());
        }
    }
}
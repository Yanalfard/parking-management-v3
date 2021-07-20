using System.Collections.Generic;
using Parking_Management_V3.Controllers.Interfaces;
using Parking_Management_V3.Models;
using Parking_Management_V3.Utility;

namespace Parking_Management_V3.Controllers.Controllers
{
    class PricingPolicyProvider : IPricingPolicy
    {
        public bool AddPricingPolicy(TblPricingPolicy pricingPolicy)
        {
            MainProvider main = new MainProvider();
            return main.AddPricingPolicy(pricingPolicy);
        }

        public bool UpdatePricingPolicy(TblPricingPolicy pricingPolicy, int logId)
        {
            MainProvider main = new MainProvider();
            return main.UpdatePricingPolicy(pricingPolicy, logId);
        }

        public bool DeletePricingPolicy(int id)
        {
            MainProvider main = new MainProvider();
            return main.DeletePricingPolicy(id);
        }

        public TblPricingPolicy SelectPricingPolicyById(int id)
        {
            MainProvider main = new MainProvider();
            return main.SelectPricingPolicyById(id);
        }

        public List<TblPricingPolicy> SelectAllPricingPolicies()
        {
            MainProvider main = new MainProvider();
            return main.SelectAllPricingPolicies();
        }
    }
}

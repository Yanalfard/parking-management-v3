using System.Collections.Generic;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Controllers.Interfaces
{
    interface IPricingPolicy
    {
        bool AddPricingPolicy(TblPricingPolicy pricingPolicy);
        bool UpdatePricingPolicy(TblPricingPolicy pricingPolicy, int logId);
        bool DeletePricingPolicy(int id);
        TblPricingPolicy SelectPricingPolicyById(int id);
        List<TblPricingPolicy> SelectAllPricingPolicies();

    }
}

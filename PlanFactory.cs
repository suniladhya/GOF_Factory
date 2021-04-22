using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_Factory
{
    class PlanFactory
    {
        public Plan getPlan(String planType)
        {
            if (planType == null)
            {
                return null;
            }
            if (string.Equals(planType, "DOMESTICPLAN", StringComparison.OrdinalIgnoreCase))
            {
                return new DomesticPlan();
            }
            else if (string.Equals(planType, "COMMERCIALPLAN", StringComparison.OrdinalIgnoreCase))
            {
                return new CommercialPlan();
            }
            else if (string.Equals(planType, "INSTITUTIONALPLAN", StringComparison.OrdinalIgnoreCase))
            {
                return new InstitutionalPlan();
            }
            return null;
        }
    }
}

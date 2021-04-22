using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_Factory
{
    class DomesticPlan : Plan
    {
        public override void getRate()
        {
            rate = 50;
        }
    }

    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 100;
        }
    }

    class InstitutionalPlan : Plan
    {
        public override void getRate()
        {
            rate = 10;
        }
    }
}

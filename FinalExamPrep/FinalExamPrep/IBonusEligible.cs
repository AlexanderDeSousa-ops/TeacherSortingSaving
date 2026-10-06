using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public interface IBonusEligible
    {
        public double CalculateBonus();

        public string GetProformanceLevel();
    }
}

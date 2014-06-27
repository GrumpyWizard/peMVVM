using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using peMVVM.Problems.Manager;

namespace peMVVM.GUI.Models
{
  class peModel
  {
    internal static ProblemManager TheProblemManager;

    public peModel()
    {
      TheProblemManager = new ProblemManager();
    }
  }
}

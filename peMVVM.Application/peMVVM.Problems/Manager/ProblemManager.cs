using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using peMVVM.Problems.Solutions;
using peMVVM.Problems.Variables;

namespace peMVVM.Problems.Manager
{
  public class ProblemManager
  {
    private type_array _answer;

    public type_array GetSolution(int problemId)
    {
      switch (problemId)
      {
        case 1: p1 solution = new p1(); _answer = solution.Solution; break;
        default: _answer.CommentString = "Problem Has Not Yet Been Solved"; break;
      }
      return _answer;
    }

    public ProblemManager()
    {
      _answer.NumberOfVariablesUsed = 0;
    }
  }
}

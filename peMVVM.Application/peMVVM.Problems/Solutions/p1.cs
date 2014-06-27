using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using peMVVM.Problems.Interface;
using peMVVM.Problems.Variables;


/// <summary>
/// 
/// http://projecteuler.net/problem=1
/// 
/// Multiples of 3 and 5
/// 
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
/// Find the sum of all the multiples of 3 or 5 below 1000.
/// 
/// </summary>


namespace peMVVM.Problems.Solutions
{
  internal class p1 : ISolution
  {
    private type_array _sum;

    public type_array Solution
    {
      get { return CalculateSolution(); }
    }

    private bool IsDivisibleBy3And5(int n)
    {
      if (((n % 3) == 0) || ((n % 5) == 0))
        return true;
      return false;
    }

    private type_array CalculateSolution()
    {
      for (int i = 0; i < 1000; i++)
      {
        if (IsDivisibleBy3And5(i))
          _sum.Int1 += i;
      }
      return _sum;
    }

    public p1()
    {
      // initialize variables
      _sum.NumberOfVariablesUsed = 1;
      _sum.Int1 = 0;
    }
  }
}

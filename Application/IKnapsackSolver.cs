using System.Collections.Generic;

namespace DiscreteKnapsackProblem.Application
{
    public interface IKnapsackSolver
    {
        IList<Element> Elements { get; set; }
        int MaxWeight { get; set; }
        int Solve();
    }
}
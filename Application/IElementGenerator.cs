using System.Collections.Generic;

namespace DiscreteKnapsackProblem.Application
{
    public interface IElementGenerator
    {
        IList<Element> Generate();
        void PrintGeneratedItems();
    }
}
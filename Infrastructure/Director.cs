using System;
using DiscreteKnapsackProblem.Application;

namespace DiscreteKnapsackProblem.Infrastructure
{
    public class Director
    {
        public IBuilder Builder { get; init; }

        public void BuildWithRandomValues()
        {
            Builder.BuildGenerator();
            Builder.BuildElements();
            Builder.BuildMaxWeight();
        }

        public void BuildWithConcreteValues(int maxWeight, int elementsCount, int maxElementWeight, int maxElementValue)
        {
            Builder.BuildGenerator(elementsCount, maxElementWeight, maxElementValue);
            Builder.BuildElements();
            Builder.BuildMaxWeight(maxWeight);
        }

        public void Solve()
        {
            var recursiveResult = Builder.RecursiveSolver.Solve();
            var approximateResult = Builder.ApproximateSolver.Solve();

            PrintValues();
            Console.WriteLine($"Recursive solution is: {recursiveResult}\nApproximateSolution is: {approximateResult}");
        }

        private void PrintValues()
        {
            var maxKnapsackWeight = Builder.RecursiveSolver.MaxWeight;

            Console.WriteLine($"Max knapsack weight is: {maxKnapsackWeight}");
        }

    }
}
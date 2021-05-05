using System;
using System.Collections.Generic;
using DiscreteKnapsackProblem.Application;
using DiscreteKnapsackProblem.Helpers;

namespace DiscreteKnapsackProblem.Infrastructure
{
    public class Director
    {
        private List<int> _recursiveSolutions;
        private List<int> _approximateSolutions;
        public IBuilder Builder { get; init; }

        public Director()
        {
            _recursiveSolutions = new();
            _approximateSolutions = new();
        }

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

        public void SolveAndCountDiffrences()
        {
            var recursiveResult = Builder.RecursiveSolver.Solve();
            var approximateResult = Builder.ApproximateSolver.Solve();

            _recursiveSolutions.Add(recursiveResult);
            _approximateSolutions.Add(approximateResult);

            PrintValues(recursiveResult, approximateResult);
        }

        private void PrintValues(int recursiveResult, int approximateResult)
        {
            var maxKnapsackWeight = Builder.RecursiveSolver.MaxWeight;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{ _recursiveSolutions.Count }. try:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Max knapsack weight is: {maxKnapsackWeight}");           
            Console.WriteLine($"Recursive solution is: {recursiveResult}\nApproximateSolution is: {approximateResult}\n");

            CountAndPrintDiffrences();
        }

        private void CountAndPrintDiffrences()
        {
            var variance = ResultQualityComparer.Variance(_recursiveSolutions, _approximateSolutions);
            var stdDeviation = ResultQualityComparer.StandardDeviation(_recursiveSolutions, _approximateSolutions);

            Console.WriteLine($"Differences after: {_recursiveSolutions.Count} tries:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Variance is equal to: {variance}.\nStandard deviation is equal to: {stdDeviation}.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("............................................");
        }

    }
}
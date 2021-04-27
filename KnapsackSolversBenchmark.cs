using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace DiscreteKnapsackProblem
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class KnapsackSolversBenchmark
    {
        private readonly ElementGenerator generator;
        private readonly IList<Element> generatedElements;
        private readonly RecursiveKnapsackSolver recursiveSolver;
        private readonly ApproximationKnapsackSolver approximateSolver;

        public KnapsackSolversBenchmark()
        {
            generator = new ElementGenerator(count: 30, maxWeight: 40, maxValue: 300);
            generatedElements = generator.Generate();
            recursiveSolver = new RecursiveKnapsackSolver(elements: generatedElements, maxWeight: 200);
            approximateSolver = new ApproximationKnapsackSolver(elements: generatedElements, maxWeight: 200);
            
        }

        [Benchmark]
        public void GetRecursiveSolverBenchmark()
        {
            recursiveSolver.Solve();
        }

        [Benchmark]
        public void GetApproximateSolverBenchmark()
        {
            approximateSolver.Solve();
        }
    }
}
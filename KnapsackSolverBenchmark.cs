using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace DiscreteKnapsackProblem
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class KnapsackSolverBenchmark
    {
        private readonly ElementGenerator generator;
        private readonly IList<Element> generatedElements;
        private readonly KnapsackSolver solver;

        public KnapsackSolverBenchmark()
        {
            generator = new ElementGenerator(count: 30, maxWeight: 40, maxValue: 30);
            generatedElements = generator.Generate();
            solver = new KnapsackSolver(elements: generatedElements, maxWeight: 200);
        }

        [Benchmark]
        public void GetSolverBenchmark()
        {
            solver.Solve();
        }
    }
}
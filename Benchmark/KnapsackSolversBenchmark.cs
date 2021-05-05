using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DiscreteKnapsackProblem.Application;
using DiscreteKnapsackProblem.Infrastructure;

namespace DiscreteKnapsackProblem
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class KnapsackSolversBenchmark
    {
        
        private readonly IBuilder knapsackBuilder;
        private readonly Director director;

        public KnapsackSolversBenchmark()
        {
            knapsackBuilder = new KnapsackBuilder();
            director = new Director 
            {
                Builder = knapsackBuilder
            };

            director.BuildWithRandomValues();
        }

        [Benchmark]
        public void GetRecursiveRandomBenchmark()
        {
            director.Builder.RecursiveSolver.Solve();
        }

        [Benchmark]
        public void GetApproximateRandomBenchmark()
        {
            director.Builder.ApproximateSolver.Solve();
        }

        [Benchmark]
        [Arguments(100, 10, 30, 30)]
        [Arguments(120, 20, 30, 30)]
        [Arguments(140, 25, 30, 40)]
        //[Arguments(150, 33, 30, 45)]
        //[Arguments(170, 35, 30, 50)]
        public void GetApproximateConcreteBenchmark(int maxWeight, int elementsCount, int maxElementWeight, int maxElementValue)
        {
            //director.BuildWithConcreteValues(maxWeight, elementsCount, maxElementWeight, maxElementValue);
            director.Builder.ApproximateSolver.Solve();
        }

        [Benchmark]
        [Arguments(100, 10, 30, 30)]
        [Arguments(120, 20, 30, 30)]
        [Arguments(140, 25, 30, 40)]
        //[Arguments(150, 33, 30, 45)]
        //[Arguments(170, 35, 30, 50)]
        public void GetRecursiveConcreteBenchmark(int maxWeight, int elementsCount, int maxElementWeight, int maxElementValue)
        {
            //director.BuildWithConcreteValues(maxWeight, elementsCount, maxElementWeight, maxElementValue);
            director.Builder.RecursiveSolver.Solve();
        }
    }
}
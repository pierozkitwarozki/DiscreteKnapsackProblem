using System;
using BenchmarkDotNet.Running;
using DiscreteKnapsackProblem.Infrastructure;

namespace DiscreteKnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var knapsackBuilder = new KnapsackBuilder();
            var director = new Director 
            {
                Builder = knapsackBuilder
            };

            director.BuildWithRandomValues();
            director.SolveAndCountDiffrences();

            director.BuildWithConcreteValues(200, 20, 30, 30);
            director.SolveAndCountDiffrences();

            director.BuildWithRandomValues();
            director.SolveAndCountDiffrences();

            director.BuildWithRandomValues();
            director.SolveAndCountDiffrences();

            Console.WriteLine("Do you want to run example Benchmark? (Y/n)");
            var answer = Console.ReadLine().Trim();

            if(answer == "Y" || answer == "y")
                BenchmarkRunner.Run<KnapsackSolversBenchmark>();

            /*
            Commands to run benchmark properly:
            1. dotnet build -c Release
            3. dotnet run
            */

            
        }
    }
}

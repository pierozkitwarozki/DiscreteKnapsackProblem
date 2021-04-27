using System;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace DiscreteKnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ElementGenerator(count: 10, maxWeight: 40, maxValue: 30);

            var generatedElements = generator.Generate();
            
            var recursiveSolver = new RecursiveKnapsackSolver(elements: generatedElements, maxWeight: 200);
            var approximateSolver = new ApproximationKnapsackSolver(elements: generatedElements, maxWeight: 200);

            generator.PrintGeneratedItems();

            Console.WriteLine($"Approximate max value is: {approximateSolver.Solve()}");

            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Recursive max value is: {recursiveSolver.Solve()}");

            Console.WriteLine("***** *** Benchmark ***** ***");


            /*
            Commands to run benchmark properly:
            1. dotnet build -c Release
            2. cd 'bin/Release/net5.0/'
            3. dotnet DiscreteKnapsackProblem.dll
            */
            //BenchmarkRunner.Run<KnapsackSolversBenchmark>();
        }
    }
}

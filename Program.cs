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
            director.Solve();

            director.BuildWithConcreteValues(200, 20, 30, 30);
            director.Solve();

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

using System;

namespace DiscreteKnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ElementGenerator(count: 10, maxWeight: 40, maxValue: 30);

            var generatedElements = generator.Generate();
            
            var solver = new KnapsackSolver(elements: generatedElements, maxWeight: 90);

            solver.PrintItems();

            Console.WriteLine($"Max value is: {solver.Solve()}");
        }
    }
}

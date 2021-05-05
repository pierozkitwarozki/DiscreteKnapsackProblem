namespace DiscreteKnapsackProblem.Application
{
    public interface IBuilder
    {
        IKnapsackSolver RecursiveSolver { get; }
        IKnapsackSolver ApproximateSolver { get ; }
         void BuildElements();
         void BuildMaxWeight();
         void BuildMaxWeight(int maxWeight);
         void BuildGenerator();
         void BuildGenerator(int count, int maxElementWeight, int maxElementValue);
    }
}
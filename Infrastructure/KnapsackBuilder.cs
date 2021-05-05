using System;
using DiscreteKnapsackProblem.Application;
using DiscreteKnapsackProblem.Infrastructure.Solvers;

namespace DiscreteKnapsackProblem.Infrastructure
{
    public class KnapsackBuilder : IBuilder
    {
        public IKnapsackSolver RecursiveSolver
        { 
            get
            {
                return _recursiveSolver;
            }
        }

        public IKnapsackSolver ApproximateSolver
        { 
            get
            {
                return _approximateSolver;
            }
        }
        private IKnapsackSolver _recursiveSolver;
        private IKnapsackSolver _approximateSolver;
        private IElementGenerator _elementGenerator;
        public KnapsackBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _recursiveSolver = new RecursiveKnapsackSolver();
            _approximateSolver = new ApproximationKnapsackSolver();
            _elementGenerator = new ElementGenerator();
        }
        public void BuildElements()
        {     
            var elements = _elementGenerator.Generate();

            _recursiveSolver.Elements = elements;
            _approximateSolver.Elements = elements;

            //_elementGenerator.PrintGeneratedItems();
        }

        public void BuildMaxWeight(int maxWeight)
        {
            _recursiveSolver.MaxWeight = maxWeight;
            _approximateSolver.MaxWeight = maxWeight;
        }

        public void BuildGenerator()
        {
            _elementGenerator = new ElementGenerator();
        }

        public void BuildMaxWeight()
        {
            var randomWeight = new Random().Next(40, 400);

            _recursiveSolver.MaxWeight = randomWeight;
            _approximateSolver.MaxWeight = randomWeight;
        }

        public void BuildGenerator(int count, int maxElementWeight, int maxElementValue)
        {
            _elementGenerator = new ElementGenerator(count, maxElementWeight, maxElementValue);
        }
    }
}
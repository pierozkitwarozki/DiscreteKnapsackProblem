using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscreteKnapsackProblem
{
    public class ApproximationKnapsackSolver
    {
        private IList<Element> elements;
        private readonly int[] weights;
        private readonly int[] values;
        private readonly int maxWeight;

        public ApproximationKnapsackSolver(IList<Element> elements, int maxWeight)
        {
            this.elements = elements;
            this.maxWeight = maxWeight;

            weights = new int[elements.Count];
            values = new int[elements.Count];
        }

        public int Solve()
        {
           elements = elements.OrderByDescending(x => x.Value/x.Weight).ToList();

            for (int i = 0; i < elements.Count; i++)
            {
                weights[i] = elements[i].Weight;
                values[i] = elements[i].Value;
            }

            var currentWeight = 0;
            var maxValue = 0;

            for (int i=0; i < elements.Count; i++)
            {
                if(weights[i] + currentWeight <= maxWeight)
                {
                    currentWeight += weights[i];
                    maxValue += values[i];
                }
            }

            return maxValue; 
        }

        
    }
}
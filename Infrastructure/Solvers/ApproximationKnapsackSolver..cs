using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscreteKnapsackProblem.Application;

namespace DiscreteKnapsackProblem.Infrastructure.Solvers
{
    public class ApproximationKnapsackSolver : IKnapsackSolver
    {
        public IList<Element> Elements { get; set; }
        public int MaxWeight { get; set; }
        private int[] weights;
        private int[] values;       

        public int Solve()
        {
            weights = new int[Elements.Count];
            values = new int[Elements.Count];

            Elements = Elements.OrderByDescending(x => x.Value/x.Weight).ToList();

            for (int i = 0; i < Elements.Count; i++)
            {
                weights[i] = Elements[i].Weight;
                values[i] = Elements[i].Value;
            }

            var currentWeight = 0;
            var maxValue = 0;

            for (int i=0; i < Elements.Count; i++)
            {
                if(weights[i] + currentWeight <= MaxWeight)
                {
                    currentWeight += weights[i];
                    maxValue += values[i];
                }
            }

            return maxValue; 
        }

        
    }
}
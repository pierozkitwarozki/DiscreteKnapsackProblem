using System.Collections.Generic;
using System;

namespace DiscreteKnapsackProblem
{
    // Brute force solution
    public class RecursiveKnapsackSolver
    {
        private readonly IList<Element> elements;
        private readonly int[] weights;
        private readonly int[] values;
        private readonly int maxWeight;

        public RecursiveKnapsackSolver(IList<Element> elements, int maxWeight)
        {
            this.elements = elements;
            this.maxWeight = maxWeight;

            weights = new int[elements.Count];
            values = new int[elements.Count];

            for (int i = 0; i < elements.Count; i++)
            {
                weights[i] = elements[i].Weight;
                values[i] = elements[i].Value;
            }
        }

        public int Solve()
        {
            return MaxValue(elements.Count, maxWeight);
        }

        private int MaxValue(int i, int w)
        {
            if (i == 0)
            {
                return 0;
            }

            if (weights[i-1] > w)
            {
                var res = MaxValue(i - 1, w);
                return res;
            }

            else
            {
                var arg1 = MaxValue(i - 1, w);
                var arg2 = MaxValue(i-1, w - weights[i-1]) + values[i-1];

                var res = Math.Max(arg1, arg2);
                return res;
            }
        }
        
    }
}
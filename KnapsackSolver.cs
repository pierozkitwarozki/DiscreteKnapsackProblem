using System.Collections.Generic;
using System;

namespace DiscreteKnapsackProblem
{
    public class KnapsackSolver
    {
        private readonly IList<Element> elements;
        private readonly int maxWeight;

        public KnapsackSolver(IList<Element> elements, int maxWeight)
        {
            this.elements = elements;
            this.maxWeight = maxWeight;
        }
        public void PrintItems()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine
                    ($"{i+1}. Value: {elements[i].Value}, Weight: {elements[i].Weight}");
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

            if (elements[i-1].Weight > w)
            {
                var res = MaxValue(i - 1, w);
                return res;
            }

            else
            {
                var arg1 = MaxValue(i - 1, w);
                var arg2 = MaxValue(i-1, w - elements[i-1].Weight) + elements[i-1].Value;

                var res = Math.Max(arg1, arg2);
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System;
using DiscreteKnapsackProblem.Application;

namespace DiscreteKnapsackProblem.Infrastructure.Solvers
{

    // Brute force solution
    public class RecursiveKnapsackSolver : IKnapsackSolver
    {
        public IList<Element> Elements { get; set; }
        public int MaxWeight { get; set; }
        private int[] weights;
        private int[] values;   

        public int Solve()
        {
            InitalizeWeightAndValuesArrays();

            return MaxValue(Elements.Count, MaxWeight);
        }

        private void InitalizeWeightAndValuesArrays()
        {
            weights = new int[Elements.Count];
            values = new int[Elements.Count];

            for (int i = 0; i < Elements.Count; i++)
            {
                weights[i] = Elements[i].Weight;
                values[i] = Elements[i].Value;
            }
        }

        private int MaxValue(int i, int w)
        {
            if (i == 0)
            {
                return 0;
            }

            if (weights[i - 1] > w)
            {
                var res = MaxValue(i - 1, w);
                return res;
            }

            else
            {
                var arg1 = MaxValue(i - 1, w);
                var arg2 = MaxValue(i - 1, w - weights[i - 1]) + values[i - 1];

                var res = Math.Max(arg1, arg2);
                return res;
            }
        }

    }
}
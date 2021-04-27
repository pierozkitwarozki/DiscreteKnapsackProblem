using System.Collections.Generic;
using Bogus;

namespace DiscreteKnapsackProblem
{
    public class ElementGenerator
    {
        private readonly int count;
        private readonly int maxWeight;
        private readonly int maxValue;

        public ElementGenerator(int count, int maxWeight, int maxValue)
        {
            this.count = count;
            this.maxWeight = maxWeight;
            this.maxValue = maxValue;
        }

        public IList<Element> Generate()
        {
            var elements = new List<Element>();

            for(var i=0; i<count; i++)
            {
                var fakeElement = new Faker<Element>()
                    .RuleFor(x => x.Value, x => x.Random.Int(min: 1, max: maxValue))
                    .RuleFor(x => x.Weight, x => x.Random.Int(min: 1, max: maxWeight));

                var fakerValue = fakeElement.Generate();

                elements.Add(fakerValue);
            }
            
            return elements;
        } 
    }
}
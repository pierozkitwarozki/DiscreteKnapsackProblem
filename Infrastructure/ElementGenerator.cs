using System;
using System.Collections.Generic;
using Bogus;
using DiscreteKnapsackProblem.Application;

namespace DiscreteKnapsackProblem.Infrastructure
{

    public class ElementGenerator : IElementGenerator
    {
        private readonly int count;
        private readonly int maxElementWeight;
        private readonly int maxElementValue;
        private List<Element> elements;
        public ElementGenerator() 
        {
            var rand = new Random();
            count = rand.Next(5, 50);
            maxElementWeight = rand.Next(5, 50);
            maxElementValue = rand.Next(5, 50);
        }

        public ElementGenerator(int count, int maxElementWeight, int maxElementValue)
        {
            this.count = count;
            this.maxElementWeight = maxElementWeight;
            this.maxElementValue = maxElementValue;
        }

        public IList<Element> Generate()
        {
            elements = new();

            for (var i = 0; i < count; i++)
            {
                var fakeElement = new Faker<Element>()
                    .RuleFor(x => x.Value, x => x.Random.Int(min: 1, max: maxElementValue))
                    .RuleFor(x => x.Weight, x => x.Random.Int(min: 1, max: maxElementWeight));

                var fakerValue = fakeElement.Generate();

                elements.Add(fakerValue);
            }

            return elements;
        }

        public void PrintGeneratedItems()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine
                    ($"{i + 1}. Value: {elements[i].Value}, Weight: {elements[i].Weight}");
            }
        }
    }
}
using System;

namespace GOF.Behavioral.TemplateMethod
{
    /// <summary>
    /// base class contains some algorithm, steps of which are defined via inheritance
    /// </summary>
    public abstract class TemplateMethodBase : IPatternTest
    {
        public void Implement()
        {
            DifficultAlgorithm("TemplateMethod");
        }

        private void DifficultAlgorithm(string input)
        {
            var result = AlgoStepOne(input) + " " + AlgoStepTwo(input);
            Console.WriteLine(result);
        }

        protected abstract string AlgoStepOne(string test);
        protected abstract string AlgoStepTwo(string test);

        public void Name()
        {
            Console.WriteLine("TemplateMethod pattern");
        }
    }
}
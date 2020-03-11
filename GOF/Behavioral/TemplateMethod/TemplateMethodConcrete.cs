namespace GOF.Behavioral.TemplateMethod
{
    public class TemplateMethodConcrete : TemplateMethodBase
    {
        protected override string AlgoStepOne(string test)
        {
            return test.ToLower();
        }

        protected override string AlgoStepTwo(string test)
        {
            return test.ToUpper();
        }
    }
}
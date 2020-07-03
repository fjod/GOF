namespace GOF.Structural.Adapter
{
    public class SomethingThatPrintsThings
    {
        public void UseAdapted(IPrintAdapted adapted)
        {
            adapted.Print();
            adapted.Print(new PrintStringHolder{String = "sample string"});
        }
    }
}
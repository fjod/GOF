namespace GOF.Structural.Adapter
{
    public interface IPrintAdapted
    {
        public void Print();
        public void Print(PrintStringHolder s);
    }
}
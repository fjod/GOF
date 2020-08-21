namespace GOF.Structural.Proxy
{
    public class Proxy : ProxyBase<IPrint>
    {
        public Proxy() : base(new RealSubject())
        {
           //some job might be done here too
        }
    }
}
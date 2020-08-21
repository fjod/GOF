namespace GOF.Structural.Proxy
{
    public class Proxy : ProxyBase<IPrint>
    {
        public Proxy(IPrint print) : base(print)
        {
           //some job might be done here too
        }
    }
}
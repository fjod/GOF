namespace GOF.Behavioral.Observer
{
    public interface ISubject
    {
        void Attach(IVanillaObserver vanillaObserver);
        void Detach(IVanillaObserver vanillaObserver);
        void Notify();
    }
}
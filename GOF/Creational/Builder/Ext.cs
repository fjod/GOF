namespace GOF.Creational.Builder
{
    public static class Ext
    {
        public static Client ToUpper(this Client client)
        {
            return new Client(client.Message.ToUpper());
        }
        
        public static Client ToLower(this Client client)
        {
            return new Client(client.Message.ToLower());
        }
    }
}
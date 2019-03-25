namespace DesignPatterns.Strategy
{
    /// <summary>
    /// The client class wishes to use a service which retrieves some data
    /// and returns it as a serialised string. When the service's serialisation
    /// behaviour is implemented using the strategy pattern, the behaviour can
    /// be selected at runtime, making the service class extensible per the
    /// SOLID open-closed principle.
    /// </summary>
    class Client
    {

        public void Run()
        {
            // the service can be used to provide XML data

            Service xmlSerialisingService = new Service(new XmlSerialisationStrategy());

            string xmlData = xmlSerialisingService.RetrieveAndSerialiseData("myDataSource");

            // with a different strategy passed into the constructor,
            // the same service implementation can provide JSON data instead

            Service jsonSerialisingService = new Service(new JsonSerialisationStrategy());

            string jsonData = jsonSerialisingService.RetrieveAndSerialiseData("myDataSource");

            // addition of new serialisation behaviours won't require modification
            // of the Service class, thereby complying with the open-closed principle

            // Service xmlSerialisingService = new Service(new Base64BinarySerialisationStrategy());
        }
    }
}

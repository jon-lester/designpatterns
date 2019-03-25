namespace DesignPatterns.Strategy
{
    class Service
    {
        private readonly ISerialisationStrategy serialisationStrategy;

        public Service(ISerialisationStrategy serialisationStrategy)
        {
            this.serialisationStrategy = serialisationStrategy;
        }

        public string RetrieveAndSerialiseData(string dataSource)
        {
            object data = new object();

            // use the given strategy to serialise the data, without
            // needing to know what the specific algorithm is, decoupling
            // the implementation of this service from its behaviour
            return this.serialisationStrategy.Serialise(data);
        }
    }
}

namespace DesignPatterns.Builder
{
    /// <summary>
    /// The client class needs to create an instance of an object with
    /// a specific set of options, but it would be inconvenient to have
    /// to supply *every* option in the correct way at the constructor.
    /// Tt would be nicer to be able to delegate the responsibility of
    /// constructing a suitable object elsewhere.
    /// </summary>
    class Client
    {
        public void CreateApiConnection()
        {
            // Builder

            ApiConnectionBuilder builder = new ApiConnectionBuilder();

            builder.UseUri("http://api.somehost.com/1/api");
            builder.UsePost();
            builder.UseHeader("Content-Type: application/json");

            var apiConnection = builder.Build();


            // Fluent Builder

            // it's also possible to design a builder so that it can be used fluently,
            // by returning the builder instance from each method and ending the chain
            // with the Build() call.

            var apiConnection2 = new FluentApiConnectionBuilder()
                .WithUri("http://api.somehost.com/1/api")
                .WithPostMethod()
                .WithHeader("Content-Type: application/json")
                .Build();
        }

    }
}

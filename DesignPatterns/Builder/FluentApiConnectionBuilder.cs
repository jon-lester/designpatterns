namespace DesignPatterns.Builder
{
    class FluentApiConnectionBuilder
    {
        private ApiConnection connection = new ApiConnection()
        {
            Method = "GET",
            UseCors = false,
            UseSSL = false
        };

        public FluentApiConnectionBuilder WithUri(string uri)
        {
            this.connection.Uri = uri;
            return this;
        }

        public FluentApiConnectionBuilder WithPostMethod()
        {
            this.connection.Method = "POST";
            return this;
        }

        public FluentApiConnectionBuilder WithGetMethod()
        {
            this.connection.Method = "GET";
            return this;
        }

        public FluentApiConnectionBuilder WithPutMethod()
        {
            this.connection.Method = "PUT";
            return this;
        }

        public FluentApiConnectionBuilder WithDeleteMethod()
        {
            this.connection.Method = "DELETE";
            return this;
        }

        public FluentApiConnectionBuilder WithCORS()
        {
            this.connection.UseCors = true;
            return this;
        }

        public FluentApiConnectionBuilder WithHeader(string header)
        {
            this.connection.Headers.Add(header);
            return this;
        }

        public FluentApiConnectionBuilder WithSsl()
        {
            this.connection.UseSSL = true;
            return this;
        }

        public ApiConnection Build()
        {
            return this.connection;
        }
    }
}

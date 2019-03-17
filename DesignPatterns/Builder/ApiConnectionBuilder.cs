namespace DesignPatterns.Builder
{
    /// <summary>
    /// This builder creates an <see cref="ApiConnection"/> with the
    /// configuration settings that are provided to it.
    /// 
    /// Its responsibility is to provide defaults where appropriate,
    /// and to ensure that the configuration of the returned object
    /// is valid.
    /// </summary>
    class ApiConnectionBuilder
    {
        private ApiConnection connection = new ApiConnection()
        {
            Method = "GET",
            UseCors = false,
            UseSSL = false
        };

        public void UseUri(string uri)
        {
            this.connection.Uri = uri;
        }

        public void UsePost()
        {
            this.connection.Method = "POST";
        }

        public void UseGet()
        {
            this.connection.Method = "GET";
        }

        public void UsePut()
        {
            this.connection.Method = "PUT";
        }

        public void UseDelete()
        {
            this.connection.Method = "DELETE";
        }

        public void UseCORS()
        {
            this.connection.UseCors = true;
        }

        public void UseHeader(string header)
        {
            this.connection.Headers.Add(header);
        }

        public void UseSsl()
        {
            this.connection.UseSSL = true;
        }

        public ApiConnection Build()
        {
            return this.connection;
        }
    }
}

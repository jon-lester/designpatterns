namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Represents an algorithm or strategy for serialising an object
    /// of arbitrary type to a string.
    /// </summary>
    interface ISerialisationStrategy
    {
        string Serialise(object obj);
    }
}

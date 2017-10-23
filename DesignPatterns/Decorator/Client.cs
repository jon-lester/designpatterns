using DesignPatterns.Decorator.Common;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// This client uses decorated instances of LegacyClass to make use of
    /// multiple functionalities. Note that there's a single decorator class
    /// per feature.
    /// </summary>
    class Client
    {
        public void Execute()
        {
            // using the original class, the client can access the old functionality
            IDoesSomething oldFunctionality = new LegacyClass();
            oldFunctionality.DoSomeThing("foo", 5);

            // now adding functionality A; each decorator is constructed with the interface that it implements
            IDoesSomething functionalityWithA = new LegacyClassDecoratorA(new LegacyClass());
            functionalityWithA.DoSomeThing("foo", 5);

            // similar pattern for functionality B on top of the old functionality..
            IDoesSomething functionalityWithB = new LegacyClassDecoratorB(new LegacyClass());
            functionalityWithB.DoSomeThing("foo", 5);

            // combinations of functionality are possible with constructor chaining - original + A + C
            IDoesSomething functionalityWithAandC = new LegacyClassDecoratorC(new LegacyClassDecoratorA(new LegacyClass()), 10);
            functionalityWithAandC.DoSomeThing("foo", 5);

            // the .Net streams library is a good example of the decorator pattern in the wild:

            using (var outputStream = 
                new GZipStream(
                new BufferedStream(
                new FileStream("hello.txt.gz", FileMode.Create)), CompressionMode.Compress))
            {
                byte[] someData = Encoding.UTF8.GetBytes("Hello world!");
                outputStream.Write(someData, 0, someData.Length);
                outputStream.Flush();
            }
        }
    }
}

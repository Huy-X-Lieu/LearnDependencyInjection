namespace Chapter01Library
{
    /// <summary>
    /// The ConsoleMessageWriter class implements IMessageWriter by wrapping 
    /// the Console class of the .NET Base Class Library(BCL).
    /// 
    /// This is a simple application of the Adapter design pattern.
    /// </summary>
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}

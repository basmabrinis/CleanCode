namespace CleanCode
{
    using System;

    /// <summary>
    /// IMessage Interface
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// MyCustomMethod Method
        /// </summary>
        /// <returns>string value</returns>
        string MyCustomMethod();
    }

    /// <summary>
    /// ExtendClass class
    /// </summary>
    public static class ExtendClass
    {
        /// <summary>
        /// SomeAdditionalMethod Method
        /// </summary>
        /// <param name="message">IMessage message</param>
        /// <returns>string value</returns>
        public static string SomeAdditionalMethod(this IMessage message)
        {
            return "Hello SomeAdditionalMethod On class extentions!";
        }
    }

    /// <summary>
    /// MessageA class
    /// </summary>
    public class MessageA : IMessage
    {
        /// <summary>
        /// MyCustomMethod method
        /// </summary> 
        /// <returns>string value</returns>
        public string MyCustomMethod()
        {
            return "Hello MyCustomMethod On class MessageA!";
        }
    }

    /// <summary>
    /// MessageB class
    /// </summary>
    public class MessageB : IMessage
    {
        /// <summary>
        /// MyCustomMethod Method
        /// </summary>
        /// <returns>string value</returns>
        public string MyCustomMethod()
        {
            return "Hello MyCustomMethod On class MessageB!";
        }
    }

    /// <summary>
    /// MessageC class
    /// </summary>
    public class MessageC : IMessage
    {
        /// <summary>
        /// MyCustomMethod Method
        /// </summary>
        /// <returns>string value</returns>
        public string MyCustomMethod()
        {
            return "Hello MyCustomMethod On class MessageC!";
        }
    }

    /// <summary>
    /// Program Class for CleanCode application
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Test FirstSolution!");
            Console.WriteLine(FirstSolution());

            Console.WriteLine("Test SecondSolution!");
            Console.WriteLine(SecondSolution());

            Console.ReadKey(true);
        }

        /// <summary>
        /// FirstSolution Method
        /// </summary>
        /// <returns>string value</returns>
        private static string FirstSolution()
        {
            try
            {
                object message = new MessageA();
                var resultValues = string.Empty;

                if (message is MessageA)
                {
                    var messageA = message as MessageA;
                    resultValues = messageA?.MyCustomMethod();
                }
                else if (message is MessageB)
                {
                    var messageB = message as MessageB;
                    resultValues = messageB?.MyCustomMethod();
                    resultValues = resultValues + messageB?.SomeAdditionalMethod();
                }
                else if (message is MessageC)
                {
                    var messageC = message as MessageC;

                    resultValues = messageC?.MyCustomMethod();
                }

                return resultValues;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        /// <summary>
        /// SecondSolution Method
        /// </summary>
        /// <returns>string value</returns>
        private static string SecondSolution()
        {
            try
            {
                var message = new MessageA();

                var resultValues = message.MyCustomMethod();
                resultValues = resultValues + Environment.NewLine + message.SomeAdditionalMethod();

                return resultValues;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}

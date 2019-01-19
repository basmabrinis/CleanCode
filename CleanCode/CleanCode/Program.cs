using System;


namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test FirstSolution!");
            FirstSolution();

            Console.WriteLine("Test FirstSolution!");
            SecondSolution();

            Console.ReadKey(true);


        }

        public static void FirstSolution()
        {
            object message = new MessageC();

            if (message is MessageA)
            {
                var messageA = message as MessageA;
                messageA?.MyCustomMethodOnA();
            }
            else if (message is MessageB)
            {
                var messageB = message as MessageB;
                messageB?.MyCustomMethodOnB();
                messageB?.SomeAdditionalMethodOnB();
            }
            else if (message is MessageC)
            {
                var messageC = message as MessageC;

                messageC?.MyCustomMethodOnC();
            }
        }

        private static void SecondSolution()
        {
            object message = new MessageC();
            switch (message.GetType().Name)
            {
                case "MessageA":

                    var messageA = message as MessageA;
                    messageA?.MyCustomMethodOnA();
                    break;

                case "MessageB":
                    var messageB = message as MessageB;
                    messageB?.MyCustomMethodOnB();
                    messageB?.SomeAdditionalMethodOnB();
                    break;
                case "MessageC":
                    var messageC = message as MessageC;

                    messageC?.MyCustomMethodOnC();
                    break;

            }
        }
    }

    public class MessageA
    {
        public void MyCustomMethodOnA()
        {
            Console.WriteLine("Hello MyCustomMethodOnA!");
        }
    }

    public class MessageB
    {
        public void MyCustomMethodOnB()
        {
            Console.WriteLine("Hello MyCustomMethodOnB!");
        }
        public void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("Hello SomeAdditionalMethodOnB!");
        }
    }

    public class MessageC
    {
        public void MyCustomMethodOnC()
        {
            Console.WriteLine("Hello MyCustomMethodOnC!");
        }
    }
}


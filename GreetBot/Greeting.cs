using System.Security.Cryptography;

namespace GreetBot
{
    public class Greeting
    {
        public const string FirstMessage = "Hi";
        public const string SecondMessage = "Good morning";
        public const string ThirdMessage = "Hi, how are you?";
        public const string FourthMessage = "Goodbye!";

        /// <summary>
        ///     Generates the greeting message.
        /// </summary>
        /// <returns> The greeting message. </returns>
        public string Greet()
        {
            int messageNumber = RandomNumberGenerator
                .GetInt32(
                    fromInclusive: 1,
                    toExclusive: 4);


            return messageNumber switch
            {
                1 => FirstMessage,
                2 => SecondMessage,
                3 => ThirdMessage,
                _ => FourthMessage,
            };
        }
    }
}

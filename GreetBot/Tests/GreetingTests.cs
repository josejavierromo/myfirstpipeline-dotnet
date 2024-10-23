namespace GreetBot.Tests
{
    [TestClass]
    public class GreetingTests
    {
        /// <summary>
        ///     The method: <see cref="Greeting.Greet"/>, when is invoked, 
        ///     it returns a random messsage.
        /// </summary>
        [TestMethod]
        public void Greet_IsInvoke_ReturnARandomMessage()
        {
            // Arragne.
            Greeting greeting = new Greeting();

            // Act.
            string message = greeting.Greet();

            // Assert.
            string[] allowedMessages =
            [
                Greeting.FirstMessage,
                Greeting.SecondMessage,
                Greeting.ThirdMessage,
                Greeting.FourthMessage,
            ];

            Assert.IsTrue(allowedMessages.Contains(message));
        }
    }
}

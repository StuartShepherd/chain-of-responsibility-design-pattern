namespace ChainOfResponsibilityDesignPattern
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var code in new List<string> { "Alpha", "Beta", "Gamma" })
            {
                Console.WriteLine($"Client: Do {code}");

                var result = handler.Handle(code);
                if (result == null)
                    Console.WriteLine($"\t{code} not run.");

                if (result != null)
                    Console.Write($"{result}");
            }
        }
    }
}

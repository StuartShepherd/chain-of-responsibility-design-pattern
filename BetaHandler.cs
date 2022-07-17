namespace ChainOfResponsibilityDesignPattern
{
    internal class BetaHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            return ((request as string) == "Beta")
                ? $"\tBeta done\n"
                : base.Handle(request);
        }
    }
}

namespace ChainOfResponsibilityDesignPattern
{
    internal class GammaHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            return ((request as string) == "Gamma")
                ? $"\tGamma done\n"
                : base.Handle(request);
        }
    }
}

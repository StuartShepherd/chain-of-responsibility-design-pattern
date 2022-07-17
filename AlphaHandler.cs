namespace ChainOfResponsibilityDesignPattern
{
    internal class AlphaHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            return ((request as string) == "Alpha") 
                ? $"\tAlpha done\n"
                : base.Handle(request);
        }
    }
}

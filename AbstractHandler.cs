namespace ChainOfResponsibilityDesignPattern
{
    public class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object? Handle(object request)
        {
            return _nextHandler == null 
                ? null 
                : _nextHandler.Handle(request);
        }
    }
}

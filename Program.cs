using ChainOfResponsibilityDesignPattern;

Console.WriteLine("Chain of Responsibility Design Pattern");
Console.WriteLine("Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers.");
Console.WriteLine("Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.");
Console.WriteLine();

var alpha = new AlphaHandler();
var beta = new BetaHandler();
var gamma = new GammaHandler();

alpha
    .SetNext(beta)
    .SetNext(gamma);

Console.WriteLine("Chain: Alpha > Beta > Gamma\n");
Client.ClientCode(alpha);
Console.WriteLine();

Console.WriteLine("Subchain: Beta > Gamma\n");
Client.ClientCode(beta);
Console.WriteLine();

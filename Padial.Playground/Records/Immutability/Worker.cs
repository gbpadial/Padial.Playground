namespace Padial.Playground.Records.Immutability;

internal record Worker(string Name, byte Age) : Person(Name, Age);

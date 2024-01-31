namespace Padial.Playground.Records.Immutability;
internal class ImmutabilityService
{
    public static void CheckImmutability()
    {
        var worker = new Worker("John", 28);
        Console.WriteLine($"{worker.Name} is {worker.Age} years old");

        var newWorker = worker with { Age = 32 };
        Console.WriteLine($"{newWorker.Name} now is {newWorker.Age} years old");
    }
}

using ClownConsole;

IClown fingersTheClown = new ScaryScary("big red nose", 14);
IClown.CarCapacity = 18;
Console.WriteLine(IClown.ClownCardDescription());
fingersTheClown.Honk();
if (fingersTheClown is IScaryClown iScaryClownReference)
{
    iScaryClownReference.ScareAdults();
}


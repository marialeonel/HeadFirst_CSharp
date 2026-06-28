using HippoAndWolf;

Animal[] animals =
{
    new Wolf(false),
    new Hippo(),
    new Wolf(true),
    new Wolf(false),
    new Hippo()
};

foreach (Animal animal in animals)
{
    animal.MakeNoise();
    if(animal is Hippo hippo)
    {
        hippo.Swim();
    } else if(animal is Wolf wolf)
    {
        wolf.HuntInPack();
    }

    Console.WriteLine();
}

Console.WriteLine("Hello, World!");

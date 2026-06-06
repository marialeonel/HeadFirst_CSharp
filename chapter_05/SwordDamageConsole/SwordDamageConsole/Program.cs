using SwordDamageConsole;

Random random = new Random();
SwordDamage swordDamage = new SwordDamage(calc3D6());

while (true)
{
    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                    "3 for both, anything else to quit: ");
    char key = Console.ReadKey().KeyChar;
    if (key != '0' && key != '1' && key != '2' && key != '3') return;
    swordDamage.Roll = calc3D6();
    swordDamage.Magic = (key == '1' || key == '3');
    swordDamage.Flaming = (key == '2' || key == '3');
    Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
}


int calc3D6()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}



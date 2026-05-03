using SwordDamageConsole;

SwordDamage swordDamage = new SwordDamage();
Random random = new Random();

while(true)
{
    Console.WriteLine("0 for normal (no magic/flaming), 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    char pressedKey = Console.ReadKey(false).KeyChar;

    if (pressedKey != '0' && pressedKey != '1' && pressedKey != '2' && pressedKey != '3') return;

    swordDamage.Roll = calc3D6();

    swordDamage.SetMagic(pressedKey == '1' || pressedKey == '3');
    swordDamage.SetFlaming(pressedKey == '2' || pressedKey == '3');
    Console.WriteLine($"\n\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP.");
}


int calc3D6()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}



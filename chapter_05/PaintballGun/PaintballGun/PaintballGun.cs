using System;

namespace PaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o número de bolas e o tamanho do carregador
            Console.Write("Digite o número de bolas : ");
            int ammoCount = int.TryParse(Console.ReadLine(), out int ammoInput) ? ammoInput : 20;

            Console.Write("Digite o tamanho do carregador : ");
            int magazineSize = int.TryParse(Console.ReadLine(), out int magazineInput) ? magazineInput : 16;

            Console.Write("A arma está carregada inicialmente? (true/false) [false]: ");
            bool isLoaded = bool.TryParse(Console.ReadLine(), out bool loadedInput) && loadedInput;

            // Cria uma instância da arma de paintball
            var gun = new PaintballGun(ammoCount, magazineSize, isLoaded);

            // Loop principal do jogo
            while (true)
            {
                Console.WriteLine($"\n{gun.Balls} bolas restantes, {gun.BallsLoaded} carregadas");
                if (gun.IsEmpty())
                    Console.WriteLine("AVISO: Você está sem munição!");

                Console.WriteLine("\nPressione:");
                Console.WriteLine("  Espaço para atirar");
                Console.WriteLine("  R para recarregar");
                Console.WriteLine("  + para adicionar munição");
                Console.WriteLine("  Q para sair");

                char keyPressed = Console.ReadKey(true).KeyChar;

                switch (keyPressed)
                {
                    case ' ':
                        bool shotFired = gun.Shoot();
                        Console.WriteLine($"Tiro disparado! Sucesso: {shotFired}");
                        break;

                    case 'r':
                        gun.Reload();
                        Console.WriteLine("Arma recarregada!");
                        break;

                    case '+':
                        Console.Write("Digite quantas bolas adicionar: ");
                        if (int.TryParse(Console.ReadLine(), out int additionalBalls))
                        {
                            gun.Balls += additionalBalls;
                            Console.WriteLine($"Total de bolas agora: {gun.Balls}");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                        }
                        break;

                    case 'q':
                    case 'Q':
                        Console.WriteLine("Saindo do programa...");
                        return;
                }
            }
        }
    }
}

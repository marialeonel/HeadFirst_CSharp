using System;

namespace PaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita e lê o número de bolas de paintball e o tamanho do carregador
            int ammoCount = GetUserInput(20, "Número de bolas");
            int magazineCapacity = GetUserInput(16, "Tamanho do carregador");

            // Pergunta se a arma está carregada inicialmente
            Console.Write("Arma carregada? (true/false): ");
            bool isLoaded = bool.TryParse(Console.ReadLine(), out bool loaded) && loaded;

            // Cria uma instância da arma de paintball
            var gun = new PaintballGun(ammoCount, magazineCapacity, isLoaded);

            // Loop principal do jogo
            while (true)
            {
                DisplayGunStatus(gun);
                HandleUserInput(gun);
            }
        }

        /// <summary>
        /// Exibe o status atual da arma (quantidade de bolas restantes e carregadas).
        /// </summary>
        static void DisplayGunStatus(PaintballGun gun)
        {
            Console.WriteLine($"{gun.AmmoCount} bolas restantes, {gun.LoadedBalls} carregadas");
            if (gun.IsEmpty())
                Console.WriteLine("AVISO: Você está sem munição!");
            Console.WriteLine("Pressione: Espaço para atirar, R para recarregar, + para adicionar munição, Q para sair");
        }

        /// <summary>
        /// Lê a entrada do usuário e realiza a ação correspondente.
        /// </summary>
        static void HandleUserInput(PaintballGun gun)
        {
            char keyPressed = Console.ReadKey(true).KeyChar;

            switch (keyPressed)
            {
                case ' ':
                    Console.WriteLine($"Tiro disparado. Resultado: {gun.Shoot()}");
                    break;
                case 'r':
                    gun.Reload();
                    break;
                case '+':
                    gun.AmmoCount += gun.MagazineCapacity;
                    break;
                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// Solicita ao usuário um valor inteiro e retorna o valor lido ou um valor padrão.
        /// </summary>
        static int GetUserInput(int defaultValue, string prompt)
        {
            Console.Write($"{prompt} [{defaultValue}]: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int value))
            {
                Console.WriteLine($"Usando valor: {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"Usando valor padrão: {defaultValue}");
                return defaultValue;
            }
        }
    }
}

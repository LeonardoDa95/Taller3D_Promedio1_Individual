using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal class Menu
    {
        public void Execute()
        {
            Console.WriteLine("Bienvenido a la aventura de detectives");
            Console.Write("Introduce el nombre de tu detective: ");
            string playerName = Console.ReadLine();

            Player mainPlayer = new Player(playerName);

            List<Situation> gameSituations = new List<Situation>
            {
                new FirstSituation(),
                new SecondSituation(),
                new ThirdSituation()
            };

            bool isPlaying = true;

            while (isPlaying)
            {
                mainPlayer.Health = 100;
                mainPlayer.Morality = 0;

                bool survived = PlayThroughSituations(gameSituations, mainPlayer);

                if (!survived)
                {
                    Console.WriteLine("Te has quedado sin vida");
                    Console.WriteLine("El caso ha quedado sin resolver...");
                    Console.Write("¿Quieres volver a intentar? (si o no): ");

                    string retry = Console.ReadLine();
                    if (retry.ToLower() != "si")
                    {
                        isPlaying = false;
                    }
                }
                else
                {
                    EvaluateEnding(mainPlayer);
                    isPlaying = false;
                }
            }
        }

        private bool PlayThroughSituations(List<Situation> situations, Player player)
        {
            foreach (Situation situation in situations)
            {
                Console.Clear();
                Console.WriteLine($"Vida: {player.Health} | Moral: {player.Morality} ");

                situation.Execute(player);

                if (player.Health <= 0)
                {
                    return false;
                }

            }
            return true;
        }

        private void EvaluateEnding(Player player)
        {
            Console.Clear();
            Console.WriteLine("Resultado");
            Console.WriteLine($"Detective: {player.Name} | Vida Restante: {player.Health} | Puntuación Moral: {player.Morality}");

            if (player.Morality == 3)
            {
                Console.WriteLine("FINAL BUENO: Eres un detective impecable. El líder está en la cárcel y el caso se cerró limpiamente.");
            }
            else if (player.Morality == 1 || player.Morality == 2)
            {
                Console.WriteLine("FINAL NEUTRAL: Resolviste el caso y sobreviviste, pero tus métodos poco ortodoxos dejaron dudas en el departamento de policía.");
            }
            else
            {
                Console.WriteLine("FINAL MALO: Todo salió terriblemente mal. El criminal escapó o tomaste el camino más oscuro. La ciudad no está a salvo.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal class FirstSituation : Situation
    {
        public override void Execute(Player player)
        {
            Console.WriteLine("Situacion 1: Escena del crimen");
            Console.WriteLine("Entras al almacen y encuentras un sutil rastro de quimico en la cerradura, sin embargo escuchas un ruido acercandoce.");
            Console.WriteLine("1. Usar kit forense para analizar y neutralizar la sustacia (toma tiempo).");
            Console.WriteLine("2. Forzar la cerradura rapidamente.");
            Console.WriteLine("¿Que decides hacer? (1 o 2");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Console.WriteLine("La sustancia resulto ser una trampa acida, recuperaste evidencia intacta.");
                Console.WriteLine("Sin embargo te encontraste cara a cara con una persona sospechoza que te confronta, pero lo abates con un poco de dificultad");
                player.Morality += 1;
                player.Health -= 10;
            }
            else
            {
                Console.WriteLine("Logras entrar rapidamente al almacen.");
                Console.WriteLine("Sin embargo la sustancia de la cerradura resulto ser acida por lo que quemaste.");
                player.Health -= 30;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal class SecondSituation : Situation
    {
        public override void Execute(Player player)
        {
            Console.WriteLine("Situacion 2: Emboscada");
            Console.WriteLine("Mientras revisavas el almacen logras ver una pasillo oscuro.");
            Console.WriteLine("1. Usar una granada cegadora para incapacitarlos sin usar fuerza letal.");
            Console.WriteLine("2. Desenfundar y neutralizarlos rápidamente con disparos certeros.");
            Console.WriteLine("¿Que decides hacer? (1 o 2");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Console.WriteLine("Los matones caen aturdidos.");
                Console.WriteLine("Revisando a los matones encuentras notas que ayudan enormemente a tu investigacion");
                player.Morality += 1;
            }
            else
            {
                Console.WriteLine("Abates a ambos objetivos, pero uno logra acertar algunos golpes contra ti.");
                Console.WriteLine("El ruido llama la atencion y tienes que uir rapido del lugar sin poder obtener toda la informacion clara.");
                player.Health -= 30;
            }

        }
    }
}

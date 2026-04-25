using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal class ThirdSituation : Situation
    {
        public override void Execute(Player player)
        {
            Console.WriteLine("Situacion 3: Lider criminal");
            Console.WriteLine("Acorralas al líder del sindicato criminal en la azotea. El criminal arroja su arma y levanta las manos.");
            Console.WriteLine("1. Arrestarlo y asegurar que enfrente la justicia en los tribunales.");
            Console.WriteLine("2. Empujarlo al vacío y terminar con el problema de raíz."); 
            Console.WriteLine("¿Que decides hacer? (1 o 2");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Console.WriteLine("Con toda la evidencia que obtuviste sabes que el lider criminal no lograra salir nunca de la carcel.");
                Console.WriteLine("Le pones las esposas. El caso se ha resuelto");
                player.Morality += 1;
            }
            else
            {
                Console.WriteLine("Sabes que no tienes las pruebas suficientes para poder mantenerlo tras las rejas.");
                Console.WriteLine("Observas como el criminal queda tendido en el suelo.");
            }

        }
    }
}


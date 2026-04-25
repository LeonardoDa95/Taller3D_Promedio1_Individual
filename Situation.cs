using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal abstract class Situation
    {
        public string SituationName { get; set; }

        public abstract void Execute(Player player);
    }
}

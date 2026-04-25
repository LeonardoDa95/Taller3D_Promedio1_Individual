using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Promedio1_Individual
{
    internal class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Morality { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Morality = 0;
        }

        public void ResetStats()
        {
            Health = 100;
            Morality = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class GiantGrowSpell : ISpell
    {

        private string _victim;

        public GiantGrowSpell(string victim)
        {
            _victim = victim;
        }

        public void DesEnchant()
        {
            string line = string.Format("Shrinking {0} to his/her normale size", _victim);
            Console.WriteLine(line);
        }

        public void Enchant()
        {
            string line = string.Format("Making {0} gigantic", _victim);
            Console.WriteLine(line);
        }
    }
}

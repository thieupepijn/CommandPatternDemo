using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    public class StoneSpell : ISpell
    {

        private string _victim;

        public StoneSpell(string victim)
        {
            _victim = victim;
        }

        public void DesEnchant()
        {
            string line = string.Format("Unstoning {0}", _victim);
            Console.WriteLine(line);
        }

        public void Enchant()
        {
            string line = string.Format("Turning {0} to stone", _victim);
            Console.WriteLine(line);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    public class GreenSpell : ISpell
    {
        private string _victim;

        public GreenSpell(string victim)
        {
            _victim = victim;
        }

        public void DesEnchant()
        {
            string line = string.Format("Turning {0} to his/her normal color.", _victim);
            Console.WriteLine(line);
        }

        public void Enchant()
        {
            string line = string.Format("Turning {0} green.", _victim);
            Console.WriteLine(line);
        }
    }
}

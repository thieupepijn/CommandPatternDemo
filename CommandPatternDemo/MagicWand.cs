using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    public class MagicWand
    {
        private List<ISpell> _spells;
        private Stack<ISpell> _performedSpells;
        private Random _random;

        public MagicWand()
        {
            _spells = new List<ISpell>();
            _performedSpells = new Stack<ISpell>();
            _random = new Random();
        }

        public void AddSpell(ISpell spell)
        {
            _spells.Add(spell);
        }

        public void WaveLeft()
        {
            ISpell randomSpell = RandomSpell();
            randomSpell.Enchant();
            _performedSpells.Push(randomSpell);
            _spells.Remove(randomSpell);
        }

        public void WaveRight()
        {
            ISpell lastPerformedSpell = _performedSpells.Pop();
            if (lastPerformedSpell != null)
            {
                lastPerformedSpell.DesEnchant();
            }
            else
            {
                //do nothing 
            }
        }

        private ISpell RandomSpell()
        {
            if (_spells.Count > 0)
            {
                int randomNumber = _random.Next(_spells.Count);
                return _spells[randomNumber];
            }
            else
            {
                return null;
            }
        }




    }
}

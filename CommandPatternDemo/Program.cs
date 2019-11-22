using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISpell> spells = MakeMagicSpells();
            MagicWand magicWand = new MagicWand();
            spells.ForEach(s => magicWand.AddSpell(s));
            PerfomMainLoop(magicWand); 
        }


        private static List<ISpell> MakeMagicSpells()
        {
            List<ISpell> spells = new List<ISpell>();
            List<string> persons = new List<string> { "Timmy", "Maria", "Becky", "Victor", "Jozef", "Bea", "Ria" };

            foreach(string person in persons)
            {
                GiantGrowSpell growSpell = new GiantGrowSpell(person);
                StoneSpell stoneSpell = new StoneSpell(person);
                spells.Add(growSpell);
                spells.Add(stoneSpell);
            }
            return spells;
        }


        private static void PerfomMainLoop(MagicWand magicWand)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Wave your magic wand left or right: ");
                char typedChar = Console.ReadKey().KeyChar;

                if ((typedChar == 'E') || (typedChar == 'e'))
                {
                    return;
                }
                else if ((typedChar == 'L') || (typedChar == 'l'))
                {
                    Console.WriteLine();
                    magicWand.WaveLeft();
                }
                else if ((typedChar == 'R') || (typedChar == 'r'))
                {
                    Console.WriteLine();
                    magicWand.WaveRight();
                }

                else
                {
                    Console.WriteLine();
                }
            }
        }

    }
}

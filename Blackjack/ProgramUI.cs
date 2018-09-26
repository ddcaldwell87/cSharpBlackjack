using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class ProgramUI
    {
        private readonly int[] cards = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        private Random random = new Random();

        public void Run()
        {
            DisplayTitle();

            DrawCards();
        }

        private void DisplayTitle()
        {
            Console.WriteLine(@"
          _____
         |A .  | _____
         | /.\ ||A ^  | _____
         |(_._)|| / \ ||A _  | _____
         |  |  || \ / || ( ) ||A_ _ |
         |____V||  .  ||(_'_)||( v )|
                |____V||  |  || \ / |
                       |____V||  .  |
                              |____V|

 _     _            _    _            _    
| |   | |          | |  (_)          | |   
| |__ | | __ _  ___| | ___  __ _  ___| | __
| '_ \| |/ _` |/ __| |/ / |/ _` |/ __| |/ /
| |_) | | (_| | (__|   <| | (_| | (__|   < 
|_.__/|_|\__,_|\___|_|\_\ |\__,_|\___|_|\_\
                       _/ |                
                      |__/                 
");
        }

        private void DrawCards()
        {
            int card1 = random.Next(0, cards.Length);
            int card2 = random.Next(0, cards.Length);

            int handValue = card1 + card2;

            DisplayValue(handValue);
        }

        private void DisplayValue(int handValue)
        {
            Console.WriteLine("Your hands value is: " + handValue);

            MenuOptions();

            PlayHand(handValue);
        }

        private void MenuOptions()
        {
            Console.WriteLine($"Hit?\n" +
                $"1. Yes\n" +
                $"2. No");
        }

        private void PlayHand(int handValue)
        {
            int hit = int.Parse(Console.ReadLine());
            int hitHandValue = 0;

            if (hit == 1)
            {
                hitHandValue = handValue += random.Next(0, cards.Length);
                Console.WriteLine("Your new value is: " + hitHandValue);
                MenuOptions();
            }
        }
    }
}

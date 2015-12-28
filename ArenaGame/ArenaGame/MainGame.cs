using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArenaGame
{
    class MainGame
    {
        static public void Game()
        {
            //Global variables
            //Player
            //None at this time

            //Opponent
            //None at this time

            //Character Creation
            Player player = new Player();
            player.CharacterCreation();
        }

        public static char GetUserInputChar()
        {
            char chAction;
            Console.WriteLine("Enter your choice: ");
            chAction = (char)Console.Read();
            chAction = char.ToUpper(chAction);
            return chAction;
        }

        public static int DecisionDieRoller()
        {
            int dec;
            Thread.Sleep(7);
            Random randDecisionDie = new Random((Int32)DateTime.Now.Ticks);
            dec = randDecisionDie.Next(20);
            dec++;
            return dec;
        }

        public static int WeaponDieRoller(int dieType, int numOfDie, int weaponBonus)
        {
            int damage = 0;
            switch (dieType)
            {
                case 4:
                    Random randD4 = new Random();
                    for (int i = 0; i < numOfDie; i++)
                        damage += randD4.Next(4) + 1;
                    damage += weaponBonus;
                    break;
                case 6:
                    Random randD6 = new Random();
                    for (int i = 0; i < numOfDie; i++)
                        damage += randD6.Next(6) + 1;
                    damage += weaponBonus;
                    break;
                case 8:
                    Random randD8 = new Random();
                    for (int i = 0; i < numOfDie; i++)
                        damage += randD8.Next(8) + 1;
                    damage += weaponBonus;
                    break;
                case 10:
                    Random randD10 = new Random();
                    for (int i = 0; i < numOfDie; i++)
                        damage += randD10.Next(10) + 1;
                    damage += weaponBonus;
                    break;
                case 12:
                    Random randD12 = new Random();
                    for (int i = 0; i < numOfDie; i++)
                        damage += randD12.Next(12) + 1;
                    damage += weaponBonus;
                    break;
                case 100:
                    Random randPCT = new Random();
                    damage += randPCT.Next(100) + 1;
                    damage += weaponBonus;
                    break;
            }
            return damage;
        }

        public static void Combat()
        {

        }
    }
}

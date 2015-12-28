using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Player
    {
        //Player variables
        static string strPlayerName;
        static int intDifficulty;
        static int intPlayerHealth;
        static int intWeaponDecider;
        static int intInitiative;
        static bool isPlayer = true;

        //Public Properties
        public string playerNameStr
        { get { return strPlayerName; } set { } }

        public int playerDifficultyInt
        { get { return intDifficulty; } set { } }

        public int playerHealthInt
        { get { return intPlayerHealth; } set { } }

        public int weaponDeciderInt
        { get {return intWeaponDecider;} set { } }

        public int playerInitiativeInt
        {  get { return intInitiative; } set { } }

        public bool isPlayerBool
        { get { return isPlayer; } set { } }

        //child objects
        Weapon playerWeapon = new Weapon();

        //Function to gather player information from user
        public void CharacterCreation()
        {
            GetPlayerName();
            SetDifficulty();
            GetPlayerHealth(playerDifficultyInt);
            playerWeapon.WeaponDefinition(playerDifficultyInt, isPlayer);
        }

        static string GetPlayerName()
        {
            string strName;
            Console.WriteLine("Name?: ");
            strName = Console.ReadLine();
            strPlayerName = strName;
            return strName;
        }

        static int SetDifficulty()
        {
            int intDiff = 0;
            char charDiff;
            bool getInput;

            do
            {
                getInput = false;
                Console.WriteLine("Choose your difficulty level:");
                Console.WriteLine("(E)asy");
                Console.WriteLine("(N)ormal");
                Console.WriteLine("(H)ard");
                Console.WriteLine("(S)uperhuman");
                charDiff = MainGame.GetUserInputChar();
                switch (charDiff)
                {
                    case 'E':
                        intDiff = 0;
                        break;
                    case 'N':
                        intDiff = 1;
                        break;
                    case 'H':
                        intDiff = 2;
                        break;
                    case 'S':
                        intDiff = 3;
                        break;
                    default:
                        Console.WriteLine("Please Try Again: ");
                        getInput = true;
                        break;
                }
            } while (getInput);
            intDifficulty = intDiff;
            return intDiff;      

        }

        static int GetPlayerHealth(int diff)
        {
            int intHealth = 100;
            double dblHealth = Convert.ToDouble(intHealth);
            
            switch (diff)
            {
                case 0:
                    dblHealth *= 1.5d;
                    break;
                case 1:
                    dblHealth *= 1.25d;
                    break;
                case 2:
                    dblHealth *= 1.1d;
                    break;
                case 3:
                    dblHealth *= 1.0d;
                    break;
            }
            intHealth = (int)Math.Round(dblHealth);
            intPlayerHealth = intHealth;

            return intHealth;
        }
    }
}

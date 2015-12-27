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

        //Public Properties
        public string playerName
        { get { return strPlayerName; } set { } }

        public int playerDifficulty
        { get { return intDifficulty; } set { } }

        public int playerHealth
        { get { return intPlayerHealth; } set { } }

        public int weaponDecider
        { get {return intWeaponDecider;} set { } }

        public int playerInitiative
        {  get { return intInitiative; } set { } }

        //Function to gather player information from user
        public string CharacterCreation()
        {
            GetPlayerName();
            SetDifficulty();
            GetPlayerHealth(playerDifficulty);
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

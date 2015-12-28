using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Weapon
    {
        //Weapon class variables
        int intWeaponDie;
        int intWeaponBonus;
        int intNumWeaponDie = 1;
        int intWeaponDecider;

        string strWeaponType;

        //Create public properties
        public int weaponDieInt
        { get { return intWeaponDie; } set { } }
        public int weaponBonusInt
        { get { return intWeaponBonus; } set { } }
        public int numWeaponDieInt
        { get { return intNumWeaponDie; } set { } }
        public int weaponDeciderInt
        { get { return intWeaponDecider; } set { } }

        public int CheckforWeaponType(int diff, bool isPlayer)
        {
            int dec;
            dec = MainGame.DecisionDieRoller();

            if (isPlayer == true)
            {
                switch (diff)
                {
                    case 0:
                        dec += 10;
                        break;
                    case 1:
                        dec += 5;
                        break;
                    case 2:
                        dec += 0;
                        break;
                    case 3:
                        dec -= 2;
                        break;
                }
            }

            else if (isPlayer == false)
            {
                switch (diff)
                {
                    case 0:
                        dec -= 10;
                        break;
                    case 1:
                        dec -= 5;
                        break;
                    case 2:
                        dec += 0;
                        break;
                    case 3:
                        dec += 5;
                        break;
                }
            }

            intWeaponDecider = dec;
            return dec;
        }

        void AssignWeaponType(int dec)
        {
            if (dec < 5)
            {
                strWeaponType = "Unarmed";
                intWeaponDie = 4;
            }

            else if (dec > 4 && dec < 7 )
            {
                strWeaponType = "Short Sword";
                intWeaponDie = 6;
            }
            else if (dec > 6 && dec < 12)
            {
                strWeaponType = "Sword";
                intWeaponDie = 8;
            }
            else if (dec > 11 && dec < 19)
            {
                strWeaponType = "Axe";
                intWeaponDie = 10;
            }
            else if (dec > 18)
            {
                strWeaponType = "Warhammer";
                intWeaponDie = 12;
            }
        }

        void AssignWeaponBonus()
        {
            int getBonus;

            getBonus = MainGame.DecisionDieRoller();

            if (getBonus > 15)
                intWeaponBonus = MainGame.WeaponDieRoller(4, 1, 0);
        }

        public void WeaponDefinition(int diff, bool isPlayer)
        {
            CheckforWeaponType(diff, isPlayer);
            AssignWeaponType(weaponDeciderInt);
            AssignWeaponBonus();
        }
    }
}

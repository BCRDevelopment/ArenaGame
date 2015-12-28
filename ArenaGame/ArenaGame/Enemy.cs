using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Enemy
    {
        static string strEnemyName;
        static int intEnemyHealth;
        static int intWeaponDecider;
        static int intInitiative;
        static bool isPlayer = false;

        //Properties
        public string enemyNameStr
        { get { return strEnemyName; } set { } }
        public int enemyHealthInt
        { get { return intEnemyHealth; } set { } }
        public int weaponDeciderInt
        { get { return intWeaponDecider; } set { } }
        public int enemyInititativeInt
        { get { return intInitiative; } set { } }
        public bool isPlayerBool
        { get { return isPlayer; } set { } }

        //Child objects
        Weapon enemyWeapon = new Weapon();

        string SetEnemyName()
        {
            string strName;
            strName = "Bubbles";
            return strName;
        }
    }
}

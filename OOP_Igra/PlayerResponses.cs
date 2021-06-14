using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    //this class exists only to output text 
    class PlayerResponses
    {
        public static void BattleWon()
        {
            Console.WriteLine("I WON!");
        }
        public static void BattleLost()
        {
            Console.WriteLine("I Lost!");
        }
        public static void BattleAlmostLost()
        {
            Console.WriteLine("I WON ----------- hehe!");
        }
        public static void BattleAlmostWon()
        {
            Console.WriteLine("So close!");
        }
        public static void MeetingAnEnemy()
        {
            Console.WriteLine("?");
        }
        public static void MeetingAnAlly()
        {
            Console.WriteLine("!");
        }

        //add more as required


    }
}

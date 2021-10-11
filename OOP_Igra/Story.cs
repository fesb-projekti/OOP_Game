using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    //this class exists only to output text about the story
    class Story
    {
        public  static void Intro()
        {
            Console.WriteLine("#===============================================#");
            Console.WriteLine("#==============  Dungeon Crawler  ==============#");
            Console.WriteLine("#===============================================#");
            Console.WriteLine("#                                               #");
            Console.WriteLine("#============       CONTROLS       =============#");
            Console.WriteLine("#                                               #");
            Console.WriteLine("#  Move Up - W                    Move Down - S #");
            Console.WriteLine("#  Move Left - A                 Move Right - D #");
            Console.WriteLine("#  Menu - M                       Inventory - I #");
            Console.WriteLine("#                                               #");
            Console.WriteLine("#============       BRIEFING       =============#");
            Console.WriteLine("#                                               #");
            Console.WriteLine("#              Write info and plot              #");
            Console.WriteLine("#                                               #");
            Console.WriteLine("#===============================================#");
            Console.WriteLine("#================  Good luck !  ================#");
            Console.WriteLine("#===============================================#");
        }

        //add aditional story hooks as required
    }
}

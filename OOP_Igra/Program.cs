using System;
using System.Collections.Generic;

namespace OOP_Igra
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //make map
            MapGenerator.InitializeMap(GameVariables.map);
            //make player           
            Player player1 = new Player();
            //make 3 event objects, each represents one priority level
            List<Events> events = new List<Events>();
            events.Add(new Events());
            events.Add(new Events());
            events.Add(new Events());

            //show intro and wait for keypress
            Story.Intro();
            Console.ReadKey(true);

            //game loop
            while(player1.hp > 0)
            {
                //Console.Clear();
                
                Display.ShowMap(); //comment when Display.ShowCharacterView() is done
                //Display.ShowCharacterView(player1); // uncomment when done
                Display.ShowCharacterMenu(player1);

                if(player1.Input()) continue;

                //activate all events that are triggered because player moved
                foreach(Events e in events)
                {
                    e.Activate();
                }
            }
        }
    }
}

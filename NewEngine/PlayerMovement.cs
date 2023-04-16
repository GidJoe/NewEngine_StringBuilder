using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEngine
{
    
    internal class PlayerMovement
    {
        public static int posPlayerX = 5;
        public static int posPlayerY = 5;

        public int test1, test2;






        public char player()
        {
            char player = 'o';
            return player;
        }

        public void positionplayer()
        {


            MapBuilder.mainmap[1, 5] = player();
        }





        public static void movement()
        {
            Console.SetCursorPosition(0, 0);
            ConsoleKey key1 = Console.ReadKey(true).Key;

            if (key1 == ConsoleKey.W)
            {
                
                posPlayerX--;
                
            } else if (key1 == ConsoleKey.S)
            {
                posPlayerX++;
            } else if (key1 == ConsoleKey.A)
            {
                posPlayerY--;
            }
            else if (key1 == ConsoleKey.D)
            {
                posPlayerY++;
            }
        }
    }



}

            
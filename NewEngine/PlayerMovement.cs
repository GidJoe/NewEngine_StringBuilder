using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEngine
{
    
    internal class PlayerMovement
    {
        public static int posPlayerX = 18;
        public static int posPlayerY = 18;
        public static string checker = "";
        private bool canMove;



        
        public char player()
        {
            char player = 'o';
            return player;
        }

        public void positionplayer()
        {


            Maps.mainmap[1, 5] = player();
        }

        //bool und string
        public static bool nextPositionChecker(string whatToCheck)
        {
            Map2 anewmap = new Map2();
            switch (whatToCheck)
            {
                case "up":
                    if (anewmap.mainmap[PlayerMovement.posPlayerX - 1, PlayerMovement.posPlayerY] == ' ')
                    {
                        return true;

                    }

                    break;
                case "down":
                    if (anewmap.mainmap[PlayerMovement.posPlayerX + 1, PlayerMovement.posPlayerY] == ' ')
                    {
                        return true;

                    }
                    break;
                case "left":
                    if (anewmap.mainmap[PlayerMovement.posPlayerX, PlayerMovement.posPlayerY + 1] == ' ')
                    {
                        return true;

                    }
                    break;
                case "right":
                    if (anewmap.mainmap[PlayerMovement.posPlayerX, PlayerMovement.posPlayerY - 1] == ' ')
                    {
                        return true;

                    }
                    break;
                default:
                    return false;


            }

            return false;
        }





        public static void movement()
        {
            //Console.SetCursorPosition(0, 0);
            ConsoleKey keyinput = Console.ReadKey(true).Key;

            if (keyinput == ConsoleKey.W)
            {
                if (nextPositionChecker("up") == true)
                {
                    posPlayerX--;
                }
                else
                {
                    //do nothing
                }

            } else if (keyinput == ConsoleKey.S)
            {
                if (nextPositionChecker("down") == true)
                {
                    posPlayerX++;
                
                }
                else
                {
                    //do nothing
                }
            } else if (keyinput == ConsoleKey.A)
            {
                if (nextPositionChecker("right") == true)
                {
                    posPlayerY--;
                }
                else
                {
                    //do nothing
                }
            }
            else if (keyinput == ConsoleKey.D)
            {
                if (nextPositionChecker("left") == true)
                {
                    posPlayerY++;
                    

                }
                else
                {
                    //do nothing
                }
            }
        }
    }



}

            
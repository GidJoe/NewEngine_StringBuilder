using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace NewEngine
{


    internal class Program
    {
        private static string input;


        private static void StartKeyboardListener()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    ConsoleKeyInfo key = System.Console.ReadKey();
                    Console.CursorVisible = false;
                    PlayerMovement.movement();
                }



            });
                

        thread.IsBackground = true;
            thread.Start();
        }

        static void Main(string[] args)
        {
            while (true)
            {


                ConsoleKey key1 = Console.ReadKey(true).Key;
                if (key1 == ConsoleKey.W)
                {

                    PlayerMovement.posPlayerX--;
                    Map();

                }
                else if (key1 == ConsoleKey.S)
                {
                    PlayerMovement.posPlayerX++;
                    Map();
                }
                else if (key1 == ConsoleKey.A)
                {
                    PlayerMovement.posPlayerY--;
                    Map();
                }
                else if (key1 == ConsoleKey.D)
                {
                    PlayerMovement.posPlayerY++;
                    Map();
                }
                //StartKeyboardListener();

            }
        }



        public static void Map()
        {
            
                Console.CursorVisible = false;

                MapBuilder.mainmap[PlayerMovement.posPlayerX, PlayerMovement.posPlayerY] = '#';

                var sb = new StringBuilder(string.Empty);
                var maxI = MapBuilder.mainmap.GetLength(0);
                var maxJ = MapBuilder.mainmap.GetLength(1);
                for (var i = 0; i < maxI; i++)
                {
                    sb.Append("");
                    for (var j = 0; j < maxJ; j++)
                    {
                        sb.Append(MapBuilder.mainmap[i, j]);
                    }

                    sb.Append("\n");
                }

                var result = sb.ToString();
                Console.SetCursorPosition(0, 0);

                Console.Write(result);
                
        }
    }
}

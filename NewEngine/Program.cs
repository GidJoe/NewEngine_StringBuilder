using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace NewEngine
{


    internal class Program
    {
        
        private static string input;
        

        static void Main(string[] args)
        {
           StartGame();

        }


        private static void StartGame()
        {
            PlayerMovement.movement();
            startEngine();
        }



        public static void startEngine()
        {
            Console.CursorVisible = false;

            Map2 mymap = new Map2();
            mymap.mainmap[PlayerMovement.posPlayerX, PlayerMovement.posPlayerY] = 'W';




            var sb = new StringBuilder(string.Empty);
            var maxI = mymap.mainmap.GetLength(0);
            var maxJ = mymap.mainmap.GetLength(1);
            for (var i = 0; i < maxI; i++)
            {
                sb.Append("");
                for (var j = 0; j < maxJ; j++)
                {
                    sb.Append(mymap.mainmap[i, j]);
                }

                sb.Append("\n");
            }



            var result = sb.ToString();
            Console.SetCursorPosition(0, 0);
            Console.Write(result);
            Console.WriteLine("Position Y " + PlayerMovement.posPlayerX);
            Console.WriteLine("Position X " + PlayerMovement.posPlayerY);

            StartGame();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeMars
{
    class DirectionOfTheRobots
    {
        private char dir1, dir2;

        public char Dir1 { get => dir1; set => dir1 = value; }
        public char Dir2 { get => dir2; set => dir2 = value; }

        public static implicit operator string(DirectionOfTheRobots v)
        {
            throw new NotImplementedException();
        }

        public void specifyRobotsDirection(int x, int y, char dir)
        {
            do
            {
                Console.WriteLine("Robotun gideceği yönü ( W, E, S, N ) büyük harf ile giriniz : ");
                dir = char.Parse(Console.ReadLine());
                Console.WriteLine("Robot marsın (" + x + ", " + y + ", " + dir + ") noktasına konumlandırılmıştır...");
            } while (dir != 'N' && dir != 'S' && dir != 'E' && dir != 'W');
        }

    }
}

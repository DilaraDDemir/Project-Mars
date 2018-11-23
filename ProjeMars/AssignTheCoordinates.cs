using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeMars
{
    class AssignTheCoordinates
    {
        public int x1, y1, x2, y2, sx, sy;

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public int Sx { get => sx; set => sx = value; }
        public int Sy { get => sy; set => sy = value; }

        public void getRobotsCoordinates(int x, int y)
        {
            Console.WriteLine("Robotun x konumunu giriniz : ");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Robotun y konumunu giriniz : ");
            y = Int32.Parse(Console.ReadLine());
        }

        public void getTopRightPointOfSurface(int x, int y)
        {
            Console.WriteLine("Yüzeyin sağ üst noktasını giriniz (x, y) : ");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
        }

    }
}

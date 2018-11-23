using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeMars
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, sx, sy;
            String  phrase1, phrase2;
            Char r1dir, r2dir, r1DirNew, r2DirNew;

            DirectionOfTheRobots dir = new DirectionOfTheRobots();
            r1dir = dir.Dir1;
            r2dir = dir.Dir2;

            AssignTheCoordinates coordinates = new AssignTheCoordinates();
            x1 = coordinates.X1;
            y1 = coordinates.Y1;
            x2 = coordinates.X2;
            y2 = coordinates.Y2;
            sx = coordinates.Sx;
            sy = coordinates.Sy;

            LetterPhrase myPhrase = new LetterPhrase();
            phrase1 = myPhrase.Phrase;
            phrase2 = myPhrase.Phrase;

            coordinates.getTopRightPointOfSurface(sx, sy);
            coordinates.getRobotsCoordinates(x1, y1);
            dir.specifyRobotsDirection(x1, y1, r1dir);
            myPhrase.drawRobotsWays(phrase1);

            coordinates.getRobotsCoordinates(x2, y2);
            dir.specifyRobotsDirection(x2, y2, r2dir);
            myPhrase.drawRobotsWays(phrase2);

        }
    }
}

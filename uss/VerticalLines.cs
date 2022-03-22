using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    internal class VerticalLines : Figure // Класс для создания вертикальных линий
    {
        public VerticalLines(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }     
    }
}

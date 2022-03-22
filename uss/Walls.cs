using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLines upLine = new HorizontalLines(0, mapWidth - 2, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, mapWidth - 2,mapHeight - 1, '+');
            VerticalLines leftLine = new VerticalLines(0,mapHeight - 1, 0, '+');
            VerticalLines rightLine = new VerticalLines(0, mapHeight - 1,mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine); 
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            } 
        }
    }
}

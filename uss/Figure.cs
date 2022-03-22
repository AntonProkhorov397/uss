using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    class Figure
    {
         protected List<Point> pList; // Создаем список точек для рамки
        public virtual void Draw() // Метод дроу перебирает каждую точку р из списка рЛист
        {
            foreach (Point p in pList) // перебор точек 
            {
                p.Draw(); // Создание точек
            }
        }
        internal bool IsHit(Figure figure) //Передаёт в качестве аргумента переменную 
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p)) //Если фигура касается с точкой из списка возвращается "true"
                    return true;         
            }
            return false;
        }
        private bool IsHit(Point point) // Проверяет касание стен и хвоста
        {
            foreach(var p in pList)
            {
                if(p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}

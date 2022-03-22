using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    internal class HorizontalLines : Figure // Чтобы не прописовать методы дроу и т.д. делаем наследие из класса Фигура 
    {
        public HorizontalLines(int xLeft, int xRight, int y, char sym) //  Конструктор предназначен для постраения горизонтальной линии
        {
            pList = new List<Point>(); // создаем список точек (горизонтальная линия) 
            for (int x = xLeft; x <= xRight; x++) // создам цикл фор для создания точного кол-ва точек
            {
                Point p = new Point(x, y, sym); // Задаем новую точку р с определенными параметрами, менятся будет только x
                pList.Add(p); // добавляем новую точку горизонт. линии в список pList

            }
        }
        public override void Draw() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;  
            
            base.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}

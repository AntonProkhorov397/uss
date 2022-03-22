using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    internal class Point // Класс поинт нужен для создания точек на экране
    {
        public int x;
        public int y;
        public char sym;

        public Point() // Рандомный Конструктор для точки
        {

        }
        public Point(int _x, int _y, char _sym) // Конструктор для точки (основной)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p) // Конструктор точки который запрашивает переменную
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction) // Задаем перемещение точек из класса "направления" 
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p) //метод для проверки столкновения разных точек
        {
            return p.x == this.x && p.y == this.y;    
        }
        public void Draw() //метод отрисовки точек
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear() // метод для стирания точек
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", "+ y +", " + sym;
        }
        
    }
}

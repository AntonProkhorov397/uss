 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    internal class Snake : Figure //Класс 'змейка' является наследником класса 'Figure'  
    {
        Direction direction; // Хранит данные, в каком напрвлении будет двигаться змейка в зависимости какую клавишу стрелки ты нажал
        public Snake(Point tail, int length, Direction  _direction)
        {
            direction = _direction; //Приравнивает переменную к данным direction 
            pList = new List<Point>();// Создает список точек, так как список точек это змейка
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()// Метод движения Змейки
        {
            Point tail = pList.First();// Первая точка списка (хвост)
            pList.Remove(tail);// Удалят первый индекс списка хвоста 
            Point head = GetNextPoint();// добавляет новую точку головы
            pList.Add(head);// добавляет новую точку в список

            tail.Clear(); 
            head.Draw();

        }
        public Point GetNextPoint()// Метод, добавляющий новую точку в конец списка 
        {
            Point head = pList.Last();// приравниваем точку к последнему индексу списка
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        internal bool IsHitTail()// Метод, при котором касание головы змейки означает конец игры
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[ i ]))
                    return true;  
            }
            return false;
        }
        public void HandleKey(ConsoleKey key) // Метод для назначения направления змейки через клавиши стрелок
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
        internal bool Eat(Point food) // Метод, который будет добавлять змейке еще одну точку при поедании предмета
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

    }
}

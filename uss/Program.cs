﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace uss
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.SetWindowSize(100, 35); // задает рамку для нашей игры (меньше значения не работают) 
            Walls walls = new Walls(100, 35); // Создает стены для змейки по размерам рамки (меньше значения не работают) 
            walls.Draw();

            Point p = new Point(4, 5, '卐');
            Snake snake = new Snake(p, 4, Direction.RIGHT); //При запуске игры змейка начинает движение вправо из указаной точки
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(100, 35, '$'); //Создание объекта еда с условиями длина,ширина карты и символ как еда будет выглядеть
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) //если змея врезается в стенку или хвост то программа прерывается
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100); //Задержка 100 милисекунд, можно поставить значения и меньше
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("GAME OVER!", xOffset + 10, yOffset++);
            yOffset++;
            WriteText("Developer: Anton Prokhorov", xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }                      
}

using System;
using static System.Net.Mime.MediaTypeNames;

namespace homework
{
    class translater
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            Console.CursorVisible = false;
            int[][] snake = new int[][]
            {
                new int[] { 42, 15 },
                new int[] { 41, 15 },
                new int[] { 40, 15 },
                new int[] { 39, 15 },
                new int[] { 38, 15 },
            };
            moveSnake(snake);
        }
        public static void moveSnake(int[][] snake)
        {
            int[] feedPoint = generateFeedPoint();
            char temp = 'd';
            while (true) {
                printSnake(snake, "*");
                if(findFeedPoint(snake, feedPoint))
                {
                    snake = growSnake(snake);
                    feedPoint = generateFeedPoint();
                }
                char c = Console.ReadKey(true).KeyChar;
                printSnake(snake, " ");
                switch (c)
                {
                    case 'w':
                        if(temp == 's')
                        {
                            break;
                        }
                        snake = updatePoints(snake);
                        snake[0][1] -= 1;
                        temp = c;
                        break;
                    case 'a':
                        if(temp == 'd')
                        {
                            break;
                        }
                        snake = updatePoints(snake);
                        snake[0][0] -= 1;
                        temp = c;
                        break;
                    case 's':
                        if(temp == 'w')
                        {
                            break;
                        }
                        snake = updatePoints(snake);
                        snake[0][1] += 1;
                        temp = c;
                        break;
                    case 'd':
                        if (temp == 'a')
                        {
                            break;
                        }
                        snake = updatePoints(snake);
                        snake[0][0] += 1;
                        temp = c;
                        break;
                }

                if (checkGameOver(snake))
                {
                    Console.SetCursorPosition(60, 25);
                    Console.WriteLine("Game Over...");
                    break;
                }
                printSnake(snake,"*");
            }

        }
        public static int[][] updatePoints(int[][] snake)
        {
            for (int i = snake.Count() - 1 ; i >= 1 ; i--)
            {
                snake[i][0] = snake[i - 1][0];
                snake[i][1] = snake[i - 1][1];
            }
            return snake;
        }
        public static int[][] growSnake(int[][] snake)
        {
            int lastIndex = snake.Count()-1;
            int newColl = snake[lastIndex][0] - snake[lastIndex-1][0] + snake[lastIndex][0];
            int newRow = snake[lastIndex][1] - snake[lastIndex - 1][1] + snake[lastIndex][1];
            int[][] newPoint = new int[][]
            {
                new int[] { newColl, newRow },
            };
            snake = snake.Concat(newPoint).ToArray();
            return snake;
         }
        public static int[] generateFeedPoint()
        {
            Random random = new Random();
            int rnd1 = random.Next(5, 145);
            int rnd2 = random.Next(3, 47);
            int[] feedPoint = { rnd1, rnd2 };
            Console.SetCursorPosition(rnd1, rnd2);
            Console.Write(".");
            return feedPoint; 
        }
        public static bool findFeedPoint(int[][] snake, int[] feedPoint)
        {
            if (snake[0][0] == feedPoint[0] && snake[0][1] == feedPoint[1])
            {
                return true;
            }
            return false;
        }
        public static void printSnake(int[][] snake, string text)
        {
            bool head = true;
            foreach (int[] snakePoint in snake)
            {
                Console.SetCursorPosition(snakePoint[0], snakePoint[1]);
                if (head == true && text != " ")
                {
                    Console.Write("O");
                    head = false;
                }
                else
                {
                    Console.Write(text);
                }
            }
        }

        public static bool checkGameOver(int[][] snake)
        { 
            for (int i = snake.Count() - 1; i >= 1; i--)
            {
                if ((snake[0][0] == snake[i][0] && snake[0][1] == snake[i][1]) || snake[0][0] == 0 || snake[0][0] == 150 || snake[0][1] == 0 || snake[0][1] == 50)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
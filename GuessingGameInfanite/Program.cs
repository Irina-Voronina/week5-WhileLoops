using System;

namespace GuessingGameInfanite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра "угадай номер"
            //Программа генерирует случайное число от 1 - 10
            //Программа предлагает пользователю угадать это число
            //Пользователь пытается угадать это число
            //Если пользователь угадал число , программа поздравляет его с победой
            //Количество попыток угадать число не ограничено
            //*случайное число генерируется только один раз

            bool loopActive = true;

            Random rnd = new Random();
            int i = rnd.Next(1, 11);

            //Console.WriteLine(i);
            //Console.WriteLine(" ");

            Console.WriteLine("ИГРА - УГАДАЙ НОМЕР");
            Console.WriteLine(" ");
            Console.WriteLine("Компьютер загадал число от 1 до 10.");
            Console.WriteLine("Попробуйте угадать это число.");
            Console.WriteLine(" ");
            Console.WriteLine("Введите число:");


            while (loopActive)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == i)
                {
                    Console.WriteLine($"Поздравляем Вас с победой! Вы угадали - это число " + userNumber + ".");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");

        }
    }
}

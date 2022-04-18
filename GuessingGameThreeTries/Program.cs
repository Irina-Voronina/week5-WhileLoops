using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра "угадай номер"
            //Программа генерирует случайное число от 1 - 10
            //Программа предлагает пользователю угадать это число
            //Пользователь пытается угадать это число
            //Если пользователь угадал число, программа поздравляет его с победой
            //У пользователя ровно три попытки
            //Если пользователь не угадывает число за три попытки, программа объявляет победителем компьютер
            //*случайное число генерируется только один раз

            Random rnd = new Random();
            int i = rnd.Next(1, 11);
            int tries = 0;
            int userNumber;

            //Console.WriteLine($"{i}");
            //Console.WriteLine(" ");

            Console.WriteLine("ИГРА - УГАДАЙ НОМЕР");
            Console.WriteLine(" ");
            Console.WriteLine("Компьютер загадал число от 1 до 10.");
            Console.WriteLine("Угадайте число. У Вас три попытки.");
            Console.WriteLine(" ");

            while (tries != 3)
            {
                Console.WriteLine($"Попытка № {tries + 1}. Введите число:");

                userNumber = Convert.ToInt32(Console.ReadLine());

                tries++;

                if (i == userNumber)
                {
                    Console.WriteLine($"Угадали! Это число " + userNumber + "!");
                    Console.WriteLine($"Поздравляем! Вы угадали с {tries} попытки.");
                    break;
                }

                else
                {
                    if (tries == 3)
                    {
                        Console.WriteLine("Не угадали" + " :(");
                        Console.WriteLine(" ");
                        Console.WriteLine("К сожалению, вы не угадали загаданное число. Это было число " + i + "!");
                        Console.WriteLine("В этот раз победил компьюютер! Вам обязательно повезёт в следующий раз! ;)");
                        break;
                    }

                    Console.WriteLine("Не угадали.");
                    Console.WriteLine($"У вас была {tries} попытка. Пробуйте снова");
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");
        }


    }
    
}

using System;

namespace GuessingGameThreeTries_nr_2
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

            Random rand = new Random();
            int i = rand.Next(1, 11);
            int tries = 1;

            //Console.WriteLine($"{i}");
            //Console.WriteLine(" ");

            Console.WriteLine("ИГРА - УГАДАЙ НОМЕР");
            Console.WriteLine("Компьютер загадал число от 1 до 10.");
            Console.WriteLine("Угадайте число. У Вас три попытки.");
            Console.WriteLine(" ");
            Console.WriteLine("Попытка №1:");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            while (tries <= 3)
            {
                if (i == userNumber)
                {
                    Console.WriteLine($"Да! Загаданное число " + userNumber + "!" + " :)");
                    Console.WriteLine("Поздравляем!");
                    break;
                }
                else
                {
                    tries++;
                    if (tries == 4)
                    {
                        Console.WriteLine("К сожалению, вы не отгодали загаданное число. Это было число " + i + "!");
                        Console.WriteLine("В этот раз выиграл компьютер! Вам обязательно повезёт в следующий раз! ;)");
                        break;
                    }
                    Console.WriteLine($"Нет, это число не " + userNumber + " :( ");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Попытка №" + tries + ":");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");
        }
    }
}

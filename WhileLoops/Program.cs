using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа просит пользователя ввести ПИН-код
            //программа проверяет, соотвествует ли веденный ПИН-код значению "1234"
            //если веденное значение соответствует "1234", в консоли выводится "Welcome"
            //и программа завершает свою работу.
            //если введенный ПИН-код неверный, то программа просит снова ввести код
            //*у пользователя 3 попытки

            //bool loopActive = true;
            int tries = 0;

            while (tries != 3) //(loopActive)
            {
                //(tries == 3)  // != "не равно"
                //{
                //Console.WriteLine($"You have tried to log in {tries} times. Login failed.");
                //break;
                //}

                Console.WriteLine("Enter your PIN:");
                string userPIN = Console.ReadLine();

                if (userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                    //loopActive = false;
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Try again");
                    tries++;
                    Console.WriteLine($"You have made {tries} tries.");
                }
            }

            Console.WriteLine("Have a nice day.");
        }
    }
}

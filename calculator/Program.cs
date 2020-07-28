using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Program - Kalkulator \n");
                Console.WriteLine("Podaj pierwszą liczbę:");
                var number1 = GetInput();

                string action1 = "+-*/";
                List<string> actionList = new List<string>();
                actionList.AddRange(action1.Select(c => c.ToString()));

                Console.WriteLine($"Jaką operację wybierasz? \n Wybierz znak:");
                /*
                Console.WriteLine("Dodawanie: [0]\n Odejmowanie: [1]\n Mnożenie: [2]\n Dzielenie: [3] ",actionList);
                */
                Console.WriteLine("Dodawanie: " + actionList[0]);
                Console.WriteLine("Odejmowanie: " + actionList[1]);
                Console.WriteLine("Mnożenie: " + actionList[2]);
                Console.WriteLine("Dzielenie: " + actionList[3]);


                var action = Console.ReadLine();
                Console.WriteLine("Podaj drugą liczbę:");
                var number2 = GetInput();

                var result = Calculate(number1, number2, action);
                Console.WriteLine("Wynik Twojego działania to: \n" + result);
            }
            catch (Exception ex)
            {
                //logika logowania błędów do pliku
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }

        }
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość jest błędna");
            return input;
        }
        private static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!");

            }
        }


    }
}

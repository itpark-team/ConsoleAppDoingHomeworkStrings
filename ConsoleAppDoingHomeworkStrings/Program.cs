using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoingHomeworkStrings
{
    internal class Program
    {
        static bool isNumber(char symb)
        {
            return symb >= '0' && symb <= '9';
        }
        static void Main(string[] args)
        {
            string inputStr;
            int totalSum = 0;

            int currentNumberInInt = 0;
            string currentNumberInString = "";

            Console.Write("введите строку с числами внутри: ");
            inputStr = Console.ReadLine();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if(isNumber(inputStr[i])==true)
                {
                    currentNumberInString += inputStr[i];
                    i++;

                    while(i<inputStr.Length && isNumber(inputStr[i]) == true)
                    {
                        currentNumberInString += inputStr[i];
                        i++;
                    }

                    currentNumberInInt = int.Parse(currentNumberInString);

                    totalSum += currentNumberInInt;

                    currentNumberInString = "";
                }
            }

            Console.WriteLine("сумма чисел в строке  = " + totalSum);

            Console.ReadKey();
        }
    }
}

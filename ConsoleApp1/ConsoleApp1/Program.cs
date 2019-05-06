using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                int rollnum = 0;
                int sum = 0;
                int sum1 = 0;

                int averagesum = 0;
                int averagesum1 = 0;

                string Answer = "Y";

                bool endroll = false;
                int counter = 0;
                int rollnum3 = 0;


                while (endroll == false)
                {
                    Random dies = new Random();
                    int Number = dies.Next(1, 7);
                    rollnum = Number;
                    Random dies3 = new Random();
                    int Number3 = dies3.Next(1, 7);
                    rollnum3 = Number3;

                    Console.WriteLine("     System rolled number is : " + Number + ",  " + Number3 + "");
                    Console.WriteLine("     DO you want to roll your number  Y/N? ");
                    Answer = Console.ReadLine();
                    Answer = Answer.ToUpper();

                    if (Answer == "Y")
                    {

                        Random dies1 = new Random();
                        int Number1 = dies1.Next(1, 7);
                        Random dies4 = new Random();
                        int Number4 = dies4.Next(1, 7);

                        Console.WriteLine("          your rolled number is :" + Number1 + " + " + Number4);

                        Console.ReadKey();
                        rollnum = Number1;
                        rollnum3 = Number4;
                    }
                    counter++;

                    //x++;

                    Console.Write("      DO you want to continue ? Y/N   ");
                    Answer = Console.ReadLine();
                    Answer = Answer.ToUpper();

                    if (Answer == "N")
                    {

                        sum = sum + rollnum;
                        sum1 = sum1 + rollnum3;
                        averagesum = (sum / counter);
                        averagesum1 = (sum1 / counter);
                          
                        Console.WriteLine("sum first dies: " + sum + "  " + "average: " + averagesum + " ");
                        Console.Write("sum Second dies :" + sum1 + "average 2: " + averagesum1+"   ");
                        Console.ReadKey();
                        endroll = true;
                    }
                }
            }
        }
    }
}



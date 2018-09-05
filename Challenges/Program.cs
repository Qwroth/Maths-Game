using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenges
{
    class Program {

        static void Main(string[] args) {
            int number1, number2, choseOperator; 
            string op ="", cont ;
            bool continuePlaying = true;
            int answer;
            Random randomNumber = new Random();



            while (continuePlaying) {

                number1 = randomNumber.Next(1, 11);
                number2 = randomNumber.Next(1, 11);
                choseOperator = randomNumber.Next(1, 4);

                switch (choseOperator) {
                    case 1:
                        op = "X";
                        break;
                    case 2:
                        op = "+";
                        break;
                    case 3:
                        op = "/";
                        break;
                }

                if (op == "X") {

                    Console.WriteLine("What is " + number1 + " X " + number2 + " Equal? ");
                    Start: { }
                    
                        try
                        {
                            answer = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a number");
                        goto Start;
                        }


                        //answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == number1 * number2)
                        {
                            Console.WriteLine("You are correct");

                        }
                        else
                        {
                            Console.WriteLine("You are inccorect");
                        }

                    }
                else if (op == "+")
                    {


                        Console.WriteLine("What is " + number1 + " + " + number2 + " Equal? ");
                        start: { }

                        try
                        {
                            answer = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a number");
                        goto start;
                        }


                        //answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == number1 + number2)
                        {
                            Console.WriteLine("You are correct");

                        }
                        else
                        {
                            Console.WriteLine("You are inccorect");
                        }
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine("What is " + number1 + " / " + number2 + " Equal? ");
                        start: { }

                        try
                        {
                            answer = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a number");
                        goto start;
                        }


                        //answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == number1 / number2)
                        {
                            Console.WriteLine("You are correct");

                        }
                        else
                        {
                            Console.WriteLine("You are inccorect");
                        }
                    }
                

                Console.WriteLine("Do you want to keep playing? Y for yes and N for no");
                Error: { }
                cont = Console.ReadLine();
                if(cont == "Y" || cont == "y"){
                    continuePlaying = true;
                } else if (cont == "N" || cont == "n"){
                    continuePlaying = false;
                } else {
                    Console.WriteLine("Please enter Y for yes or N for no");
                    goto Error;
                }
            }




            Console.WriteLine("Goodbye!");


           
            Console.ReadLine();
        } 
    }
}


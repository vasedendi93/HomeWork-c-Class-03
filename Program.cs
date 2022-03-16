using System;

namespace HomeWorkExercise6FromClass03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6 from Class 03");

            string[] namesArray = new string[10];
            // for homework you can extend the solution with Resize

            Array.Resize(ref namesArray,2147483647 ); //Ova so pomos na google go najdov kakov Maximum sto moze da se naprarvi , sakav nesto so infinty no neznaev kako da go naprarvam:)
            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                namesArray[i] = Console.ReadLine();

                Console.WriteLine("Do you want to enter another name(Y / N)");
                string userChoise = Console.ReadLine();
                if (userChoise.ToUpper() == "Y")
                    continue;
                else
                    break;

            }
            foreach (string name in namesArray)
            {
                Console.WriteLine(name);

            }
        }
    }

}

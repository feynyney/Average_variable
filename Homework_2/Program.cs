using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Lapenko Oleg Vladimirovich";

            int age = 23;

            string email = "lapenkoleg@gmail.com";

            float itPoints = 4.25f;

            float mathPoints = 3.75f;

            float physPoints = 5;

            string output = "Name: {0} \nAge: {1} \nEmail: {2} \nIT points: {3} \nMath points: {4} \nPhysics points: {5}";

            Console.WriteLine(output , name , age , email , itPoints , mathPoints , physPoints);

            float Sum= itPoints + mathPoints + physPoints;

            float Avg = Sum / 3;

            Console.WriteLine($"Average number is {Avg}");
        }
    }
}

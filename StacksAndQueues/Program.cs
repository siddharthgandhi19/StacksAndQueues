using System;
namespace StacksAndQueues
{
    class Program
    {

        static void Main(string[] args)
        {
            Stacks stack = new Stacks();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Stack Problem");
                Console.WriteLine(" 1. Push");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 2:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}
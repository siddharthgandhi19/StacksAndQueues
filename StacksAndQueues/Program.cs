using System;
namespace StacksAndQueues
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue problem Statement");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. Push\n 2. Peak\n 3. Pop ");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());
                Stacks stack = new Stacks();
            
                                          
                switch (option)
                {
                    case 1:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Peak();
                        stack.Display();
                        break;
                    case 3:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Pop();
                        stack.Display();
                        break;
                    case 4:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}
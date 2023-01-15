using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> ToDoList = new List<ToDo>();

            while (true)
            {
                Console.WriteLine("Show todo-1 // Add todo-2 // Delete todo-3 // Exit-0 ");
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 0)
                {
                    break;
                }
                switch (operation)
                {
                    case 1:
                        if (ToDoList.Count == 0)
                        {
                            Console.WriteLine("There is no todo at all");
                            break;
                        }
                        ToDoList.ForEach(i => Console.WriteLine($"{i.Id}--{i.todo}"));
                        break;
                    case 2:
                        string ToDos = Console.ReadLine();
                        ToDoList.Add(new ToDo() { todo = ToDos });
                        break;
                    case 3:
                        if (ToDoList.Count == 0)
                        {
                            Console.WriteLine("There is no todo at all");
                            break;
                        }
                        ToDoList.ForEach(i => Console.WriteLine($"{i.Id}--{i.todo}"));
                        int target = Convert.ToInt32(Console.ReadLine());
                        ToDoList = ToDoList.Where(p => p.Id != target).ToList();

                        break;

                    default:
                        {
                            Console.WriteLine("Again");
                            break;
                        }
                }
            }
        }
        class ToDo
        {
            public string todo { get; set; }
            public readonly int Id;
            private static int _id = 0;

            public ToDo()
            {
                _id++;
                Id = _id;
            }


            public ToDo(string toDo) : base()
            {
                todo = toDo;
            }
        }
    }
}

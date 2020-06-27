
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            arrayList.Add("one");
            Console.WriteLine($"Capacity: {arrayList.Capacity}");

            arrayList.AddRange(new int[] { 45, 6, 23, 92, 16 });
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            Console.WriteLine($"Count: {arrayList.Count}");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write($"{arrayList[i]} ");
            }
            Console.WriteLine();

            foreach (object item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            arrayList.TrimToSize();
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            Console.WriteLine($"Count: {arrayList.Count}");

            //arrayList.Sort();

            arrayList.Remove(23);
            arrayList.RemoveAt(1);

            Console.WriteLine(arrayList.IndexOf(45)); // -1
            arrayList.Reverse();

            foreach (object item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            ArrayList range = arrayList.GetRange(1, 3);

            foreach (object item in range)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // LastInFirstOut
            Stack stack = new Stack();
            stack.Push("two");
            stack.Push(34.56);
            stack.Push(2456);
            stack.Push(new Exception());

            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // FirstInFirstOut
            Queue queue = new Queue();
            for (int i = 1; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.Contains(1)); // False

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Contains(2)); // True

            Console.WriteLine();

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    class Ball
    {
        ConsoleColor _color;
        string _material;

        public Ball(ConsoleColor color, string material)
        {
            _color = color;
            _material = material;
        }

        public override string ToString()
        {
            Console.ForegroundColor = _color;
            return $"Color: {_color} Material: {_material}";
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "John");
            hashtable.Add("one", 12.56);
            hashtable.Add(new Ball(ConsoleColor.Red, "leather"), "Red ball");

            hashtable.Add(34.78, new Ball(ConsoleColor.Green, "rubber"));

            if (!hashtable.ContainsKey("one"))
            {
                hashtable.Add("one", 2489); // error
            }

            foreach (object item in hashtable.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"Key: {key} Value: {hashtable[key]}");
            }
            Console.WriteLine();

            if (hashtable.ContainsKey(1))
            {
                hashtable.Remove(1);
            }

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"Key: {key} Value: {hashtable[key]}");
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    class Ball
    {
        ConsoleColor _color;
        string _material;

        public Ball(ConsoleColor color, string material)
        {
            _color = color;
            _material = material;
        }

        public override string ToString()
        {
            Console.ForegroundColor = _color;
            return $"Color: {_color} Material: {_material}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(7, 6.78);
            sortedList.Add(5, "one");
            //sortedList.Add("2", 34); error
            sortedList.Add(2, new Ball(ConsoleColor.Magenta, "tree"));

            foreach (object key in sortedList.Keys)
            {
                Console.WriteLine($"Key: {key} Value: {sortedList[key]}");
            }
            Console.WriteLine();

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"Key: {sortedList.GetKey(i)} Value: {sortedList.GetByIndex(i)}");
            }
            Console.WriteLine();
            
            if (sortedList.ContainsKey(5))
            {
                sortedList.Remove(5);
            }

            foreach (object item in sortedList.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

using System.Collections;
using static System.Console;

namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }

    class Program
    {
        static Hashtable group = new Hashtable {
                {
                new Student {
                    FirstName ="John",
                    LastName ="Miller"
                },new ArrayList{8,4,9}
                },
                {
                new Student {
                    FirstName ="Candice",
                    LastName ="Leman"
                },new ArrayList{12,9,10}
                }
            };
        static void RatingsList()
        {
            WriteLine("+++++++++++++ —писок студентов с оценками ++++++++++\n");

            foreach (Student student in group.Keys)
            {
                Write($"{student}: ");
                foreach (int item in (group[student] as ArrayList))
                {
                    Write($"{item} ");
                }
                WriteLine();
            }
        }
        static void SetRating(string name, int mark)
        {

            WriteLine($"\n+++++++++++++ —тудент {name} получил оценку {mark} ++++++\n");

            foreach (Student item in group.Keys)
            {
                if (item.LastName == name)
                {
                    (group[item] as ArrayList).Add(mark);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            RatingsList();

            SetRating("Leman", 11);

            RatingsList();
        }
    }
}

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

«адани€: 
1.	–азработать класс очереди печати сотрудников. ѕредусмотреть в классе методы: помещение документа 
	в очередь печати, извлечение следующего документа из очереди печати, проверка наличи€ документов 
	в очереди. ѕри помещении документа задаетс€ его приоритет, извлекаютс€ в первую очередь документы с более высоким приоритетом.

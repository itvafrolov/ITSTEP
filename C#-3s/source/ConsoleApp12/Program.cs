using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
       
        class ball
        {
            ConsoleColor _color;
            string _material;
            public ball(ConsoleColor color, string material)
            {
                _color = color;
                _material = material;
            }

            public override string ToString()
            {
                Console.ForegroundColor = _color;
                return $"Color: {_color} Material {_material}";
            }
            //public override bool Equals(object obj)
            //{
            //    return this.ToString()==obj.ToString();
            //}

            //public override int GetHashCode()
            //{
            //    return ToString().GetHashCode();
            //}
        }
       

        static void Main(string[] args)
        {
            // специализированные коллекции - создаются в пространствах имен, для управлениями спецыяи
            // 2 вида - необобщенные и обобщенные 
            // необобщенные - старые
            // можно хранить внутри колллекции все, что угодно, строки, объекты, т. д.
            // 
            /*
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            arrayList.Add("one");
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            arrayList.AddRange(new int[] { 45, 6, 23, 92, 16 });
            Console.WriteLine($"Capacity: {arrayList.Count}");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write($" {arrayList[i]}");
            }
            Console.WriteLine();
            foreach (object item in arrayList)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            // arrayList.Sort(); // -ошибка!
            arrayList.Remove(23);
            arrayList.RemoveAt(1);
            Console.WriteLine(arrayList.IndexOf(45));
            Console.WriteLine();

            ArrayList rang = arrayList.GetRange(1, 3);
            rang.Reverse();
            foreach (object item in rang)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            */

            // вид коллекции - СТЕК - последний пришел - первый ушел
            /*
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
            Console.WriteLine();
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            */

            // вид коллекции - ОЧЕРЕДЬ   - первый пришел, первый ушел
            /*
            Queue queue = new Queue();
            for (int i = 1; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Contains(1));  
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(2));
            Console.WriteLine();
            */
            // СЛОВАРИ - похож на ассоциативный массив ключ-значение // ключ - уникальный
            //  - 1 -
            /*
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Join");
            hashtable.Add("one", "12.56");
            hashtable.Add(new ball(ConsoleColor.Red, "lether"), "Red Ball");
            hashtable.Add(34.78, new ball(ConsoleColor.Green, "rubber"));

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
            */
            // СОРТИРОВАННЫЙ СПИСОК  -- словарь отсортированный по ключам
            // обязательное условие - ключи должны быть однотипными!
            // - 2 -

            SortedList sortedList = new SortedList();

            sortedList.Add(7, 6.78);
            sortedList.Add(5, "one");
            // sortedList.Add("7", 6.78); // ошибка
            sortedList.Add(2, new ball(ConsoleColor.Green, "rubber"));

            foreach (object item in sortedList.Values)
            {
                Console.WriteLine(item);
            }
            Hashtable 
            //
            Console.ReadKey();
        }
    }
}

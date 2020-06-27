using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  -- ОБОБЩЕННЫЕ  КОЛЛЕКЦИИ


namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// object obj = 45; // упаковка в ссылочный записывается значимый 
            ////// // int num = obj; // распаковка в значимый   -- ОШИБКА
            ////// int num = (int)obj; // распаковка в значимый 

            ////// ArrayList arrayList = new ArrayList();
            ////// arrayList.Add(4); // упаковка
            ////// int n = (int)arrayList[0];

            //////// short sh = (short)arrayList[0];  // исключительная ситуация из-за того, что заданное приведение int -> short  недопустимо потому

            ////// // - обобщения -
            ////// // name<>--выглядит так  - в угловых скобках
            ////// // сюда входят коллекции, интерфейсы 

            ////// List<int> list = new List<int>() { 29, 56, 38};
            ////// list.Add(77); // добавляет в конец массива и контролирует типы данных
            ////// list.Insert(1, 234);
            ////// list.InsertRange(3, new int[] { 22, 33, 44, 55 });
            ////// list.Sort();
            ////// list.Reverse();
            ////// foreach (int item in list)
            ////// {
            //////     Console.Write($"{item} ");
            ////// }
            ////// Console.WriteLine();

            ////// List<string> listStr = new List<string>();
            ////// listStr.Add("help");
            ////// listStr.Add("hello");
            ////// listStr.Add("hell");
            ////// listStr.Sort();
            ////// foreach (string item in listStr)
            ////// {
            //////     Console.WriteLine($"{item} ");
            ////// }
            ////// Console.WriteLine();
            ///

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["gr1"] = 12; // через индексатор создаем значение
            dict.Add("gr2", 9); // уникальность ключа обязательна!

            if (!dict.ContainsKey("gr5"))
            {
                dict.Add("gr5", 8);
            }

            foreach (KeyValuePair<string,int> item in dict)
            {
                // Console.WriteLine(item);
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }

            int number;
            if (dict.TryGetValue("gr5", out number))
            {
                Console.WriteLine(number);
            }

            Dictionary<int, double> dict2 = new Dictionary<int, double>
            {
                [4] = 37.72,
                [5] = 37,
                [55] = 555.4
            };

            foreach (int item in dict2.Keys)
            {
                Console.WriteLine($"Key: {item} Value: {dict2[item]}");
            }
        }
    }
}

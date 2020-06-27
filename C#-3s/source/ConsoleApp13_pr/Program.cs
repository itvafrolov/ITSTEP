using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_pr
{
    class QueuePrint
    {
       // SortedList printDoc;
        int _prioritet;
        string _docName;

        public QueuePrint(int prioritet, string docname)
        {
            _prioritet = prioritet;
            _docName = docname;        }

        public override string ToString()
        {
            return $"Prioritet: {_prioritet} Docname {_docName}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedList printDoc = new SortedList();
            int index = 0, in_min = 0, in_max = 0,  pr = -1; // приоритет 1 - ++  0 -- "-"            
            string doc = "doc1";
            string str; 

            // printDoc.Add(index, new QueuePrint(pr,doc));

            for (int i = 0; i < 10; i++)
            {
                str = Console.ReadLine();
                pr = Convert.ToInt32(str);
                if (pr == 0)
                {
                    in_min -= 1;
                    index = in_min;
                }
                if (pr == 1) 
                {
                    in_max += 1;
                    index = in_max;
                }
                printDoc.Add(index, new QueuePrint(pr, doc));
            }

          
            foreach (object item in printDoc.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}

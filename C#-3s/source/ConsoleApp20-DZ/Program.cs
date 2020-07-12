using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LINQ
/*
    ++ Создать Person (FName, LName, Age, Birthday).
	++ Создать класс PersonNationality (id, Nationality). Добавить в класс Person поле idNationality.

	-- Создать и заполнить тестовыми значениями на основе класса PersonNationality коллекцию объектов.

С помощью выражений LINQ получить и распечатать на экране результаты следующих запросов:

a. Фамилии и даты рождения людей, возраст  которых превышает 20 лет. Результат отсортировать по возрасту (по возрастанию), 
а также по дате (по убыванию).

b. С помощью повторного использования оператора from получить список обращений к людям (больше 18 лет) в двух вариантах 
(1.Уважаемый Иван Иванович, 2. Дорогой Иван Иванович )

c. Получить список имен всех людей отсортированный по IdNationality по убыванию.

d. Получить список людей,  с указанной датой рождения. Список должен содержать строки с фамилией, именем и поздравлениями 
с днем рождения.

e. Получить список людей группированных по четным и не четным месяцам рождения. Вывести сначала всех людей первой категории 
(четные) затем второй (не четные).

f. В предыдущий список результата добавить счетчик, который указывает на количество людей принадлежащее первой и второй 
категории.

g. Отсортировать имена людей списка в порядке возрастания, но при этом выполнять сортировку по полному имени, сформированному 
объединением вместе FName и LName.

 */


namespace ConsoleApp20_DZ
{
    class Person 
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public int idNationality { get; set; }
     
    }

    class PersonNationality
    {
        public int id  { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonNationality> nationality = new List<PersonNationality>
            {
                new PersonNationality { id = 1,  Nationality = "Ukrainian"},
                new PersonNationality {id = 2, Nationality = "Russian"},
                new PersonNationality {id = 3, Nationality = "American"},
                new PersonNationality {id = 4, Nationality = "Frenchman"},
                new PersonNationality {id = 5, Nationality = "Chinese"}
            };

            List<Person> group = new List<Person> {

                new Person {
                    FName = "Taras",
                    LName = "Koval",
                    Age = 22,
                    BirthDate = new DateTime(1997,3,12),
                    idNationality = 1
                },

                new Person {
                    FName = "Ivan",
                    LName = "Dyrak",
                    Age = 18,
                    BirthDate = new DateTime(2002,7,22),
                    idNationality = 2
                },

                new Person {
                    FName = "Joey",
                    LName = "Finch",
                    Age = 23,
                    BirthDate = new DateTime(1996,11,30),
                    idNationality = 3
                },

                new Person {
                    FName = "Nicole",
                    LName = "Taylor",
                    Age = 24,
                    BirthDate = new DateTime(1996,5,10),
                    idNationality = 4
                },

                new Person {
                    FName = "Li",
                    LName = "Tsin",
                    Age = 14,
                    BirthDate = new DateTime(2006,5,10),
                    idNationality = 5
                }
            };
            //--------------------------------------------------------------




        }
    }
}

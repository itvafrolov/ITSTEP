using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student
    {

        // **** ключевые слова
        // static - поле, общее для всех экземпляров класса. Обращение к нему только через имя класса
        // const - поле, нужно проинициализировать и потом изменить его нельзя. Обращение к нему только через имя класса
        // readonly - поле, только для чтения. Можно проинициализировать 2мя способами 1 при объявлении, 2. в конструкторе
        // this - ссылка на     не работает со статическими типами данных вызов его например такой:  this.Town
        // 


        // public readonly string Town = "Kharkiv"; // 1
        public readonly string Town;                // 2
        public const string Country = "Ukraine";
        private int _studentId;
        private string _firstName = "John";
        private string _lastName = "Doe";
        private DateTime _birstDate;
        private int _groupId;

        private static string _univer;
        public static string GetUniver()
        {
            return _univer;
        }
        public void SetUniver(string name)
        {
            _univer = name;
        }

        /*public Student()
        {
            Town = "Odessa";
        }*/
        //объявление поля readonly   // 2 способ
        public Student(string town1)
        {
            this.Town = town1;
        }

        public Student(string fname, string lname, string town) : this(town)
        {
            _firstName = fname;
            _lastName = lname;
        }
        //СТАТИЧЕСКИЙ КОНСТРУКТОР
        static Student()
        {

        }

        public DateTime GetDateTime()
        {
            return _birstDate;
        }

        public void SetDateTime(DateTime dT)
        {
            _birstDate = dT;
        }

        public void Print()
        {
            Console.WriteLine($"Id: {_studentId} \nfirst name: {_firstName} \nlast name: {_lastName} \ndate of birth: {_birstDate} \ngroupe Id: {_groupId} \nTown: {Town}");
        }


    }
}

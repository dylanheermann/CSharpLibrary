using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program : Student
    {
        static void Main(string[] args)
        {
            //Student jayStudent = new Student();
            //jayStudent.FirstName = "Jay";
            //jayStudent.LastName = "Jackson";
            //jayStudent.Grade = 1;
            //jayStudent.Age = 5;

            Student kendreaStudent = new Student("Kendrea");

            Student paulStudent = new Student("Paul", "OConner", 12);

            Student jayStudent = new Student("Jay", "Jackson", 5, 1);

            Console.WriteLine(jayStudent);
            Console.ReadLine();
        }
    }
}

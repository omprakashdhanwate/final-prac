using System;
using System.Linq;

namespace LINQ_ex
{
    internal class Program
    {
        delegate bool D();
        delegate bool D2(int i);

        class  Student
        {
            public int StudentID { get; set; }

            public String StudentName { get; set; }

            public int Age { get; set; }
        }

        class Test
        {
            D del;
           public D2 del2;

            public void TestMethod(int input)
            {
                int j = 0;
                del = () => { j = 10; return j > input; };

                del2 = (x) => { return x == j; };

                Console.WriteLine($"j = {j}");
                bool boolResult = del();

                Console.WriteLine($"j = {j},b = {boolResult}");

                bool boolResult1 = del2(10);
                Console.WriteLine($"j = {j}, b = {boolResult1}");
            }
        }


        static void Main(string[] args)
        {

            string[] names = { "Bill", "steve", "James", "Mohan" };

            var myLinqQuery = from name in names where name.Contains('a') select name;

            Console.WriteLine("LinQ with Array");

            foreach (var name in myLinqQuery)
                Console.WriteLine(name + " ");


            Student[] studentArray =
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "steve", Age = 19 },
                new Student() { StudentID = 3, StudentName = "OP", Age = 20 },
                new Student() { StudentID = 4, StudentName = "Bug", Age = 23 },
                new Student() { StudentID = 5, StudentName = "Jarvis", Age = 56 },
                new Student() { StudentID = 6, StudentName = "Elon", Age = 50 }
            };

            Student[] std = new Student[10];

            int i = 0;
            Console.WriteLine("LINQ using collection");
            foreach (Student student in studentArray)
            {
                if (student.Age > 12 && student.Age < 20)
                    {
                    std[i] = student;
                    i++;
                    Console.WriteLine(std[i-1].StudentName);
                }
            }

            Console.WriteLine("LINQ using delegates");
            Test test = new Test();
            test.TestMethod(5);

            bool result = test.del2(10);
            Console.WriteLine(result);
            
        }
    }



   

}
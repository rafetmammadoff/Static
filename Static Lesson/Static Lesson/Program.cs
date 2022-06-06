using System;

namespace Static_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupNo;
            do
            {
                Console.WriteLine("Group No daxil edin");
                 groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));

            Student student = new Student();
            student.GroupNo = groupNo;
            Console.WriteLine(student.GroupNo);
           
            
        }
    }
}

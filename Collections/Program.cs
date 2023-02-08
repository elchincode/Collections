using Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class Program
    {


        public static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            var student = new Student
            {

                Name = "Elchin",
                Surname = "Ismayilov",
                Pin = 12342


            };

            Checker(students, student);
            

            var student2 = new Student
            {

                Name = "Cahangir", 
           
                Surname = "Recebli",
                Pin = 1637282


            };

            Checker(students, student2);




            var student3 = new Student
            {

                Name = "Mahir",

                Surname = "Qasimli",
                Pin = 353628


            };

            Checker(students, student3);


            foreach (var item in students)
            {
                Console.WriteLine(item.GetDetails());
            }


            StudentsWithA(students, student3);




        }



        public static void Checker(List<Student> students, Student student)
        {

            var isDublicatedId = students.Any(p => p.Pin == student.Pin);
            
            if(!isDublicatedId)
            {
                students.Add(student);
            }



          



        }


        public static void StudentsWithA(List<Student> classroom, Student student)
        {

            var count = classroom.Count(p => p.Name.Contains("a"));
            Console.WriteLine(count);


           
        }

    }
}
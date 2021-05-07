using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace EF_Lab
{
    class Program
    {
         static void Main(string[] args)
        {

            //CreateBD();

            //DisplayAllDB();
            DisplayStudentIDDB();
        }



        static void CreateBD()
        {
            using (var context = new ClassContext())
            {
                Student st = new Student()
                {
                    Name = "Sean",
                    Food = "Pizza",
                    Hometown = "Plymouth"

                };
                context.Student.Add(st);

                Student stu = new Student()
                {
                    Name = "Alice",
                    Food = "Sushi",
                    Hometown = "Detroit"

                };
                context.Student.Add(stu);
                Student stud = new Student()
                {
                    Name = "Jean",
                    Food = "Sushi",
                    Hometown = "North Carolina"

                };
                context.Student.Add(stud);
                Student stude = new Student()
                {
                    Name = "Kalai",
                    Food = "Dosa",
                    Hometown = "Flint"

                };
                context.Student.Add(stude);
                Student studen = new Student()
                {
                    Name = "Jason",
                    Food = "Mac and Cheese",
                    Hometown = "Dearborne"

                };
                context.Student.Add(studen);


                context.SaveChanges();
                
                
            }
        }

        static void DisplayAllDB()
        {
            
            using (var context = new ClassContext())
            {
                var all = context.Student.ToList();
                foreach (Student s in all)
                {
                    Console.WriteLine(s.Name + s.StudentID);
                }
            }
            
        }
        
        static void DisplayStudentIDDB()
        {
            using (var context = new ClassContext())
            {
                Console.WriteLine("Enter a student ID");
                int choice = int.Parse(Console.ReadLine());

                var all = context.Student.ToList();

                foreach(Student s in all)
                {
                    if (s.StudentID == choice)
                    {
                        Console.WriteLine(s.Food + s.Hometown);
                    }
                }


            }


        }



    }



}

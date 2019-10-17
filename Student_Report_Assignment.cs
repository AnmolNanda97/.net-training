using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student_Report
    {
        static void Main()
        {
            int students;
            int subjects;
            Console.WriteLine("Enter the no.of student entries");
            students = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no.of subjects");
            subjects = int.Parse(Console.ReadLine());
            string[] stuname= new string[students];
            int[,] marks = new int[students, subjects];
            int[] total = new int[subjects];
            int[] average = new int[subjects];


            Console.WriteLine("Enter the Student details");
            for (int i = 0; i < students; i++)
            {
                total[i] = 0;
                average[i] = 0;
                Console.WriteLine("Enter the name of the student");
                stuname[i] = Console.ReadLine();
                Console.WriteLine("Enter the marks");
                for (int j = 0; j < subjects; j++)
                {
                    
                    
                    marks[i, j] = int.Parse(Console.ReadLine());
                    total[i] = total[i] + marks[i, j];
                    average[i] = total[i] / subjects;


                }
                
            }

            

            Console.WriteLine("Name \t Mark1 \t Mark2 \t Mark3 \t Mark4 \t Mark5 \t Total \t Average");
            Console.WriteLine("---------------------------------------------------------------------");

            for(int i = 0; i < students; i++)
            {
                Console.Write(stuname[i]+"\t");
                
                for (int j = 0; j < subjects; j++)
                {
                   
                    Console.Write(marks[i,j]+"\t");
                 }
                Console.Write(total[i] + "\t");
                Console.Write(average[i]);

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

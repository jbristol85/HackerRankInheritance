using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankInheritance
{
    class Program
    {
    

        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person()
            {
            }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }
        class Student : Person
        {
            private int[] testScores;

            /*    
        *   Class Constructor
        *   
        *   Parameters
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
            // Write your constructor here

            public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
            {
                this.testScores = testScores;
            }

            public char Calculate()
            {
                var sum = 0;
                var count = 0;
                int average;
                foreach (var t in testScores)
                {
                    sum += t;
                    count++;
                }

                average = sum / count;
                // return average;

                if (90 <= average && average <= 100)
                {
                    return 'O';
                }
                else if (80 <= average && average < 90)
                {
                    return 'E';
                }
                else if (70 <= average && average < 80)
                {
                    return 'A';
                }
                else if (55 <= average && average < 70)
                {
                    return 'P';
                }
                else if (40 <= average && average < 55)
                {
                    return 'D';
                }

                return 'T';

            }
            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
        }
        class Solution
        {
            static void Main()
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }
        }

    }

}

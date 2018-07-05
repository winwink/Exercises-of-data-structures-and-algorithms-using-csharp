using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.chapter1_Collection;

namespace Winwink.LearnCsharpCollection.chapter2
{
    public class Exercises1_Course
    {
        public static void Main1()
        {
            Course c = new Course("Math");
            List<double> grades = new List<double>() { 83.5,81,90,95,80,100,35,65,39};
            c.Grades.AddRange(grades);
            var max = c.GetMax();
            var min = c.GetMin();
            var avg = c.GetAvg();
            Console.WriteLine("Max:{0}, Min:{1}, Avg:{2}", max, min, avg);
        }
    }

    public class Course
    {
        public Course(string name)
        {
            CourseName = name;
            Grades = new ArrayList();
        }

        public string CourseName { get; set; }

        public ArrayList Grades { get; set; }

        public double GetMax()
        {
            double max = double.MinValue;
            foreach (double grade in Grades)
            {
                if (grade > max)
                {
                    max = grade;
                }
            }
            return max;
        }

        public double GetMin()
        {
            double min = double.MaxValue;
            foreach(double grade in Grades)
            {
                if(grade < min)
                {
                    min = grade;
                }
            }
            return min;
        }

        public double GetAvg()
        {
            double sum = 0.0;
            foreach(double grade in Grades)
            {
                sum += grade;
            }
            double avg = sum / Grades.Count;
            return avg;
        }
    }

    public class Class
    {
        public string ClassName { get; set; }

        public List<Course> Courses { get; set; }
    }
}

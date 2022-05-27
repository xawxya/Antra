using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Student : Person
    {
        public List<String> course = new List<string>();
        public List<String> grade = new List<string>();

        public void addCourse(string name, string grade)
        {
            this.course.Add(name);
            this.grade.Add(grade);
        }
        public void removeCourse(string name)
        {
            this.grade.RemoveAt(this.course.IndexOf(name));
            this.course.Remove(name);
        }

        public double getGPA()
        {
            int len = this.grade.Count();
            double result = 0;
            foreach(string grade in this.grade)
            {
                if (grade.Equals("A"))
                {
                    result += 4;
                } else if (grade.Equals ("B"))
                {
                    result += 3;
                } else if (grade.Equals("C"))
                {
                    result += 2;
                } else if (grade.Equals("D"))
                {
                    result += 1;
                } else if (grade.Equals("E"))
                {
                    result += 0.5;
                }
            }
            result = Math.Round(result / len, 2);
            return result;
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Course
    {
        public List<string> studentList = new List<string>();

        public void addStudent(string name)
        {
            studentList.Add(name);
        }
    }
}

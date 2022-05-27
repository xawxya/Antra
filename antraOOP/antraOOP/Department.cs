using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Department
    {

        private string head;
        public string Head { get { return head; } set { head = value; } }

        private int budget;
        public int Budget { get { return budget; } set { budget = value; } }
        public List<string> courseList = new List<string>();

        public void addCourse(string name)
        {
            courseList.Add(name);
        }

    }
}

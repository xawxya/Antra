using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Instructor : Person
    {
        private string department;
        private bool isHead;
        public string Department { get; set; }
        public bool IsHead { get; set; }
        private DateTime joindate;
        public DateTime JoinDate { get; set; }
       
        public int bonus;
        
        public void setBonus()
        {
            int yr1 = DateTime.Now.Year;
            int yr2 = this.JoinDate.Year;
            int exp = yr1 - yr2;
            this.bonus = 500 + exp * 100;
        }

    }
}

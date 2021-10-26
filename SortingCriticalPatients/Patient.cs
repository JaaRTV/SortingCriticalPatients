using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCriticalPatients
{
    class Patient 
    {
        public String Name;
        public String Surname;
        public int Age;
        public String Status;

        public Patient(string Name, string Surname,int Age,string Status)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Status = Status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
    class Person 

    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public int patientNumber { get; set; }
       public string ageGgroup { get; set; }
        
        public Person()
        {
            
        }

        public Person(string firstName,
                    string lastName,
                    string gender,
                    DateTime birthDate,
                    int patientNumber
                   )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.patientNumber = patientNumber;
            
        }
    }
}

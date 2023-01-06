using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Appointment : Person
    {
        public int slot { get; set; }
        public string service {get; set; }
        public void performService(string service)
        {
            Console.WriteLine("The " + service + " was performed");
        }

        public Appointment(string firstName,
                    string lastName,
                    string gender,
                    DateTime birthDate,
                    int patientNumber,
                    int slot,
                    string service
                   )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.patientNumber = patientNumber;
            this.slot = slot;
            this.service = service;
        }
    }
}

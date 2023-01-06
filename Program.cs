using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Dhruvi", "Lad", "female", new DateTime(1999, 5, 17), 1234567890);
            Person p2 = new Person("Parth", "Lad", "male", new DateTime(1997, 6, 10), 1234567891);
            Person p3 = new Person("Riddhi", "Parmar", "female", new DateTime(1990, 4, 30), 1234567892);
            Person p4 = new Person("Jay", "Mistry", "male", new DateTime(1999, 7, 22), 1234567893);
            Person p5 = new Person("Jenil", "Patel", "male", new DateTime(2020, 2, 15), 1234567894);
            Person p6 = new Person("Mili", "Donga", "female", new DateTime(2011, 9, 29), 1234567895);
            Person p7 = new Person("Rogers", "Andrew", "male", new DateTime(2005, 3, 13), 1234567896);
            Person p8 = new Person("Harry", "Scanlan", "male", new DateTime(2022, 8, 7), 1234567897);
            Person p9 = new Person("Pratik", "Shah", "male", new DateTime(2012, 9, 5), 1234567898);
            Person p10 = new Person("Jaya", "Lad", "female", new DateTime(1999, 12 ,4), 1234567899);

            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            persons.Add(p4);
            persons.Add(p5);
            persons.Add(p6);
            persons.Add(p7);
            persons.Add(p8);
            persons.Add(p9);
            persons.Add(p10);

            int input = 0;

            AppointmentList appointmentData = new AppointmentList();
            
            int slot = 8;

            string[] check_Group(DateTime dt, Person p)
            {
                if (dt.Year < 1961)
                {
                    string[] serviceList = { "Cleaning", "CavityFill", "Checkup", "XRay", "dentures" };
                    p.ageGgroup = "senior";
                    return serviceList;
                }
                else if (dt.Year < 2003)
                {
                    string[] serviceList = { "Cleaning", "CavityFill", "Checkup", "XRay", "veneers" };
                    p.ageGgroup = "adult";
                    return serviceList;
                }
                else
                {
                    string[] serviceList = { "Cleaning", "CavityFill", "Checkup", "XRay",  "braces" };
                    p.ageGgroup = "children";
                    return serviceList;
                }
            }

            void createAppointment()
            {
                if (slot < 16)
                {
                    Console.WriteLine("Write your patient number to book appointment");
                   
                    int patientNumber = 0;
                    try
                    {
                        patientNumber = int.Parse(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    string choosen_Service;
                    int temp = 0;

                    Appointment newAppointment = null;

                    foreach (Person p in persons)
                    {
                        if (p.patientNumber == patientNumber)
                        {
                            temp = 1;
                            string[] group = check_Group(p.birthDate, p);
                             Console.WriteLine("----------------");
                            Console.WriteLine("Choose From Given Services:");

                            foreach (string ser in group)
                            {
                                Console.WriteLine(ser);
                            }
                            choosenService = Console.ReadLine();
                             Console.WriteLine("----------------");
                            newAppointment = new Appointment(p.firstName, p.lastName, p.gender, p.birthDate, p.patientNumber, slot, choosen_Service);
                            slot += 1;
                        }
                    }
                    if (temp == 0)
                    {
                        Console.WriteLine("Please select correct number");
                    }
                    else
                    {
                        appointmentData.appointments.Add(newAppointment);
                    }
                }
                else
                {
                    Console.WriteLine("All the appoinments are booked:");
                }
            }
            do
            {
                
                Console.WriteLine("Select From Given List:");
                Console.WriteLine("List all people-------------> Press 1 For That");
                Console.WriteLine("Create a schedule-----------> Press 2 for that");
                Console.WriteLine("Display the day's schedule--> Press 3 for that");
                Console.WriteLine("Exit the program------------> Press 4 for that");
                
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (input == 1)
                    {
                        foreach (Person person in persons)
                        {   
                            Console.WriteLine("----------------");
                            Console.WriteLine(person.firstName);
                            Console.WriteLine(person.lastName);
                            Console.WriteLine(person.gender);
                            string number = (person.patientNumber).ToString();
                            number = (number).Remove(0, 3);
                            string newNumber = number.Insert(0, "XXX");
                            Console.WriteLine(newNumber);
                            Console.WriteLine(person.birthDate);
                            Console.WriteLine(person.ageGgroup);

                        }
                    }
                    else if (input == 2)
                    {
                        createAppointment(); 
                    }
                    else if (input == 3)
                    {
                        foreach (Appointment ap in appointmentData.appointments)
                        {
                            Console.WriteLine("----------------");
                            Console.WriteLine(ap.firstName);
                            Console.WriteLine("Your appointment is from "+ ap.slot + " for 1 hour.");
                            Console.WriteLine(ap.patientNumber);
                            ap.performService(ap.service);
                            Console.WriteLine("");
                        }
                    }
                    else if (input == 4) { }
                    else
                    {
                        Console.WriteLine("Please select from given list:");
                    }
                
            } while (input != 4);
            Console.ReadLine();
        }
    }
}

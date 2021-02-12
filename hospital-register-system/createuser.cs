using System;
using System.IO;

namespace hospital_system
{
    
    public class Create
    {

      public string username;
      public string password;
      public string name;
      public string surname;
      public string pesel;
      public string specialty;
      public string pwz;
      public string admin;

        public void createadmin()
        {

            AdminClass admin = new AdminClass();
            Console.WriteLine("New Admin account creating");
            detector();
            admin.admin_username = username;
            admin.admin_password = password;
            admin.admin_name = name;
            admin.admin_surname = surname;
            admin.admin_pesel = pesel;
            admin.writeAdmin();

        }
        public void createdoctor()
        {
            DoctorClass doctor = new DoctorClass();
            Console.WriteLine("New Doctor account creating");
            detector();
            detectorPwz();
            doctor.doctor_username = username;
            doctor.doctor_password = password;
            doctor.doctor_name = name;
            doctor.doctor_surname = surname;
            doctor.doctor_pesel = pesel;
            doctor.doctor_specialty = specialty;
            doctor.doctor_pwz = pwz;
            doctor.writeDoctor();
        }
        

        public void createnurse()
        {
            NurseClass nurse = new NurseClass();
            Console.WriteLine("New Nurse account creating");
            detector();          
            nurse.nurse_username = username;
            nurse.nurse_password = password;
            nurse.nurse_name = name;
            nurse.nurse_surname = surname;
            nurse.nurse_pesel = pesel;
            nurse.writeNurse();
        }
        public void detector() {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            Console.Write("PESEL: ");
            pesel = Console.ReadLine();
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            
            
            if (File.Exists("nurseusername.txt")) {
                string text = System.IO.File.ReadAllText("nurseusername.txt");
                if (text.Contains(username)) {
                    Console.WriteLine("This username already taken"); Environment.Exit(0);
                }
            }
            if (File.Exists("adminusername.txt")) {
                string text = System.IO.File.ReadAllText("adminusername.txt");
                if (text.Contains(username)) {
                    Console.WriteLine("This username already taken"); Environment.Exit(0);
                }
            }
            if (File.Exists("doctorusername.txt")) {
                string text = System.IO.File.ReadAllText("doctorusername.txt");
                if (text.Contains(username)) {
                    Console.WriteLine("This username already taken"); Environment.Exit(0);
                }
            }
         
        }
        public void detectorPwz()
        {
            Console.Write("Specialty: ");
            specialty = Console.ReadLine();
            Console.Write("PWZ: ");
            pwz = Console.ReadLine();
            if (File.Exists("doctorpwz.txt")) {
                string text = System.IO.File.ReadAllText("doctorpwz.txt");
                if (text.Contains(pwz)) {
                    Console.WriteLine("This PWZ number already exist"); Environment.Exit(0);
                }
            }
        }

    }
}
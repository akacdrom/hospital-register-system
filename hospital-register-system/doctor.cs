using System;
using System.IO;

namespace hospital_system
{
    public class DoctorClass
    {
        public string doctor_username;
        public string doctor_password;
        public string doctor_name;
        public string doctor_surname;
        public string doctor_pesel;
        public string doctor_specialty;
        public string doctor_pwz;
        public string temp_username;
        public string temp_password;
        public void writeDoctor()
        {
           
            
            using(StreamWriter writetext = new StreamWriter("doctorusername.txt",true))
            {
                writetext.WriteLine(doctor_username);
            }
            using(StreamWriter writetext = new StreamWriter("doctorpassword.txt",true))
            {
                writetext.WriteLine(doctor_password);
            }
            using(StreamWriter writetext = new StreamWriter("doctorname.txt",true))
            {
                writetext.WriteLine(doctor_name);
            }
            using(StreamWriter writetext = new StreamWriter("doctorsurname.txt",true))
            {
                writetext.WriteLine(doctor_surname);
            }
            using(StreamWriter writetext = new StreamWriter("doctorpesel.txt",true))
            {
                writetext.WriteLine(doctor_pesel);
            }
            using(StreamWriter writetext = new StreamWriter("doctorspecialty.txt",true))
            {
                writetext.WriteLine(doctor_specialty);
            }
            using(StreamWriter writetext = new StreamWriter("doctorpwz.txt",true))
            {
                writetext.WriteLine(doctor_pwz);
            }
            
            
        
        Environment.Exit(0);
            
        }
        public void doctor_login()
        {
            CheckFile checkDoctor = new CheckFile();
            if (checkDoctor.checkDoctor()) return;
            
            int i = 1;
            int k = 1;
            string[] usernames = System.IO.File.ReadAllLines("doctorusername.txt");
            foreach (string username in usernames)
            {

                if (temp_username == username) 
                {
                    string[] passwords = System.IO.File.ReadAllLines("doctorpassword.txt");
                    
                    foreach (string password in passwords)
                    {
                        if (i == k ) {
                            if (temp_password == password)
                                Console.WriteLine("successfully logged in as a doctor");
                                AdminClass admin = new AdminClass();
                                admin.list_doctor();
                                admin.list_nurse();
                                Environment.Exit(0);
                                    
                        }
                        k++;
                        
                    }
                }
                i++;

            }
            return;

        }
        
    }
}

using System;
using System.IO;

namespace hospital_system
{
    public class AdminClass
    {
        public string admin_username;
        public string admin_password;
        public string admin_name;
        public string admin_surname;
        public string admin_pesel;
        public string temp_username;
        public string temp_password;
        
        
        public void writeAdmin()
        {
           

            using(StreamWriter writetext = new StreamWriter("adminusername.txt",true))
            {
                writetext.WriteLine(admin_username);
            }
            using(StreamWriter writetext = new StreamWriter("adminpassword.txt",true))
            {
                writetext.WriteLine(admin_password);
            }
            using(StreamWriter writetext = new StreamWriter("adminname.txt",true))
            {
                writetext.WriteLine(admin_name);
            }
            using(StreamWriter writetext = new StreamWriter("adminsurname.txt",true))
            {
                writetext.WriteLine(admin_surname);
            }
            using(StreamWriter writetext = new StreamWriter("adminpesel.txt",true))
            {
                writetext.WriteLine(admin_pesel);
                
            }
            Environment.Exit(0);
           

            
        }
        public void admin_login()
        {

             int i = 1;
             int k = 1;
             string[] adminusernames = System.IO.File.ReadAllLines("adminusername.txt");
            foreach (string username in adminusernames)
            {

                if (temp_username == username) 
                {
                    string[] passwords = System.IO.File.ReadAllLines("adminpassword.txt");
                    
                    foreach (string password in passwords)
                    {
                        if (i == k ) 
                        {
                            if (temp_password == password)
                            {
                                Console.WriteLine("successfully logged in as a admin");
                                choice();
                            }    
                        }
                        k++;
                        
                    }
                }
                i++;

            }
            
            return;
        }

        public void list_admin()
        {
            Console.WriteLine("\nAdmin accounts listing...");
            string[] adminname = System.IO.File.ReadAllLines("adminname.txt");
            string[] adminsurname = System.IO.File.ReadAllLines("adminsurname.txt");
            
            for (int i = 0; i < adminname.Length; i++)
            {
                 Console.WriteLine($"Admin-{i} --->> Name: {adminname[i]} --- Surname: {adminsurname[i]}");
                 
            }
            return;
            
        }

        public void list_doctor()
        {
            Console.WriteLine("\nDoctor accounts listing...");


            CheckFile checkDoctor = new CheckFile();
            if (checkDoctor.checkDoctor()) return;
            string[] doctorname = System.IO.File.ReadAllLines("doctorname.txt");
            string[] doctorsurname = System.IO.File.ReadAllLines("doctorsurname.txt");
            string[] doctorspecialty = System.IO.File.ReadAllLines("doctorspecialty.txt");
            


            for (int i = 0; i < doctorname.Length; i++)
            {
                Console.WriteLine($"Doctor-{i} --->> Name: {doctorname[i]} --- Surname: {doctorsurname[i]} --- Specialty: {doctorspecialty[i]}");
               
            }

            if (!File.Exists("doctorschedule.txt")) return;
            string[] doctorschedule = System.IO.File.ReadAllLines("doctorschedule.txt");
            Console.WriteLine("\nSchedule Listing for Doctors...");
            for (int i = 0; i < doctorschedule.Length; i++)
            {
                 
                Console.WriteLine(doctorschedule[i]);
                
            }
            return;
        
        }
        public void list_nurse()
        {
            Console.WriteLine("\nNurse accounts listing...");

            CheckFile checkNurse = new CheckFile();
            if (checkNurse.checkNurse()) return;
            string[] nursename = System.IO.File.ReadAllLines("nursename.txt");  
            string[] nursesurname = System.IO.File.ReadAllLines("nursesurname.txt");
            
            for (int i = 0; i < nursename.Length; i++)
            {
                Console.WriteLine($"Nurse-{i} --->> Name: {nursename[i]} --- Surname: {nursesurname[i]}");
            }

            if (!File.Exists("nurseschedule.txt")) return;
            string[] nurseschedule = System.IO.File.ReadAllLines("nurseschedule.txt");
            Console.WriteLine("\nSchedule Listing for Nurses...");
            for (int i = 0; i < nurseschedule.Length; i++)
            {
                 
                Console.WriteLine(nurseschedule[i]);
                
            }
            return;
            
        }

        public void choice()
        {
            list_admin();
            list_doctor();
            list_nurse();
            Console.WriteLine("\n1-Create new user");
            Console.WriteLine("2-Edit exist user");
            Console.WriteLine("3-Delete exist user");
            Console.WriteLine("4-Edit Schedule");
            Console.Write("Enter: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                admin_panel_create();
                break;
                case 2:
                admin_panel_edit();
                
                break;
                case 3:
                admin_panel_delete();
                break;
                case 4:
                admin_panel_schedule();
                break;
            }
        }
        
        public void admin_panel_create()
        {
            Console.WriteLine("1-Create Admin account");
            Console.WriteLine("2-Create Doctor account");
            Console.WriteLine("3-Create Nurse account");
            Console.Write("Enter: ");
            int choice = int.Parse(Console.ReadLine());

            Create create = new Create();
            switch(choice)
            {
                case 1:
                create.createadmin();
                    break;
                case 2:              
                create.createdoctor();
                    break;
                case 3:
                create.createnurse();
                    break;        
            }
            
            
        }
        public void admin_panel_delete()
        {
            Edit deleteuser = new Edit();
            deleteuser.delete();
        }
        public void admin_panel_edit()
        {
            Edit edituser = new Edit();
            edituser.edit();
        }
        public void admin_panel_schedule()
        {
            Edit edituser = new Edit();
            edituser.schedule();
        }
    }
}
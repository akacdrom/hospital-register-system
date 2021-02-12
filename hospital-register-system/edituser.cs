using System;
using System.IO;
using System.Linq;
namespace hospital_system
{
    public class Edit
    {
        public string edit_username;
        public int row_number;
        public string delete_date;
        
        
        public void edit()
        {
            Console.WriteLine("Write username for EDIT account..");
            Console.Write("Username: ");
            edit_username = Console.ReadLine();
            Create create = new Create();
            if(findAdmin()) {deleteAdmin(); create.createadmin(); Environment.Exit(0);}
            else if (findDoctor()) {deleteDoctor(); create.createdoctor(); Environment.Exit(0);}
            else if (findNurse()) {deleteNurse(); create.createnurse(); Environment.Exit(0);}
            else {Console.WriteLine("Username could not found in system"); Environment.Exit(0);}
        }

        
        public void delete()
        {
            Console.WriteLine("Write username for DELETE account..");
            Console.Write("Username: ");
            edit_username = Console.ReadLine();
            if(findAdmin()) {deleteAdmin();  Environment.Exit(0);}
            else if (findDoctor()) {deleteDoctor(); Environment.Exit(0);}
            else if (findNurse()) {deleteNurse(); Environment.Exit(0);}
            else {Console.WriteLine("Username could not found in system"); Environment.Exit(0);}
        }

        public void schedule()
        {
            Console.WriteLine("Write username for edit SCHEDULE..");

            Console.Write("Username: ");
            edit_username = Console.ReadLine();

            Console.Write($"Do you want DELETE a record for this user '{edit_username}' (yes): ");
            string yes = Console.ReadLine();
            if (yes == "yes")
            {
                Console.Write("Write a date you want delete: ");
                delete_date = Console.ReadLine();
                if (findDoctor()) {deleteScheduleDoctor(); Environment.Exit(0);}
                else if (findNurse()) {deleteScheduleNurse(); Environment.Exit(0);}
            }
            
            if (findDoctor()) {editScheduleDoctor(); Environment.Exit(0);}
            else if (findNurse()) {editScheduleNurse(); Environment.Exit(0);}
            else {Console.WriteLine("Username could not found in system"); Environment.Exit(0);}
        }


        public void deleteAdmin()
        {
            string[] adminusername = System.IO.File.ReadAllLines("adminusername.txt");
            string[] adminpassword = System.IO.File.ReadAllLines("adminpassword.txt");
            string[] adminname = System.IO.File.ReadAllLines("adminname.txt");
            string[] adminsurname = System.IO.File.ReadAllLines("adminsurname.txt");
            string[] adminpesel = System.IO.File.ReadAllLines("adminpesel.txt");
            File.WriteAllText("adminusername.txt", String.Empty);
            File.WriteAllText("adminpassword.txt", String.Empty);
            File.WriteAllText("adminname.txt", String.Empty);
            File.WriteAllText("adminsurname.txt", String.Empty);
            File.WriteAllText("adminpesel.txt", String.Empty);
            
            using (StreamWriter writer = new StreamWriter("adminusername.txt")){
            using (StreamWriter writer2 = new StreamWriter("adminpassword.txt")){
            using (StreamWriter writer3 = new StreamWriter("adminname.txt")){
            using (StreamWriter writer4 = new StreamWriter("adminsurname.txt")){
            using (StreamWriter writer5 = new StreamWriter("adminpesel.txt")){
            
               
                for (int i = 0; i < adminusername.Length; i++)
                {
                    if (i != row_number)
                    {
                        writer.WriteLine(adminusername[i]);
                        writer2.WriteLine(adminpassword[i]);
                        writer3.WriteLine(adminname[i]);
                        writer4.WriteLine(adminsurname[i]);
                        writer5.WriteLine(adminpesel[i]);
                    }
                    
                }
            }}}}}
            
           
        Console.WriteLine("Account is deleted");        
        }

        public void deleteDoctor()
        {
            string[] doctorusername = System.IO.File.ReadAllLines("doctorusername.txt");
            string[] doctorpassword = System.IO.File.ReadAllLines("doctorpassword.txt");
            string[] doctorname = System.IO.File.ReadAllLines("doctorname.txt");
            string[] doctorsurname = System.IO.File.ReadAllLines("doctorsurname.txt");
            string[] doctorpesel = System.IO.File.ReadAllLines("doctorpesel.txt");
            string[] doctorspecialty = System.IO.File.ReadAllLines("doctorspecialty.txt");
            string[] doctorpwz = System.IO.File.ReadAllLines("doctorpwz.txt");
            File.WriteAllText("doctorusername.txt", String.Empty);
            File.WriteAllText("doctorpassword.txt", String.Empty);
            File.WriteAllText("doctorname.txt", String.Empty);
            File.WriteAllText("doctorsurname.txt", String.Empty);
            File.WriteAllText("doctorpesel.txt", String.Empty);
            File.WriteAllText("doctorspecialty.txt", String.Empty);
            File.WriteAllText("doctorpwz.txt", String.Empty);
            
            using (StreamWriter writer = new StreamWriter("doctorusername.txt")){
            using (StreamWriter writer2 = new StreamWriter("doctorpassword.txt")){
            using (StreamWriter writer3 = new StreamWriter("doctorname.txt")){
            using (StreamWriter writer4 = new StreamWriter("doctorsurname.txt")){
            using (StreamWriter writer5 = new StreamWriter("doctorpesel.txt")){
            using (StreamWriter writer6 = new StreamWriter("doctorspecialty.txt")){
            using (StreamWriter writer7 = new StreamWriter("doctorpwz.txt")){
               
                for (int i = 0; i < doctorusername.Length; i++)
                {
                    if (i != row_number)
                    {
                        writer.WriteLine(doctorusername[i]);
                        writer2.WriteLine(doctorpassword[i]);
                        writer3.WriteLine(doctorname[i]);
                        writer4.WriteLine(doctorsurname[i]);
                        writer5.WriteLine(doctorpesel[i]);
                        writer6.WriteLine(doctorspecialty[i]);
                        writer7.WriteLine(doctorpwz[i]);
                    }
                    
                }
            }}}}}}}
            
           
        Console.WriteLine("Account is deleted"); 
        }

        public void deleteNurse()
        {
            string[] nurseusername = System.IO.File.ReadAllLines("nurseusername.txt");
            string[] nursepassword = System.IO.File.ReadAllLines("nursepassword.txt");
            string[] nursename = System.IO.File.ReadAllLines("nursename.txt");
            string[] nursesurname = System.IO.File.ReadAllLines("nursesurname.txt");
            string[] nursepesel = System.IO.File.ReadAllLines("nursepesel.txt");
            File.WriteAllText("nurseusername.txt", String.Empty);
            File.WriteAllText("nursepassword.txt", String.Empty);
            File.WriteAllText("nursename.txt", String.Empty);
            File.WriteAllText("nursesurname.txt", String.Empty);
            File.WriteAllText("nursepesel.txt", String.Empty);
            
            using (StreamWriter writer = new StreamWriter("nurseusername.txt")){
            using (StreamWriter writer2 = new StreamWriter("nursepassword.txt")){
            using (StreamWriter writer3 = new StreamWriter("nursename.txt")){
            using (StreamWriter writer4 = new StreamWriter("nursesurname.txt")){
            using (StreamWriter writer5 = new StreamWriter("nursepesel.txt")){
            
               
                for (int i = 0; i < nurseusername.Length; i++)
                {
                    if (i != row_number)
                    {
                        writer.WriteLine(nurseusername[i]);
                        writer2.WriteLine(nursepassword[i]);
                        writer3.WriteLine(nursename[i]);
                        writer4.WriteLine(nursesurname[i]);
                        writer5.WriteLine(nursepesel[i]);
                    }
                    
                }
            }}}}}
            
           
        Console.WriteLine("Account is deleted");        
        }


        public void deleteScheduleDoctor()
        {
            if (!File.Exists("doctorschedule.txt")) {Console.WriteLine("There is no record to delete"); Environment.Exit(0);}
            string[] doctorschedule = System.IO.File.ReadAllLines("doctorschedule.txt");


            for (int i = 0; i < doctorschedule.Length; i++)
          
            {
                

                if (doctorschedule[i].Contains(edit_username) && doctorschedule[i].Contains(delete_date))
                {
                    Console.WriteLine(doctorschedule[i] + "-----  "+i);

                    File.WriteAllText("doctorschedule.txt", String.Empty);

                    using (StreamWriter writer = new StreamWriter("doctorschedule.txt"))
                    {
                        for (int k = 0; k < doctorschedule.Length; k++)
                        {
                            if (i != k)
                            {
                                writer.WriteLine(doctorschedule[k]);
                          
                            }
                            
                        }
                    }
                    
                    
                }
            }
            Environment.Exit(0);
          
        }

        public void deleteScheduleNurse()
        {
            if (!File.Exists("nurseschedule.txt")) {Console.WriteLine("There is no record to delete"); Environment.Exit(0);}
            string[] nurseschedule = System.IO.File.ReadAllLines("nurseschedule.txt");


            for (int i = 0; i < nurseschedule.Length; i++)
          
            {
                

                if (nurseschedule[i].Contains(edit_username) && nurseschedule[i].Contains(delete_date))
                {
                    Console.WriteLine(nurseschedule[i] + "-----  "+i);

                    File.WriteAllText("nurseschedule.txt", String.Empty);

                    using (StreamWriter writer = new StreamWriter("nurseschedule.txt"))
                    {
                        for (int k = 0; k < nurseschedule.Length; k++)
                        {
                            if (i != k)
                            {
                                writer.WriteLine(nurseschedule[k]);
                          
                            }
                            
                        }
                    }
                    
                    
                }
            }
            Environment.Exit(0);
          
        }


        public void editScheduleDoctor()
        {
            Console.Write("Write for next 24-hour on-call duty date: ");
            string callduty = Console.ReadLine();
            string[] doctorspecialty = System.IO.File.ReadAllLines("doctorspecialty.txt");
            if (File.Exists("doctorschedule.txt"))
            {
            string[] doctorschedule = System.IO.File.ReadAllLines("doctorschedule.txt");
            
            string text = System.IO.File.ReadAllText("doctorschedule.txt");
            int count = 1;
            for (int i = 0; i < doctorschedule.Length; i++)
            {
                
                string[] dates = doctorschedule[i].Split('/');
                var day = dates[0].Split().Last();
                var month = dates[1];
                var year = dates[2];
               
                string[] dates2 = callduty.Split('/');
                var day2 = dates2[0];
                var month2 = dates2[1];
                var year2 = dates2[2];

                int intday = int.Parse(day);
                int intday2 = int.Parse(day2);

                if ( doctorschedule[i].Contains(edit_username))
                {
                       
                    if(month == month2) 
                    {

                        if  (intday2 == intday+1 || intday == intday2 || intday2+1 == intday)
                        {
 
                            Console.WriteLine("You can't make 24-hour duty day by day"); 
                            return;
                            
                        }
                        count++;
                        if (count > 10) 
                        {Console.WriteLine("You cant take more 24-hour duty in this month for this user"); return;}
                  
                    }
         
                }

                if (intday == intday2 && month == month2)
                {
                    for (int k = 0; k < doctorspecialty.Length; k++)
                    {
                        if ( k == row_number) 
                        {
                            if (text.Contains(doctorspecialty[k]))
                            {
                                Console.WriteLine("There is already the same specialization doctor for this date.");
                                return;
                            }
                        }
                    }

                    
                }

            }
            }

            string[] doctorname = System.IO.File.ReadAllLines("doctorname.txt");
            string[] doctorsurname = System.IO.File.ReadAllLines("doctorsurname.txt");
            string[] doctorusername = System.IO.File.ReadAllLines("doctorusername.txt");
            
            for (int i = 0; i < doctorname.Length; i++)
            {
                if (i == row_number)
                {
                    using(StreamWriter writetext = new StreamWriter("doctorschedule.txt",true))
                    {

                        writetext.WriteLine($"Doctor-{i} --->> Username: {doctorusername[i]} --- Name: {doctorname[i]} --- Surname: {doctorsurname[i]} --- Specialty: {doctorspecialty[i]} ---  24-hour on-call duty date: {callduty}");
                    }
                }
            }
            
        }
        public void editScheduleNurse()
        {
            Console.Write("Write for next 24-hour on-call duty date: ");
            string callduty = Console.ReadLine();
            if (File.Exists("nurseschedule.txt"))
            {
            string[] nurseschedule = System.IO.File.ReadAllLines("nurseschedule.txt");
            int count = 1;
            for (int i = 0; i < nurseschedule.Length; i++)
            {
                
                string[] dates = nurseschedule[i].Split('/');
                var day = dates[0].Split().Last();
                var month = dates[1];
                var year = dates[2];
    
                string[] dates2 = callduty.Split('/');
                var day2 = dates2[0];
                var month2 = dates2[1];
                var year2 = dates2[2];

                int intday = int.Parse(day);
                int intday2 = int.Parse(day2);

                if ( nurseschedule[i].Contains(edit_username))
                {

                    if(month == month2) 
                    {

                        if  (intday2 == intday+1 || intday == intday2 || intday2+1 == intday)
                        {
                            
                            Console.WriteLine("You can't make 24-hour duty day by day"); 
                            return;
                            
                        }
                        count++;
                        if (count > 10) 
                        {Console.WriteLine("You cant take more 24-hour duty in this month for this user"); return;}
                    }
                    
                    
                }
                
                
            }
            }
            string[] nursename = System.IO.File.ReadAllLines("nursename.txt");
            string[] nursesurname = System.IO.File.ReadAllLines("nursesurname.txt");
            string[] nurseusername = System.IO.File.ReadAllLines("nurseusername.txt");
            for (int i = 0; i < nursename.Length; i++)
            {
                if (i == row_number)
                {
                    using(StreamWriter writetext = new StreamWriter("nurseschedule.txt",true))
                    {

                        writetext.WriteLine($"Nurse-{i} --->> Username: {nurseusername[i]} Name: {nursename[i]} --- Surname: {nursesurname[i]} ---  24-hour on-call duty date: {callduty}");
                    }
                }
            }
            
        }

        public void checkDate()
        {
            string[] nurseschedule = System.IO.File.ReadAllLines("nurseschedule.txt");
            for (int i = 0; i < nurseschedule.Length; i++)
            {
                string[] dates = nurseschedule[i].Split('/');
                var day = dates[0].Split().Last();
                var month = dates[1];
                var year = dates[2];
                Console.WriteLine($"{day} + {month} + {year}");
                
                 
            }

        }

        public bool findAdmin()
        {
            string[] adminusername = System.IO.File.ReadAllLines("adminusername.txt");
            for (int i = 0; i < adminusername.Length; i++)
            {
                if(adminusername[i] == edit_username)
                {
                    row_number = i;   
                    return true;
                }
                
            }
            return false;
        }
        public bool findDoctor()
        {
            string[] doctorusername = System.IO.File.ReadAllLines("doctorusername.txt");
            for (int i = 0; i < doctorusername.Length; i++)
            {
                if(doctorusername[i] == edit_username)
                {
                    row_number = i;
                    return true;
                }
                
            }
            return false;
        }
        public bool findNurse()
        {
            string[] nurseusername = System.IO.File.ReadAllLines("nurseusername.txt");
            for (int i = 0; i < nurseusername.Length; i++)
            {
                if(nurseusername[i] == edit_username)
                {
                    row_number = i;
                    return true;
                }   
            }
            return false;
        }
       
    }
}
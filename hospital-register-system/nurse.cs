using System;
using System.IO;

namespace hospital_system
{
    public class NurseClass
    {
        public string nurse_username;
        public string nurse_password;
        public string nurse_name;
        public string nurse_surname;
        public string nurse_pesel;     
        public string temp_username;
        public string temp_password;
        public void writeNurse()
        {

            using(StreamWriter writetext = new StreamWriter("nurseusername.txt",true))
            {
                writetext.WriteLine(nurse_username);
            }
            using(StreamWriter writetext = new StreamWriter("nursepassword.txt",true))
            {
                writetext.WriteLine(nurse_password);
            }
            using(StreamWriter writetext = new StreamWriter("nursename.txt",true))
            {
                writetext.WriteLine(nurse_name);
            }
            using(StreamWriter writetext = new StreamWriter("nursesurname.txt",true))
            {
                writetext.WriteLine(nurse_surname);
            }
            using(StreamWriter writetext = new StreamWriter("nursepesel.txt",true))
            {
                writetext.WriteLine(nurse_pesel);
            }
            Environment.Exit(0);

        }
        public void nuse_login()
        {
            CheckFile checkNurse = new CheckFile();
            if (checkNurse.checkNurse()) return;

            int i = 1;
            int k = 1;
            string[] nurseusernames = System.IO.File.ReadAllLines("nurseusername.txt");
            foreach (string username in nurseusernames)
            {

                if (temp_username == username) 
                {
                    string[] passwords = System.IO.File.ReadAllLines("nursepassword.txt");
                    
                    foreach (string password in passwords)
                    {
                        if (i == k ) {
                            if (temp_password == password)
                                Console.WriteLine("successfully logged in as a nurse");
                                AdminClass admin = new AdminClass();
                                admin.list_nurse();
                                admin.list_doctor();
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
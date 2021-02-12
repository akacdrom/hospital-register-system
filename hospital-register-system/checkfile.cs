using System;
using System.IO;
using System.Linq;
namespace hospital_system
{
    public class CheckFile
    {
        
        public void checkAdmin()
        {
            var fi = new FileInfo("adminusername.txt");
            var fi2 = new FileInfo("adminpassword.txt");
            var fi3 = new FileInfo("adminname.txt");
            var fi4 = new FileInfo("adminsurname.txt");
            var fi5 = new FileInfo("adminpesel.txt");

            if(!File.Exists("adminusername.txt") || !File.Exists("adminpassword.txt") || !File.Exists("adminname.txt") || !File.Exists("adminsurname.txt") || !File.Exists("adminpesel.txt") ||
            fi.Length == 0 || fi.Length < 100000 && !File.ReadAllLines("adminusername.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi2.Length == 0 || fi2.Length < 100000 && !File.ReadAllLines("adminpassword.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi3.Length == 0 || fi3.Length < 100000 && !File.ReadAllLines("adminname.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi4.Length == 0 || fi4.Length < 100000 && !File.ReadAllLines("adminsurname.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi5.Length == 0 || fi5.Length < 100000 && !File.ReadAllLines("adminpesel.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any()
            )
            {
                Console.WriteLine("Admin account not found in the system");

                string[] fileList = System.IO.Directory.GetFiles(Environment.CurrentDirectory,"admin*.txt");
                foreach(string file in fileList)
                {
                    Console.WriteLine(file + "---- > deleting orphan information for nurse accounts (Files is missing or empty files)");
                    System.IO.File.Delete(file);
                }

                Create create = new Create();
                create.createadmin();
            }
        }
        public bool checkDoctor()
        {
            var fi = new FileInfo("doctorusername.txt");
            var fi2 = new FileInfo("doctorpassword.txt");
            var fi3 = new FileInfo("doctorname.txt");
            var fi4 = new FileInfo("doctorsurname.txt");
            var fi5 = new FileInfo("doctorpesel.txt");
            var fi6 = new FileInfo("doctorpwz.txt");
            var fi7 = new FileInfo("doctorspecialty.txt");
            

            if(!File.Exists("doctorusername.txt") || !File.Exists("doctorpassword.txt") || !File.Exists("doctorname.txt") || !File.Exists("doctorsurname.txt") || !File.Exists("doctorpesel.txt") || !File.Exists("doctorpwz.txt") || !File.Exists("doctorspecialty.txt") ||
            fi.Length == 0 || fi.Length < 100000 && !File.ReadAllLines("doctorusername.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi2.Length == 0 || fi2.Length < 100000 && !File.ReadAllLines("doctorpassword.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi3.Length == 0 || fi3.Length < 100000 && !File.ReadAllLines("doctorname.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi4.Length == 0 || fi4.Length < 100000 && !File.ReadAllLines("doctorsurname.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi5.Length == 0 || fi5.Length < 100000 && !File.ReadAllLines("doctorpesel.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi6.Length == 0 || fi6.Length < 100000 && !File.ReadAllLines("doctorpwz.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi7.Length == 0 || fi7.Length < 100000 && !File.ReadAllLines("doctorspecialty.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any()
            )
            {
                Console.WriteLine("Doctor account not found in the system");

                string[] fileList = System.IO.Directory.GetFiles(Environment.CurrentDirectory,"doctor*.txt");
                foreach(string file in fileList)
                {
                    Console.WriteLine(file + "---- > deleting orphan information for doctor accounts (Files is missing or empty files)");
                    System.IO.File.Delete(file);
                    
                    
                }
                return true;
            
                
            }
            return false;
        }
        public bool checkNurse()
        {
            var fi = new FileInfo("nurseusername.txt");
            var fi2 = new FileInfo("nursepassword.txt");
            var fi3 = new FileInfo("nursename.txt");
            var fi4 = new FileInfo("nursesurname.txt");
            var fi5 = new FileInfo("nursepesel.txt");

            if(!File.Exists("nurseusername.txt") || !File.Exists("nursepassword.txt") || !File.Exists("nursename.txt") || !File.Exists("nursesurname.txt") || !File.Exists("nursepesel.txt") ||
            fi.Length == 0 || fi.Length < 100000 && !File.ReadAllLines("nurseusername.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi2.Length == 0 || fi2.Length < 100000 && !File.ReadAllLines("nursepassword.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi3.Length == 0 || fi3.Length < 100000 && !File.ReadAllLines("nursename.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi4.Length == 0 || fi4.Length < 100000 && !File.ReadAllLines("nursesurname.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any() ||
            fi5.Length == 0 || fi5.Length < 100000 && !File.ReadAllLines("nursepesel.txt").Where(l => !String.IsNullOrEmpty(l.Trim())).Any()
            )
            {
                Console.WriteLine("Nurse account not found in the system");

                string[] fileList = System.IO.Directory.GetFiles(Environment.CurrentDirectory,"nurse*.txt");
                foreach(string file in fileList)
                {
                    Console.WriteLine(file + "---- > deleting orphan information for nurse accounts (Files is missing or empty files)");
                    System.IO.File.Delete(file);
                    
                    
                }
                
                return true;
                
            }
            return false;

        }
       
    }
}

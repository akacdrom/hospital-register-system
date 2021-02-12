using System;
using System.IO;
using System.Linq;
namespace hospital_system
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            CheckFile checkAdmin = new CheckFile();
            checkAdmin.checkAdmin();
            checkAdmin.checkDoctor();
            checkAdmin.checkNurse();
            
            Console.WriteLine("LOG-IN TO SYSTEM");
            Console.Write("Username:");
            string temp_username = Console.ReadLine();
            Console.Write("Password:");
            string temp_password = Console.ReadLine();

            AdminClass admin = new AdminClass();
            admin.temp_password = temp_password;
            admin.temp_username = temp_username;
            admin.admin_login();

            DoctorClass doctor = new DoctorClass();
            doctor.temp_username = temp_username;
            doctor.temp_password = temp_password;
            doctor.doctor_login();

            NurseClass nurse = new NurseClass();
            nurse.temp_username = temp_username;
            nurse.temp_password = temp_password;
            nurse.nuse_login();
            Console.WriteLine("Username or password is not correct !");
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //To  Test UserManagementModule
            UserManagementModule.AddUser("Sumalatha");
            UserManagementModule.DeleteUser("Sumalatha");

            // To Test FileProcessingModule
            FileProcessingModule.ProcessFile("example.txt");

            // To Test Logging from MySharedLibrary
            SharedLibrary.UtilityMethods.Log("This is a log message Please cCheck it.");

            //To Test Encryption from MySharedLibrary
            string data = "Original Dataa";
            string encryptedData = SharedLibrary.UtilityMethods.EncryptData(data);
            Console.WriteLine($"Encrypted Data: {encryptedData}");
        }
    }
}
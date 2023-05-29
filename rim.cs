using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace HospitalRegistration
{
    class Patient
    {
        public int RegistrationID { get; set; }
        public string AadharNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
              
    }

    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<string> passwordList = new List<string>();
        static void Main()
        {
        
            while (true)
            {
                Console.WriteLine("---------------------------------HOSPITAL PORTAL----------------------------");
                Console.WriteLine("");
                Console.WriteLine("1. Hospital staff login");
                Console.WriteLine("2. Patient Detail");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice (1-3):");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter password to login");
                        string userpass = Console.ReadLine();
                        passwordList.Add("111");
                        passwordList.Add("222");
                        passwordList.Add("333");
                        if (AuthenticateUser(userpass))
                        {
                            while(true)
                            {   
                                Console.WriteLine(" ");
                                Console.WriteLine("1.Register new patient ");
                                Console.WriteLine("2.Display all Patient details ");
                                Console.WriteLine("3.Specific Patient detail");
                                Console.WriteLine("4. Exit"); 
                                Console.WriteLine("Enter your choice (1-4):");
                                int option = int.Parse(Console.ReadLine());
                                switch(option)
                                {
                                    case 1:
                                        while(true)
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1.General Medicine ");
                                            Console.WriteLine("2.Ortho ");
                                            Console.WriteLine("3.Dental ");
                                            Console.WriteLine("4.Exit");
                                            Console.WriteLine("Enter your choice (1-4)");
                                            int depart = int.Parse(Console.ReadLine());
                                            switch(depart)
                                            {
                                                case 1:
                                                while(true)
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("General Medicine Record");
                                                    Console.WriteLine("1.Register Patient");
                                                    Console.WriteLine("2.Display Patient");
                                                    Console.WriteLine("3.Exit");
                                                    Console.WriteLine("Enter your choice (1-3)");
                                                    int gm = int.Parse(Console.ReadLine());
                                                    switch(gm)
                                                    {
                                                        case 1:
                                                        RegisterNewPatientGM();
                                                        continue;

                                                        case 2:
                                                        DisplayPatientDetails();
                                                        continue;
                                                        
                                                        case 3:
                                                        Environment.Exit(0);
                                                        break;
                      
                                                        default:
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        continue;

                                                    }
                                                }
                                                break;

                                                case 2:
                                                while(true)
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine(" Ortho Record");
                                                    Console.WriteLine("1.Register Patient");
                                                    Console.WriteLine("2.Display Patient");
                                                    Console.WriteLine("3.Exit");
                                                    Console.WriteLine("Enter your choice (1-3)");
                                                    int or = int.Parse(Console.ReadLine());
                                                    switch(or)
                                                    {
                                                        case 1:
                                                        RegisterNewPatientOr();
                                                        continue;

                                                        case 2:
                                                        DisplayPatientDetails();
                                                        continue;
                                                        
                                                        case 3:
                                                        Environment.Exit(0);
                                                        continue;
                     
                                                        default:
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        continue;

                                                    }
                                                }
                                                break;

                                                case 3:
                                                 while(true)
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine(" Dental Record");
                                                    Console.WriteLine("1.Register Patient");
                                                    Console.WriteLine("2.Display Patient");
                                                    Console.WriteLine("3.Exit");
                                                    Console.WriteLine("Enter your choice (1-3)");
                                                    int den = int.Parse(Console.ReadLine());
                                                    switch(den)
                                                    {
                                                        case 1:
                                                        RegisterNewPatientDen();
                                                        continue;

                                                        case 2:
                                                        DisplayPatientDetails();
                                                        continue;
                                                        
                                                        case 3:
                                                        Environment.Exit(0);
                                                        continue;
                     
                                                        default:
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        continue;

                                                    }
                                                }
                                                continue;

                                                case 4:
                                                Environment.Exit(0);
                                                continue;
                     
                                                default:
                                                Console.WriteLine("Invalid choice. Please try again.");
                                                continue;

                                            }

                                        }
                
                                    
                                    continue;

                                    case 2:
                                    DisplayPatientDetails();
                                    continue;

                                    case 3:
                                    DisplaySpecificPatientDetails();
                                    continue;

                                    case 4:
                                    Environment.Exit(0);
                                    continue;
                     
                                    default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    continue;

                                }
                                
                                
                            }
                                                      
                        }
                        else
                        {
                        Console.WriteLine("Invalid password.");
                        }
                                               
                        break;
                    case 2:
                        DisplaySpecificPatientDetails();
                        break;

                    case 3:
                            Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayPatientDetails()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patient data available.");
                return;
            }

            foreach (var patient in patients)
            {
                Console.WriteLine("Registration ID: " + patient.RegistrationID);
                Console.WriteLine("First Name: " + patient.FirstName);
                Console.WriteLine("Last Name: " + patient.LastName);
                Console.WriteLine("Phone No: " + patient.PhoneNo);
                Console.WriteLine("Gender: " + patient.Gender);
                Console.WriteLine("Age: " + patient.Age);
                Console.WriteLine("Address: " + patient.Address);
                Console.WriteLine("Aadhar No: " + patient.AadharNo);
                Console.WriteLine("------------------------");
            }
        }
         static void DisplaySpecificPatientDetails()
        {   
             Patient newPatient = new Patient();
             
            Console.WriteLine("Enter Aadhar No:");
            string n = Console.ReadLine();
             if (patients.Count == 0)
            {
                Console.WriteLine("No patient data available.");
                return;
            }
            foreach (var patient in patients)
            {    
                if (patient.AadharNo == n)
                {
                             
                Console.WriteLine("Registration ID: " + patient.RegistrationID);
                Console.WriteLine("First Name: " + patient.FirstName);
                Console.WriteLine("Last Name: " + patient.LastName);
                Console.WriteLine("Phone No: " + patient.PhoneNo);
                Console.WriteLine("Gender: " + patient.Gender);
                Console.WriteLine("Age: " + patient.Age);
                Console.WriteLine("Address: " + patient.Address);
                Console.WriteLine("Aadhar No: " + patient.AadharNo);
                Console.WriteLine("------------------------");
                }
               
            }
        }

        static void RegisterNewPatientGM()
        {
            Patient newPatient = new Patient();
            
            Console.WriteLine("Enter Aadhar No:");
            newPatient.AadharNo = Console.ReadLine();
            if (IsValidAadharNumber( newPatient.AadharNo))
            {
            }
            else
            {
             do{
            Console.WriteLine("Invalid Aadhar number.");
            Console.WriteLine("Enter Asdhar Name:");
            newPatient.AadharNo = Console.ReadLine();
            }while(!IsValidAadharNumber( newPatient.AadharNo));
            }
            if (IsDuplicatePatient(newPatient))
            {
                Console.WriteLine("A patient with the same Aadhar card already exists.");
                return;
            }
            
            
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            if (IsValidName( newPatient.FirstName))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid First name.");
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            }while(!IsValidName( newPatient.FirstName));
            }
            
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            if (IsValidName( newPatient.LastName))
            {
            }
            else
            {
            do{    
            Console.WriteLine("Invalid Last name.");
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            }while(!IsValidName( newPatient.LastName));
            }

            Console.WriteLine("Enter Phone No:");
            newPatient.PhoneNo = Console.ReadLine();
            if (IsValidPhoneNumber(newPatient.PhoneNo))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid phone number.");
            Console.WriteLine("Enter phone number:");
            newPatient.PhoneNo = Console.ReadLine();
            }while(!IsValidPhoneNumber( newPatient.PhoneNo));
            }

            Console.WriteLine("Enter Gender :");
            Console.WriteLine("Male");
            Console.WriteLine("Female");
            Console.WriteLine("Other");
            newPatient.Gender = Console.ReadLine();
            

            Console.WriteLine("Enter Age:");
            newPatient.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            newPatient.Address = Console.ReadLine();

                       
            newPatient.RegistrationID = GenerateRegistrationID();
            patients.Add(newPatient);

            Console.WriteLine("Patient registered successfully. Registration ID: " + newPatient.RegistrationID);
        }

        static bool IsDuplicatePatient(Patient newPatient)
        {
            foreach (var patient in patients)
            {
                if (patient.AadharNo == newPatient.AadharNo)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateRegistrationID()
        {
            int maxRegistrationID = 0;
            foreach (var patient in patients)
            {
                if (patient.RegistrationID > maxRegistrationID)
                {
                    maxRegistrationID = patient.RegistrationID;
                }
            }
            return maxRegistrationID + 1;
        }
        static bool IsValidAadharNumber(string AadharNo)
        {
        
        Regex regex = new Regex(@"^[0-9]{4}[-\s]?[0-9]{4}[-\s]?[0-9]{4}$");

        if (regex.IsMatch(AadharNo))
        {
            return true;
        }

        return false;
        }
        static bool IsValidName(string name)
        {
        
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (regex.IsMatch(name))
        {
            return true;
        }

        return false;
        }
        static bool IsValidPhoneNumber(string phoneNumber)
        {
        
        Regex regex = new Regex(@"^[0-9]{3}[-\s]?[0-9]{3}[-\s]?[0-9]{4}$");

        if (regex.IsMatch(phoneNumber))
        {
            return true;
        }

        return false;
        }
        static bool AuthenticateUser(string password)
    {
        
        if (passwordList.Contains(password))
        {
            return true;
        }

        return false;
    }
    static void RegisterNewPatientOr()
        {
            Patient newPatient = new Patient();
            
            Console.WriteLine("Enter Aadhar No:");
            newPatient.AadharNo = Console.ReadLine();
            if (IsValidAadharNumber( newPatient.AadharNo))
            {
            }
            else
            {
             do{
            Console.WriteLine("Invalid Aadhar number.");
            Console.WriteLine("Enter Asdhar Name:");
            newPatient.AadharNo = Console.ReadLine();
            }while(!IsValidAadharNumber( newPatient.AadharNo));
            }
            if (IsDuplicatePatient(newPatient))
            {
                Console.WriteLine("A patient with the same Aadhar card already exists.");
                return;
            }
            
            
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            if (IsValidName( newPatient.FirstName))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid First name.");
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            }while(!IsValidName( newPatient.FirstName));
            }
            
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            if (IsValidName( newPatient.LastName))
            {
            }
            else
            {
            do{    
            Console.WriteLine("Invalid Last name.");
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            }while(!IsValidName( newPatient.LastName));
            }

            Console.WriteLine("Enter Phone No:");
            newPatient.PhoneNo = Console.ReadLine();
            if (IsValidPhoneNumber(newPatient.PhoneNo))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid phone number.");
            Console.WriteLine("Enter phone number:");
            newPatient.PhoneNo = Console.ReadLine();
            }while(!IsValidPhoneNumber( newPatient.PhoneNo));
            }

            Console.WriteLine("Enter Gender :");
            Console.WriteLine("Male");
            Console.WriteLine("Female");
            Console.WriteLine("Other");
            newPatient.Gender = Console.ReadLine();
            

            Console.WriteLine("Enter Age:");
            newPatient.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            newPatient.Address = Console.ReadLine();

                       
            newPatient.RegistrationID = GenerateRegistrationID();
            patients.Add(newPatient);

            Console.WriteLine("Patient registered successfully. Registration ID: " + newPatient.RegistrationID);
       
    }
    static void RegisterNewPatientDen()
        {
            Patient newPatient = new Patient();
            
            Console.WriteLine("Enter Aadhar No:");
            newPatient.AadharNo = Console.ReadLine();
            if (IsValidAadharNumber( newPatient.AadharNo))
            {
            }
            else
            {
             do{
            Console.WriteLine("Invalid Aadhar number.");
            Console.WriteLine("Enter Asdhar Name:");
            newPatient.AadharNo = Console.ReadLine();
            }while(!IsValidAadharNumber( newPatient.AadharNo));
            }
            if (IsDuplicatePatient(newPatient))
            {
                Console.WriteLine("A patient with the same Aadhar card already exists.");
                return;
            }
            
            
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            if (IsValidName( newPatient.FirstName))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid First name.");
            Console.WriteLine("Enter First Name:");
            newPatient.FirstName = Console.ReadLine();
            }while(!IsValidName( newPatient.FirstName));
            }
            
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            if (IsValidName( newPatient.LastName))
            {
            }
            else
            {
            do{    
            Console.WriteLine("Invalid Last name.");
            Console.WriteLine("Enter Last Name:");
            newPatient.LastName = Console.ReadLine();
            }while(!IsValidName( newPatient.LastName));
            }

            Console.WriteLine("Enter Phone No:");
            newPatient.PhoneNo = Console.ReadLine();
            if (IsValidPhoneNumber(newPatient.PhoneNo))
            {
            }
            else
            {
            do{
            Console.WriteLine("Invalid phone number.");
            Console.WriteLine("Enter phone number:");
            newPatient.PhoneNo = Console.ReadLine();
            }while(!IsValidPhoneNumber( newPatient.PhoneNo));
            }

            Console.WriteLine("Enter Gender :");
            Console.WriteLine("Male");
            Console.WriteLine("Female");
            Console.WriteLine("Other");
            newPatient.Gender = Console.ReadLine();
            

            Console.WriteLine("Enter Age:");
            newPatient.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address:");
            newPatient.Address = Console.ReadLine();

                       
            newPatient.RegistrationID = GenerateRegistrationID();
            patients.Add(newPatient);

            Console.WriteLine("Patient registered successfully. Registration ID: " + newPatient.RegistrationID);
        }

        
    
        
    }
}

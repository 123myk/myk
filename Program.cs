using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Assignment_16
{
    public class Medicine 
    { 
        public int MedID { get; set; }
        public string MedName { get; set; }
        public double MedPrice { get; set; }

        public Medicine(int medID, string medName, double medPrice)
        {
            MedID = medID;
            MedName = medName;
            MedPrice = medPrice;
        }
    }
    public class BillManagement
    {

        static  List<Medicine> medicineList = new List<Medicine>();
        static BillManagement()
        {


            do
            {
                Console.WriteLine("\nEnter Medicine Id (0 to exist): ");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id == 0)
                    break;
                Console.WriteLine("Enter Medicine Name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Medicine Price : ");
                double price = Convert.ToDouble(Console.ReadLine());

                Medicine newMed = new Medicine(id, name, price);
                medicineList.Add(newMed);

                Console.WriteLine("Medicine Added Successfully!!");


            }while(true);
            Console.WriteLine("\nMedicines in the List : ");
            foreach (Medicine med in medicineList)
            {
                Console.WriteLine("Medicine Id : " + med.MedID + "\nName : " + med.MedName + "\nPrice : " + med.MedPrice);
            }
        }
        public void Price()
        {
            Console.WriteLine("Enter medicice Id");
            int n=int.Parse(Console.ReadLine());
            foreach (var medicine in medicineList)
            {
                if(medicine.MedID==n)
                {
                    string medn = medicine.MedName;
                    //Console.WriteLine("Name"+medicine.MedName);

                    double medprice = medicine.MedPrice;
                    //Console.WriteLine("Price"+medicine.MedPrice);
                }
            }
        }
        public void Discount()
        {
            Console.WriteLine("Enter Medicine Id : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            if(Id == medicineList[0].MedID)
            {
                if (medicineList[0].MedPrice < 100)
                {
                    Console.WriteLine("No Discount");
                    Console.Write("Medicine Amount : " + medicineList[0].MedPrice);
                }
                else if (medicineList[0].MedPrice > 100 || medicineList[0].MedPrice < 200)
                {
                    Console.Write("Medicine Price : " + medicineList[0].MedPrice);
                    double discount = medicineList[0].MedPrice * 5 / 100;
                    double total = medicineList[0].MedPrice - discount;
                    Console.Write("Price After Discount : " + total);
                }
                else if (medicineList[0].MedPrice > 200 || medicineList[0].MedPrice <300)
                {
                    Console.Write("Medicine Price : " + medicineList[0].MedPrice);
                    double discount = medicineList[0].MedPrice * 5 / 100;
                    double total = medicineList[0].MedPrice - discount;
                    Console.Write("Price After Discount : " + total);
                }
            }

            
        }
        public void DiscountMed()
        {

        }

        public double Total()
        {
            return 0;
        }

    }

    public class StartUp
    {
        static void Main(string[] args)
        {
            BillManagement obj = new BillManagement();
            obj.Price();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.ComponentModel.Design;
using System.Net.Security;
using System.Xml.Schema;

namespace assignment_222222222222222
{
    public class Program
    {
        static void Main()
        {

           
            if (true)
            {
            LoopExpression:
                Menu();


                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1) 
                {
                    ADDSSP();
                }
                if(num == 2)
                {
                    AddPlan();
                    
                }
                if (num == 3) 
                {
                    GetSSPByCity();
                }
                if (num==4)
                {
                    GetClientByCity();
                }
                if (num==5)
                {
                    GetSSPByChannelCapacity();
                }
                if (num==6)
                {
                    GetAllSSP();
                }
                if (num==7)
                {
                    GetAllClient();
                    
                }

                else { goto LoopExpression; }
            }
            
        }
        public  static void Menu()
        {

           
            
            Console.WriteLine("1) Add New SSp");
            Console.WriteLine("2) Add New Plan");
            Console.WriteLine("3) Get all SSP by City");
            Console.WriteLine("4) Get all Client by City");
            Console.WriteLine("5) Get SSp by Channel Capacity");
            Console.WriteLine("6) Get All SSP");
            Console.WriteLine("7) Get All Client");
            Console.WriteLine("....................................");
            Console.WriteLine("....................................");
            Console.WriteLine("Enter the Number");
           
           
        }
        public static void ADDSSP()
        {
            DateTime d = DateTime.Now;

            Console.WriteLine("Add Name Of SSP");
            string Name = Console.ReadLine();
            Console.WriteLine("Add Number of Chanels");
            string NoChanels = Console.ReadLine();
            Console.WriteLine("Add Chanel Capacity");
            string ChanelCapacity = Console.ReadLine();
            Console.WriteLine("SSp Email");
            string Email = Console.ReadLine();
            Console.WriteLine("SSP Address");
            string Address = Console.ReadLine();
            Console.WriteLine("City");
            string City = Console.ReadLine();
            Console.WriteLine("Site Office");
            string SiteOffice = Console.ReadLine();
            Console.WriteLine(" Joining Date:- " + d);
             Console.ReadLine();
            Console.WriteLine("Renual date:-  " + d.AddYears(1));
            Console.ReadKey();

            Console.WriteLine("SSP Name "+Name);
            Console.WriteLine("SSP Name " + NoChanels);
            Console.WriteLine("SSP Name " + ChanelCapacity);
            Console.WriteLine("SSP Name " + Email);
            Console.WriteLine("SSP Name " + Address);
            Console.WriteLine("SSP Name " + City);
            Console.WriteLine("SSP Name " + SiteOffice);
            Console.WriteLine("SSP Name " + d);
            Console.WriteLine("SSP Name " + d.AddYears(1));

            Console.ReadLine();
        }
            public static void AddPlan()
            {

                DateTime d = DateTime.Now;

                Console.WriteLine("Client Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Client Contact Number");
                string NoChanels = Console.ReadLine();
                Console.WriteLine("Client Email");
                string ChanelCapacity = Console.ReadLine();
                Console.WriteLine("Client Address 1");
                 string  Email = Console.ReadLine(); 
                Console.WriteLine("Client Address 2");
                string Address = Console.ReadLine();
                Console.WriteLine("SSp City");
                string City = Console.ReadLine();
                Console.WriteLine("SSp Partner");
                string SSPPartner = Console.ReadLine();
                Console.WriteLine(" Joining Date:- " + d);
                Console.ReadLine();
                Console.WriteLine("Select the Plan 1,2,3,4,    1) 1 Month   2) 3 Months  3) 6 Months  4) 12 Months");
                int Num = Convert.ToInt32(Console.ReadLine());
                if (Num == 1)
                {

                    Console.WriteLine(" Renual Date is " + d.AddMonths(1));
                }
                else if (Num == 2)
                {
                    Console.WriteLine(" Renual Date is " + d.AddMonths(3));
                }
                else if (Num == 3)
                {
                    Console.WriteLine(" Renual Date is " + d.AddMonths(6));
                }
                else if (Num == 4)
                {
                    Console.WriteLine(" Renual Date is " + d.AddYears(1));
                Console.ReadLine();
                }
               

                Console.ReadLine();
            Console.WriteLine("SSP Name " + Name);
            Console.WriteLine("SSP Name " + NoChanels);
            Console.WriteLine("SSP Name " + ChanelCapacity);
            Console.WriteLine("SSP Name " + Email);
            Console.WriteLine("SSP Name " + Address);
            Console.WriteLine("SSP Name " + City);
            Console.WriteLine("SSP Name " + SSPPartner);
            Console.WriteLine("SSP Name " + d);
            Console.WriteLine("SSP Name " + Num);
            Console.ReadLine();
            string vvv = Name+ NoChanels+ChanelCapacity+Email+Address+City+SSPPartner+d;
            Console.WriteLine(vvv);
          
            Console.ReadLine();

        }
        public static void GetSSPByCity()
        {

        }
        public static void GetClientByCity()
        {

        }
        public static void GetSSPByChannelCapacity()
        {

        }
        public static void GetAllSSP()
        {


        }
        public static void GetAllClient()
        {

          

        }



    }
     
}



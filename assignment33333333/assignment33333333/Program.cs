using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;



namespace assignment33333333
{
    public class Program
    {
        public static void Main()
        {
            string Name, Contact, Email, ADdreass1, City, SSPPartner, JoiningDate, PlanDuration;
            
            
            var Clients = new Display();
            var SSPS = new Display();
            DateTime date;
            while (true)
            {
                Console.WriteLine("........................................... ");
                Console.WriteLine("Select the Number ");
                Console.WriteLine("........................................... ");
                Console.WriteLine("1) Add Client");
                Console.WriteLine("2) Display All Client");
                Console.WriteLine("3) Add SSP");
                Console.WriteLine("4) Display All SSP");
                Console.WriteLine("5) Display Client By City");
                Console.WriteLine("6) Display SSP By City");
                Console.WriteLine("7) Display SSP By Channel Capacity");
                Console.WriteLine("8)..........Exit..........  ");
                Console.WriteLine("........................................... ");
              
            var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":

                        do
                        {
                            Console.Write("Enter Client Name:- ");
                            Name = Console.ReadLine();








                        }
                        while (string.IsNullOrEmpty(Name));

                        Console.WriteLine();
                        do
                        {

                            Console.Write("Enter Contact:- ");


                            Contact = (Console.ReadLine());



                            while (!long.TryParse(Contact, out long num) || num > 10000000000 || num < 1000000000)
                            {
                                Console.Write("Enter Correct Contact Numbar:- ");
                                Contact = (Console.ReadLine());
                            }

                        }
                        while (string.IsNullOrEmpty(Contact));
                        Console.WriteLine();
                        do
                        {
                        LoopExpression:
                           
                            Console.Write("Enter Email:- ");
                          
                            Email = Console.ReadLine();
                            Email.Where(x => x.Equals(Email));
                          
                            try
                            {
                                System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(Email);
                                mailAddress.Equals(Email);                       
                            }
                            catch
                            {                        
                                Console.WriteLine("enter valid email");
                                { goto LoopExpression; }
                            }
                          
                        }
                        while (string.IsNullOrEmpty(Email));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Address 1:- ");
                            ADdreass1 = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(ADdreass1));
                        Console.WriteLine("");
                        Console.Write("Enter Address 2 :- ");
                        var ADdreass2 = Console.ReadLine();
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter City:- ");
                            City = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(City));
                        Console.WriteLine("");
                        do
                        {
                        LoopExpression:
                            Console.WriteLine("Enter SSP Partners  1]Reliance 2]Tata 3]Planet Teleinfra ");
                            SSPPartner = Console.ReadLine();
                            if (SSPPartner.Equals("Reliance"))
                            {
                                Console.WriteLine("You Selected SSP Partner Reliance ");
                            }
                            else if (SSPPartner.Equals("Tata"))
                            {
                                Console.WriteLine("You Selected SSP Partner Tata ");
                            }
                            else if (SSPPartner.Equals("Planet Teleinfra"))
                            {
                                Console.WriteLine("You Selected SSP Partner Tata ");
                            }
                            else { goto LoopExpression; }


                            while (SSPPartner.StartsWith(" ") || SSPPartner.EndsWith(" ")) ;

                        } while (string.IsNullOrEmpty(SSPPartner));
                        Console.WriteLine("");
                        do
                        {                     
                            Console.Write("Enter Joining Date:- ");
                            JoiningDate = Console.ReadLine();
                           
                            while (!DateTime.TryParse(JoiningDate, out date)||date>DateTime.Now)
                            {
                                Console.WriteLine("Enter Correct Joining Date");
                                JoiningDate = Console.ReadLine();
                            }
                        }
                        while (string.IsNullOrEmpty(JoiningDate));
                        Console.WriteLine("");
                        do
                        {
                        LoopExpression:
                            Console.Write("Enter PlanDuration you Want== 1] 1:Month 2] 3:Months 3]6:Months 4]12:Months :- ");
                            PlanDuration = Console.ReadLine();
                            
                            if (PlanDuration.Equals("1"))
                            {
                                Console.WriteLine("Your Renual Date is:- " + date.AddMonths(1));
                            }
                            else if (PlanDuration.Equals("2"))
                            {
                                Console.WriteLine("Your Renual Date is:- " + date.AddMonths(3));
                            }
                            else if (PlanDuration.Equals("3"))
                            {
                                Console.WriteLine("Your Renual Date is:- " + date.AddMonths(6));
                            }
                            else if (PlanDuration.Equals("4"))
                            {
                                Console.WriteLine("Your Renual Date is:- " + date.AddYears(1));
                            }
                            else
                            {
                                Console.WriteLine("Pease select Option from 1-4 ");
                                { goto LoopExpression; }
                            }
                            
                            Console.WriteLine("");
                        }
                        while (string.IsNullOrEmpty(PlanDuration));
                        Console.WriteLine("");

                        Console.WriteLine("...................................");
                        Console.WriteLine("Client Added Successfully");
                        Console.WriteLine("...................................");
                        Console.WriteLine("");
                        Console.WriteLine("Name:- " + Name);
                        Console.WriteLine("Contact:- " + Contact);
                        Console.WriteLine("Email:- " + Email);
                        Console.WriteLine("Address 1:- " + ADdreass1);
                        Console.WriteLine("Address 2:- " + ADdreass2);
                        Console.WriteLine("City:- " + City);
                        Console.WriteLine("SSP Partner:- " + SSPPartner);
                        Console.WriteLine("Joining Date:- " + JoiningDate);
                        Console.WriteLine("Plan Duration :- " + PlanDuration);

                        if (PlanDuration.Contains("1"))
                        {
                            Console.WriteLine("Your Renual Date is:- " + date.AddMonths(1));
                        }
                        else if (PlanDuration.Contains("2"))
                        {
                            Console.WriteLine("Your Renual Date is:- " + date.AddMonths(3));
                        }
                        else if (PlanDuration.Contains("3"))
                        {
                            Console.WriteLine("Your Renual Date is:- " + date.AddMonths(6));
                        }
                        else if (PlanDuration.Contains("4"))
                        {
                            Console.WriteLine("Your Renual Date is:- " + date.AddYears(1));
                        }
                        Console.WriteLine();

                        Console.WriteLine("Press Enter to go back to Menu");
                     
                        Console.ReadLine();

                        var newClient = new Client(Name, Contact, Email, ADdreass1, ADdreass2, City, SSPPartner, JoiningDate, PlanDuration);
                        
                        Clients.AddClient(newClient);

                        break;

                    case "2":

                        Clients.DisplayAllClients();
                        Console.WriteLine();                       
                        Console.WriteLine("Press Enter to go back to Menu");
                        Console.ReadLine();
                        break;


                    case "3":

                        string SSPName, NumberofChannels, ChannelCapacity, SSPEmail, SSPContact, Address, SSPCity, SiteAddress, SSPJoiningDate;
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter SSP Name:- ");

                            SSPName = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(SSPName));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Number of Channels:- ");
                            NumberofChannels = Console.ReadLine();
                          
                            while (!long.TryParse(NumberofChannels, out long num)||num>100000000)
                            {
                                Console.WriteLine("Enter Correct Number of Channels");
                               NumberofChannels = Console.ReadLine();
                            }
                        }
                        while (string.IsNullOrEmpty(NumberofChannels));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Channel Capacity:- ");
                            ChannelCapacity = Console.ReadLine();
                          
                            while (!long.TryParse(ChannelCapacity, out long num)||num>10000000000)
                            {
                                Console.WriteLine("Enter Correct Channel Capacity");
                                ChannelCapacity = Console.ReadLine();
                            }
                        }
                        while (string.IsNullOrEmpty(ChannelCapacity));
                        Console.WriteLine("");
                        do
                        {
                            LoopExpression:
                            Console.Write("Enter Email:- ");
                            SSPEmail = Console.ReadLine().ToLower();
                            try
                            {
                                System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(SSPEmail);
                                mailAddress.Equals(SSPEmail);

                                {
                                    Console.WriteLine("arlready exist");
                                }

                            }
                            catch
                            {
                                Console.WriteLine("enter valid email");
                                { goto LoopExpression; }
                            }


                        }
                        while (string.IsNullOrEmpty(SSPEmail));
                      
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Contact:- ");

                            SSPContact = Console.ReadLine();
                           
                                while (!long.TryParse(SSPContact, out long num )|| num > 10000000000 || num < 1000000000)
                                {
                              
                                    Console.WriteLine("Enter Correct Contact Numbar");
                                    SSPContact = Console.ReadLine();
                                }
                               
                            

                        }
                        while (string.IsNullOrEmpty(SSPContact));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Address:- ");
                            Address = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(Address));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter SSP City:- ");
                            SSPCity = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(SSPCity));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Site Address:- ");
                            SiteAddress = (Console.ReadLine());
                        }
                        while (string.IsNullOrEmpty(SiteAddress));
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Enter Joining Date:- ");
                            SSPJoiningDate = Console.ReadLine();
                           
                            while (!DateTime.TryParse(SSPJoiningDate, out date) || date > DateTime.Now)
                            {
                                Console.WriteLine("Enter Correct joining Date");
                               SSPJoiningDate = Console.ReadLine();
                               
                            }
                            Console.WriteLine("Renual Date:- " + date.AddYears(1));
                        }
                        while (string.IsNullOrEmpty(SSPJoiningDate));
                        Console.WriteLine("");  

                        Console.WriteLine("...................................");
                        Console.WriteLine("SSP Added Successfully");
                        Console.WriteLine("...................................");
                        Console.WriteLine("Name:- " + SSPName);
                        Console.WriteLine("");
                        Console.WriteLine("Contact:- " + NumberofChannels);
                        Console.WriteLine("Email:- " + ChannelCapacity);
                        Console.WriteLine("Address 1:- " + SSPEmail);
                        Console.WriteLine("Address 2:- " + SSPContact);
                        Console.WriteLine("City:- " + Address);
                        Console.WriteLine("SSP Partner:- " + SSPCity);
                        Console.WriteLine("Site Address:- " + SiteAddress);
                        Console.WriteLine("SSP Joining Date :- " + SSPJoiningDate);
                        Console.WriteLine("SSP Renual Date :- " + date.AddYears(1));
                        Console.WriteLine();

                        Console.WriteLine("Press Enter to go back to Menu");

                        var newSSP = new SSP(SSPName, NumberofChannels, ChannelCapacity, SSPEmail, SSPContact, Address, SSPCity, SiteAddress, SSPJoiningDate);
                        SSPS.AddSSP(newSSP);
                        break;

                    case "4":

                        SSPS.DisplayAllSSP();
                        PreviousSSP();
                        break;

                    case "5":
                        string SearchPhrase;


                  
                        do
                        {
                        LoopExpression:


                            Console.WriteLine("Search Client By City");
                            SearchPhrase = Console.ReadLine();
                            if (SearchPhrase == string.Empty)
                            {
                                Console.WriteLine("Please Enter City Name");
                                { goto LoopExpression; }

                            }
                            while (string.IsNullOrWhiteSpace(SearchPhrase)) ;
                           
                        } while (SearchPhrase.StartsWith(" ")||SearchPhrase.EndsWith(" "));
                        
                            Clients.DisplayClientByCity(SearchPhrase);
                        
                    
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to go back to Menu");
                            Console.ReadLine();
                       

                        break;

                    case "6":
                        string Search;
                        do
                        {
                            LoopExpression:
                            Console.WriteLine("Search SSP By City");
                            Search =Convert.ToString(Console.ReadLine());
                            if (Search == string.Empty)
                            {
                                Console.WriteLine("Please Enter City Name");
                                { goto LoopExpression; }
                            }
                          
                            while (string.IsNullOrWhiteSpace(Search)) ;

                        } while (Search.StartsWith(" ") || Search.EndsWith(" "));
                           if (Search.Contains("Pune"))
                        {
                            Console.WriteLine("SSP Name= Reliance, Number of Chanels= 30 , Channel Capacity= 120, Email= cshead.reliancedigital@ril.com, Contact= 95685-47123 , Address= Heritage House, Ground Floor, 6 Ramabai Ambedkar Road City= Pune ,Site Address= Sangam Vadi , Joining Date= 1-2-2019 ");
                            Console.WriteLine("SSP Name= Tata Fiber Optics, Number of Chanels= 37 , Channel Capacity= 158, Email= customercare@tatamotors.com, Contact=  92296-92296 , Address= Survey No 103/A-1/129, Nyati Tiara, Next to Gunjan Theatre, Nagar Road, Yerawada City= Pune ,Site Address= Yervada , Joining Date= 5-3-2015 ");
                            Console.WriteLine("SSP Name= Planet Teleinfra , Number of Chanels= 43 , Channel Capacity= 240, Email= rohitmuchande@gmail.com, Contact=  75148-35628, Address= 323/2022, next to Durga Collection, near Shani Mandir Chowk, Sant Tukaram Nagar, Pimpri Colony, City= Pune ,Site Address= Pune , Joining Date= 8-4-2020 ");
                        }
                        SSPS.DisplaySSPByCity(Search);                                                                                                                                             
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to go back to Menu");
                            Console.ReadLine();
                        
                        break;

                    case "7":
                        string Channel;
                        {
                        LoopExpression:
                            Console.WriteLine("Search SSP By Channels Capacity");
                            Channel = Console.ReadLine();
                            if (Channel == string.Empty)
                            {
                                Console.WriteLine("Please Enter Channel Capacity");
                                { goto LoopExpression; }
                            }
                            
                            else if (Channel.Equals("120"))
                            {
                                Console.WriteLine("SSP Name= Reliance, Number of Chanels= 30 , Channel Capacity= 120, Email= cshead.reliancedigital@ril.com, Contact= 95685-47123 , Address= Heritage House, Ground Floor, 6 Ramabai Ambedkar Road City= Pune ,Site Address= Sangam Vadi , Joining Date= 1-2-2019 ");
                               
                            }
                            else if (Channel.Equals("158"))
                            {
                                Console.WriteLine("SSP Name= Tata Fiber Optics, Number of Chanels= 37 , Channel Capacity= 158, Email= customercare@tatamotors.com, Contact=  92296-92296 , Address= Survey No 103/A-1/129, Nyati Tiara, Next to Gunjan Theatre, Nagar Road, Yerawada City= Pune ,Site Address= Yervada , Joining Date= 5-3-2015 ");
                            }
                            else if (Channel.Equals("240"))
                            {
                                Console.WriteLine("SSP Name= Planet Teleinfra , Number of Chanels= 43 , Channel Capacity= 240, Email= rohitmuchande@gmail.com, Contact=  75148-35628, Address= 323/2022, next to Durga Collection, near Shani Mandir Chowk, Sant Tukaram Nagar, Pimpri Colony, City= Pune ,Site Address= Pune , Joining Date= 8-4-2020 ");
                            }
                            while (string.IsNullOrWhiteSpace(Channel)) ;

                        } while (Channel.StartsWith(" ") || Channel.EndsWith(" ")) ;
                        SSPS.DisplaySSPByChannelCapacity(Channel);
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to go back to Menu");
                            Console.ReadLine();
                        
                        break;

                    case "8":
                        return;                     
                }
            }
        }
      static void PreviousSSP()
        {           
            Console.WriteLine("SSP Name= Reliance, Number of Chanels= 30 , Channel Capacity= 120, Email= cshead.reliancedigital@ril.com, Contact= 95685-47123 , Address= Heritage House, Ground Floor, 6 Ramabai Ambedkar Road City= Pune ,Site Address= Sangam Vadi , Joining Date= 1-2-2019 ");
            Console.WriteLine("SSP Name= Tata Fiber Optics, Number of Chanels= 37 , Channel Capacity= 158, Email= customercare@tatamotors.com, Contact=  92296-92296 , Address= Survey No 103/A-1/129, Nyati Tiara, Next to Gunjan Theatre, Nagar Road, Yerawada City= Pune ,Site Address= Yervada , Joining Date= 5-3-2015 ");
            Console.WriteLine("SSP Name= Planet Teleinfra , Number of Chanels= 43 , Channel Capacity= 240, Email= rohitmuchande@gmail.com, Contact=  75148-35628, Address= 323/2022, next to Durga Collection, near Shani Mandir Chowk, Sant Tukaram Nagar, Pimpri Colony, City= Pune ,Site Address= Pune , Joining Date= 8-4-2020 ");
            Console.ReadLine();
           
        }
      
       
    } 
}






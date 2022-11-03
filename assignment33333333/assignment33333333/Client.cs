using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment33333333
{
    public class Client
    {
        public Client(string name , string contact,  string email, string aDdreass1, string aDdreass2, string city, string sSPPartner, string joiningDate, string planDuration)
        {
          
            Name = name;
           Contact = contact;
            Email = email;
            ADdreass1 = aDdreass1;
            ADdreass2 = aDdreass2;
            City = city;
            SSPPartner = sSPPartner;
            JoiningDate = joiningDate;
            PlanDuration = planDuration;
          
        }
       
        
        public string Name {get; set; }

       
        public string Contact { get; set; }

        
        public string Email { get; set; }
     
        public string ADdreass1 { get; set; }
      
        public string ADdreass2 { get; set; }
       
        public string City { get; set; }

        public string SSPPartner { get; set; }
       
        public string JoiningDate { get; set; }
      
        public string PlanDuration { get; set; }



      

    }

}

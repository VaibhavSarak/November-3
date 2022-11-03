using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment33333333
{
    public class Display
    {
        public List<Client> clients { get; set; } = new List<Client>() ;
        

        public List<SSP> ssp {get; set; } = new List<SSP>();

        
        public void DisplayClient(Client client)
        {
           
                Console.WriteLine($"Name= {client.Name}, Contact= {client.Contact}, Email= {client.Email}, Address1= {client.ADdreass1}, Address2= {client.ADdreass2}, City= {client.City}, SSPPartner= {client.SSPPartner} ,JoiningDate= {client.JoiningDate}, PlanDuration= {client.PlanDuration}  ");
            Console.WriteLine();


           

        }

        public void DisplaySSP(SSP sSP)
        {

                Console.WriteLine($"SSP Name= {sSP.SSPName}, Number of Chanels= {sSP.NumberofChannels}, Channel Capacity= {sSP.ChannelCapacity}, Email= {sSP.SSPEmail}, Contact= {sSP.SSPContact}, Address {sSP.SSPAddress}, City= {sSP.SSPCity} ,Site Address= {sSP.SiteAddress}, Joining Date= {sSP.SSPJoiningDate} ");
            Console.WriteLine();
        }
        public void AddClient(Client client)
        {
           
            clients.Add(client);
        }
        public void AddSSP(SSP sSP)
        {
            ssp.Add(sSP);
        }


        public void DisplayAllClients()
        {
           
            
                DisplayDetailsClients(clients);
            
        }
      

        public void DisplayAllSSP()
        {
           DisplayDetailsSSP(ssp);
        }
     
      
        public void DisplayDetailsClients(List<Client> clients)
        {
            foreach (Client client in clients)
            {
                DisplayClient(client);
            }
        }
        public void DisplayDetailsSSP(List<SSP> ssp)
        {
            foreach (SSP sSP in ssp)
            {
                DisplaySSP(sSP);
            }
        }
        public void DisplayClientByCity(string SearchPhrase)
        {
            var ByCity = clients.Where(c => c.City.Contains(SearchPhrase)).ToList();
            DisplayDetailsClients(ByCity);
        }
        public void DisplaySSPByCity(string Search )
        {
            var byCity = ssp.Where(d => d.SSPCity.Contains(Search)).ToList();
            DisplayDetailsSSP(byCity);

        }
        public void DisplaySSPByChannelCapacity(string Channel)
        {
            var capacity = ssp.Where(e => e.ChannelCapacity.Contains(Channel)).ToList();
            DisplayDetailsSSP(capacity);
        }
      
    }
}

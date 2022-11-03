using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace assignment33333333
{
    public class SSP
    {
        public SSP(string sSPName, string numberofChannels, string channelCapacity, string email, string contact, string address, string city, string siteAddress, string joiningDate)
        {
            SSPName = sSPName;
            NumberofChannels = numberofChannels;
            ChannelCapacity = channelCapacity;
            SSPEmail = email;
            SSPContact = contact;
            SSPAddress = address;
            SSPCity = city;
            SiteAddress = siteAddress;
            SSPJoiningDate = joiningDate;

        }

        [Required]
        public string SSPName { get; set; }
        [Required]
        public string NumberofChannels { get; set; }
        [Required]
        public string ChannelCapacity { get; set; }
        [EmailAddress]
        public string SSPEmail { get; set; }
        [Required]
        public string SSPContact { get; set; }
        [Required]
        public string SSPAddress { get; set; }
        [Required]
        public string SSPCity { get; set; }
        [Required]
        public string SiteAddress { get; set; }
        [Required]
        public string SSPJoiningDate { get; set; }
       




    }
}

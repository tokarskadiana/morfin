using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorFin.Models
{
    public class Firm
    {
        [Required, MaxLength(255)]
        public string Name;
        [Required, MinLength(10), MaxLength(10)]
        public int NIP;
        public string Email;
        public int PhoneNumber;
        public IList<string> AuctionUrls;
    }
}

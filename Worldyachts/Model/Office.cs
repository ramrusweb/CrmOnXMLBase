using System.Collections.Generic;

namespace Worldyachts.Model
{
    public class Office
    {
        // true if a head office, false otherwise
        public bool IsHeadOffice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public string Address { get; set; }
        public string[] Email { get; set; }
        public List<string> Phones { get; set; } = new List<string>();
    }
}

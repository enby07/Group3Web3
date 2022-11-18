using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group3Web3.Models
{
    public class Studenti
    {
        public Studenti(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;

        }
        public string Emri { get; set; }
        
        public string Mbiemri { get; set; }
    }
}

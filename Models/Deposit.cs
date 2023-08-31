using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormApplicaton.Models
{
    internal class Depositt
    {
        [Key]
        public int Sno { get; set; }
        public DateTime Date { get; set; }
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public decimal OldBalance { get; set; }
        public string Mode { get; set; }
        public int DipAmount { get; set; }
    }
}

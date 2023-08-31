using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormApplicaton.Models
{
    internal class AccountDetails
    {
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DefaultValue(1000000)]
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public byte[] Picture { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public int Balance { get; set; }
        public DateTime Date { get; set; }
    }
}

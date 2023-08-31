﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormApplicaton.Models
{
    internal class Transferr
    {
        [Key]
        public int Sno { get; set; }
        public DateTime Date { get; set; }
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public int TAmountt { get; set; }
        public int ToTransfer { get; set; }
        public string ToName { get; set; }

    }
}

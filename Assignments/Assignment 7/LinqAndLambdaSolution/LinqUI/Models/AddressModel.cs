﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
    }
}

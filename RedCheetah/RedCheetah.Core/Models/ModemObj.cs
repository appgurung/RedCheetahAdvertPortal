﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedCheetah.Core.Models
{
    public class ModemDetails
    {

        public int CustomerId { get; set; }

        public int AccountId { get; set; }

        public string AccountName { get; set; }

        public int LocationId { get; set; }
        public string IMSI { get; set; }

        public string IpAddres { get; set; }
    }
}
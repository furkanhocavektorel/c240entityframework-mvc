﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.entity
{
    internal class Order
    {
        [Key]
        public int Id { get; set; }
        public string adres { get; set; }
    }
}

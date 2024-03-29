﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("ReabilitationType")]
        public int ReabilitationTypeId { get; set; }
        public ReabilitationType ReabilitationType { get; set; }
    }
}

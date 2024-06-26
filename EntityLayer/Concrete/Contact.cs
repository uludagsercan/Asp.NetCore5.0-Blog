﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact:IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactUsername { get; set; }
        public string ContactMail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public string ContactDate { get; set; }
        public bool ContactStatus { get; set; }
    }
}

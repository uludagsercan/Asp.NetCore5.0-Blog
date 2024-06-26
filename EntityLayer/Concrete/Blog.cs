﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog:IEntity
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}

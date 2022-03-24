using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class UserForDto:IDto
    {
        public string Username { get; set; }
        public string UserMail { get; set; }
        public string UserPassowrd { get; set; }
        public string UserPasswordConfimation { get; set; }

        public string UserImage { get; set; }

    }
}

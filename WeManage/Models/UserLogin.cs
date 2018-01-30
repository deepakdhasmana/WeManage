using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeManage.Models
{
    public class UserLogin
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public byte Flag { get; set; }
        public int UserLoginID { get; set; }
        public DateTime LastLoginTimeStamp { get; set; }       
        
    }
    public class UserVerify
    {
        public string UserName { get; set; }
        public string Password { get; set; }        
    }
}
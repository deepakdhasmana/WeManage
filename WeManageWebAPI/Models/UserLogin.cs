//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeManageWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserLogin()
        {
            this.Flag = 0;
        }
    
        public int UserLoginID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte Flag { get; set; }
        public System.DateTime LastLoginTimeStamp { get; set; }
    }
}
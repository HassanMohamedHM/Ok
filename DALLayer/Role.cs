//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.ScreensInRole = new HashSet<ScreensInRole>();
            this.UserRoles = new HashSet<UserRoles>();
        }
    
        public int Role_Code { get; set; }
        public string Role_Name { get; set; }
    
        public virtual ICollection<ScreensInRole> ScreensInRole { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
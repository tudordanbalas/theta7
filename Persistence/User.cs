//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User(int userId, string username, string name, string password, string email, string affilliation, string webPage, bool canBePCMember)
        {
            UserId = userId;
            Username = username;
            Name = name;
            Password = password;
            Email = email;
            Affilliation = affilliation;
            WebPage = webPage;
            this.canBePCMember = canBePCMember;
        }

        public User()
        {
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Affilliation { get; set; }
        public string WebPage { get; set; }
        public bool canBePCMember { get; set; }
    }
}

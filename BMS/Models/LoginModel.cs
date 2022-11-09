using System;
using System.Security.Cryptography;
using System.Text;

namespace BMS.Models
{
    public class Login
    {
        public Login(string EmailId,string password,string cDate,bool isEdit,bool isView,bool isAdmin,bool isDelete)
        {
            this.UserEmailId=EmailId;
            this.Password=password;
            this.createDateTime=cDate;
            this.IsEdit=isEdit;
            this.IsView=isView;
            this.IsAdmin=isAdmin;
            this.IsDelete=isDelete;
        }
        public Login()
        {
            
        }
        public string UserEmailId{get;set;}
        public string Password{get;set;}
        public string createDateTime {get;set;}
        public bool IsEdit {get;set;}
        public bool IsView {get;set;}
        public bool IsAdmin{get;set;}
        public bool IsDelete{get;set;}

        
    }
}
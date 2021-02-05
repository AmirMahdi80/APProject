using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    
    public class User
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string IdCode { get; set; }

        public User(string FirstName, string LastName, string IdCode)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IdCode = IdCode;

        }



    }
}

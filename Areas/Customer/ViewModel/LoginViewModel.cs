using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApp.Areas.Customer.ViewModel
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public bool RememberMe { get; set; }

        public string Password { get; set; }
    }
}

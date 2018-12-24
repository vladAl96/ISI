using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.ViewModels
{
    public class MembersViewModel
    {
        public MembersViewModel()
        {
            users = new List<UserViewModel>();
        }
        public List<UserViewModel> users { get; set; } 
    }
}

﻿using bacit_dotnet.MVC.Entities;
using bacit_dotnet.MVC.Repositories;

namespace bacit_dotnet.MVC.Models.Users
{
    public class UserViewModel
    {
        public string Name { get; set; }
      
        public string Email { get; set; }

        public List<UserEntity> Users { get; set; }
        
        //Roller
        public bool IsAdmin { get; set; }

        public bool IsMekaniker { get; set; }

        public bool IsSuper { get; set; }
    }
}

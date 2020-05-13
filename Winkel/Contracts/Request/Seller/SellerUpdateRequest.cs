﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public class SellerUpdateRequest
    {
        public SellerUpdateRequest(int SellerID,string Name, string Surname, string Email, string Password, string CityName, string Photo)
        {
            this.SellerID = SellerID;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            this.CityName = CityName;
            this.Photo = Photo;
        }

        public int SellerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CityName { get; set; }
        public string Photo { get; set; }
    }
}
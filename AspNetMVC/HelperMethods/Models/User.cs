﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Models
{

    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }


    public class Address
    {
        [DisplayName("Адрес 1")]
        public string Line1 { get; set; }

        [DisplayName("Адрес 2")]
        public string Line2 { get; set; }

        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Почтовый индекс")]
        public string PostalCode { get; set; }

        [DisplayName("Страна")]
        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }
}
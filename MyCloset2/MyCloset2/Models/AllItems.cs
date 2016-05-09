using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyClosetApp.Models
{
    public class AllItems //This class is used to be able to access all the models for the homepage carousel and spring/summer pages
    {
        public Tops Tops { get; set; }
        public Bottoms Bottoms { get; set; }
        public Accessories Accessories { get; set; }
        public Shoes Shoes { get; set; }


    }
}
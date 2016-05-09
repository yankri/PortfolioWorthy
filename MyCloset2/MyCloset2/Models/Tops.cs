using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyClosetApp.Models   //I accidentally messed up the namespace when I copied the code from my original project (that I broke irreparably).
{
    public class Tops : MyCloset2.Models.IPhotoGiver //implements the interface
    {
        [Key]
        public int TopsID { get; set; }
        public string Nickname { get; set; }
        public string PhotoURL { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}
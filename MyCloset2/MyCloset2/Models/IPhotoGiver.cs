using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCloset2.Models
{
    //This interface allows me to be able to get the PhotoURL and Seasons properties from all the models since all 4 models implement
    //this interface. This makes putting all 4 clothing type databases into one list of IEnumberable<IPhotoGiver>s so I could make the 
    //carousel show pics from all 4 models at once. 
    public interface IPhotoGiver 
    {
        string PhotoURL { get; set; }
        string Season { get; set; }
    }
}

//http://stackoverflow.com/questions/23536299/mvc-5-multiple-models-in-a-single-view
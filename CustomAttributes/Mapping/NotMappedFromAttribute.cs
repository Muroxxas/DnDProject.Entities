using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.CustomAttributes.Mapping
{
    //This is used to prevent a *Destination* value of an object from being mapped *to*.
    //I am entirely unsure if it will prevent *source* members from being mapped *from*.
    public class NotMappedFromAttribute : System.Attribute
    {

    }
}

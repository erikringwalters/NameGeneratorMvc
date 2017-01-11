using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class ElfNameData
    {
        //A big array of Elf name beginnings
        public string[] Prefix = new string[] { "And", "Ca", "Cy", "Ko", "Li",
            "Lo", "Mo", "Psy", "Sa", "Sau", "Sha", "Val", "Zen", "Ze", "Ada", "Ad", "Cae",
            "Els", "Cae", "Gra", "Gae", "Jo", "Spel", "Hi", "Sto", "Throm", "Ga", "Arg",
            "Ang", "Co", "Ar", "Sil", "Ta", "Eli", "Ril", "Phy", "Usa", "Uth", "Min",
            "Cyl", "Cy", "Cas", "Min", "Pin", "Aza", "Cas", "Ere", "Hel", "Nis", "Shu", "Ul",
            "Van", "Zir" };
        //An array of Elf name middles
        public string[] Root = new string[] {"lal", "el", "as", "dalf", "man", "mon", "nar",
            "rir", "il", "or", "al", "an", "ith", "oli", "au", "aur", "uri", "lon", "gan", "sau", "ri",
            "ur", "ul", "par", "seth", "set", "zet", "mui" };

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class DwarfNameData
    {
        //Array of dwarf prefixes
        public string[] Prefix = new string[] { "Dhon", "Alf", "Holg", "Lot", "Nor", "Hou", "Krad",
            "Haz", "Garr", "Fod", "Dug", "Nur", "Kro", "Buk", "Grun", "Bok", "Werb", "Whu", "Kit", "Thol",
            "Khur", "Dor", "Nez", "Azi", "Jaz", "Kul", "Bras", "Utu", "Nez", "Dwo", "Den", "Sal", "Fik",
            "Snar", "Sak", "Bok", "Brog", "Grum", "Wer", "Dar", "Tur", "Thot", "Khed", "Het", "Rud", "Bast",
            "Vast", "Fib", "Lom", "Er" };
        //Array of dwarf roots
        public string[] Root = new string[] { "rulir", "erlun", "meth", "merl", "lig", "amli", "eat", "reat",
            "rath", "lun", "lug", "omli", "atin", "mar", "lous", "drec", "rour", "uil", "oid", "eare", "grett",
            "bell", "deth", "rure", "hild", "lynn", "elyn", "egar", "belyn", "rude", "rik", "bena", "grid",
            "elyn", "oul", "rett", "err", "ryd", "elyn", "bryn", "ginn" };
    }
}
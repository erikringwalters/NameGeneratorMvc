using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class HumanNameData
    {
        //Array of Human prefixes
        public string[] Prefix = new string[] { "Geo ", "Har", "Oud", "Ham", "Arn", "Ard", "Sym",
            "Rich", "Chri", "Sew", "Al", "Ger", "Jan", "Oue", "Jos", "Gab", "Joc", "Theo", "Thor", "Ash",
            "Ben", "Tom", "Sal", "Daf", "Euv", "Hen", "Aud", "Rand", "Jac", "Ger", "Hur", "Guil", "Adi", "Dra",
            "Cla", "Bar", "Jer", "Rol", "Seg", "Eve", "War" };
        //Array of Human roots
        public string[] Root = new string[] { "man", "dry", "ar", "tus", "dus", "yn", "el", "rus", "ory", "vel",
            "mar", "up", "ard", "ques", "tran", "let", "hal", "ce", "ric", "onet", "bus", "vin", "ner", "ret", "vit", "vid",
            "ont", "est", "tie", "on", "uche", "ale", "nus", "kin", "ier", "udd", "aut", "art", "ac", "hel", "ousse" };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class OrcNameData
    {
        //Array of orc name beginnings.
        public string[] Prefix = new string[]
        {
            "Yeg", "Hug", "Zug", "Bur", "Vur", "Ag", "Un", "Bu",
            "Vu", "Ung", "Sha", "Gom", "Go", "Zor", "Lor", "Lo", "Kha",
            "Gun", "Xu", "Gua", "Op", "Muz", "Ig", "Eg", "Gna", "Gnu", "Dak",
            "Mug", "Peg", "Wru", "Wri", "Ik", "Kur", "Ekg", "Nod", "Tar", "Dor",
            "Jol", "Fog", "Bog", "Yun", "Bum", "Dor", "Jok", "Slo", "Ul", "Ulg",
            "Reb", "Sar", "Ro"
        };

        //Array of orc name ends/middles
        public string[] Root = new string[]
        {
            "ug", "bag", "ag", "om", "mok", "kom", "rak", "har", "og", "hal", "il",
            "or", "bul", "augh", "ah", "hig", "org", "gan", "rug", "hum", "og", "bub",
            "hub", "ush", "ort", "gug", "dag", "un", "ek", "lug", "lor", "ig", "log",
            "ag", "hig", "mag", "rig", "kub", "gu", "dud", "hag", "ulg", "hed", "hat",
            "fu", "kil", "gor"
        };
    }
}
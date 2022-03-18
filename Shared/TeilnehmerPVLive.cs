using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formular1.Shared
{
    public class TeilnehmerPVLive
    {
        public int Id { get; set; }
        public int IdTeilnehmer { get; set; }
        public string? TeilnahmePVLive { get; set; }       
        public string? amSamstag { get; set; }
        public string? amSonntag { get; set; }
        public string? mitKollegen { get; set; }
        public int AnzahlKollege { get; set; }
        public string? AnredeKollege { set; get; }
        public string? NameKollege { set; get; }
        public string? EmailKollege { set; get; }
        public string? Minderjährig { set; get; }


    }
}

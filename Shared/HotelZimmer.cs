using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formular1.Shared
{
    public class HotelZimmer
    {
        
        public int Id { get; set; }
        public int IdTeilnehmer { get; set; }
        public string? Übernachtung { get; set; }
        public DateTime? Anreisedatum { get; set; }
        public DateTime? Abreisetag { get; set; }
        public string? ZimmerForm{ get; set; }
        
    }
}

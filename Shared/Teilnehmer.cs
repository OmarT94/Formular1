using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formular1.Shared
{
    public class Teilnehmer
    {
        
        public int Id { get; set; }
        public string? Anrede { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? mitBegleitung { get; set; }
        public string? BgAnrede { get; set; }
        public string? BgName { get; set; }
        public string? BgEmail { get; set; }
    }
}

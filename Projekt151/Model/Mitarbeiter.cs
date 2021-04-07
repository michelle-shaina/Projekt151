using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class Mitarbeiter
    {
        public string MitarbeiterId { get; set; }
        public string MitarbeiterName { get; set; }
        public int StadtId { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
    }
}

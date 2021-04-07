using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class RoleFormatted
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<Mitarbeiter> Mitarbeiters { get; set; }
    }
}

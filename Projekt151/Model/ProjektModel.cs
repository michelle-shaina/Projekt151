using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class ProjektModel: Projekt
    {
        public string KategorieName { get; set; }
        public string TaskName { get; set; }
        public string MitarbeiterName { get; set; }
    }
}

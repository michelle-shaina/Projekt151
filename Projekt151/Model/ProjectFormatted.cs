using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class ProjectFormatted
    {
        public int ProjektId { get; set; }
        public string ProjektName { get; set; }
        public string Beschreibung { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsGoing { get; set; }
        public string KategorieId { get; set; }
        public string TaskId { get; set; }
        public string MitarbeiterId { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
        public IEnumerable<Mitarbeiter> Mitarbeiters { get; set; }

    }
}

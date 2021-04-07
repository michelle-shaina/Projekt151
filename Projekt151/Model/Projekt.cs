using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class Projekt
    {
        public int ProjektId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Project Name hast to bee at least 3 Characters long")]
        public string ProjektName { get; set; }
        public string Beschreibung { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsGoing { get; set; }
        public int KategorieId { get; set; }
        public int TaskId { get; set; }
        public int MitarbeiterId { get; set; }

    }
}

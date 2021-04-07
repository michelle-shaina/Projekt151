using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class Mitarbeiter
    {
        public string MitarbeiterId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name has to be at least 2 Characters long")]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string MitarbeiterName { get; set; }
        public int StadtId { get; set; }
        public int RoleId { get; set; }
        [MinLength(4, ErrorMessage = "Password has to be at least 4 Characters long")]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Model
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Beschreibung { get; set; }
        public bool IsDone { get; set; }
    }
}

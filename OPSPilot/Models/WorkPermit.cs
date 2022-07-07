using System;
using System.Collections.Generic;
using System.Text;

namespace OPSPilot.Models
{
    public class WorkPermit
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}

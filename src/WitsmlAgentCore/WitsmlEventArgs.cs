using AIKI.CO.OilWell.Monitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitsmlAgentCore
{
    public class WitsmlEventArgs:EventArgs
    {
        public WellRecord? WellRecord { get; set; }
        public string? WellInfoKey { get; set; }
    }
}

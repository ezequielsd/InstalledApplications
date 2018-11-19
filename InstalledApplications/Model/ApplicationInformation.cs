using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications
{
    public class ApplicationInformation
    {        
        public string DisplayName { get; set; }
        
        public string DisplayVersion { get; set; }

        public string InstallSource { get; set; }

        public string Publisher { get; set; }

        public string InstallDate { get; set; }

    }
}

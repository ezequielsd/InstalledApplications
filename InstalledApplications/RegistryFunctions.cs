using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications
{
    public class RegistryFunctions
    {
        const string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

        /// <summary>
        /// Get installed applications 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetListAllApplications()
        {
            List<string> list = new List<string>();

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regKey))
            {
                foreach (string subKey in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subKey))
                    {
                        object valor = subkey.GetValue("DisplayName");
                        if (valor != null)
                            list.Add(valor.ToString());
                    }
                }
            }

            list.Sort();
            return list;
        }


        public static List<ApplicationInformation> GetListApplicationsWin32()
        {
            List<ApplicationInformation> list = new List<ApplicationInformation>();
            //SELECT * FROM Win32_Product
            //  ManagementObjectSearcher s = new ManagementObjectSearcher("root\\CIMV2",  "SELECT * FROM Win32_Service", new EnumerationOptions( null, System.TimeSpan.MaxValue, 1, true, false, true, true, false, true, true));
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
          
            var apps = s.Get();

            foreach (ManagementObject service in apps)
            {
                try
                {
                    ApplicationInformation item = new ApplicationInformation();

                    item.Name = service["Name"].ToString();
                    item.Version = service["Version"].ToString();
                    list.Add(item);
                }
                catch (Exception)
                {                    
                    continue;
                }               
               
            }
            list.Sort();
            return list;
        }
    }
}

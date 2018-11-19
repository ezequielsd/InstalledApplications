using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications
{
    public class RegistryFunctionsBLL
    {
        const string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        const string regKey64 = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

        /// <summary>
        /// Get installed applications 
        /// </summary>
        /// <returns></returns>
        public static List<ApplicationInformation> GetListAllApplications()
        {          
           List<ApplicationInformation> list = new List<ApplicationInformation>();

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regKey))
            {
                foreach (string subKey in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subKey))
                    {
                        object valor = subkey.GetValue("DisplayName");
                        if (valor != null && !valor.ToString().Contains("_"))
                        {
                            ApplicationInformation item = new ApplicationInformation();
                            item.DisplayName = subkey.GetValue("DisplayName").ToString();
                            
                            if(subkey.GetValue("DisplayVersion") != null)
                                item.DisplayVersion = subkey.GetValue("DisplayVersion").ToString();

                            if (subkey.GetValue("InstallSource") != null)
                                item.InstallSource = subkey.GetValue("InstallSource").ToString();
                            else if (subkey.GetValue("InstallLocation") != null)
                                item.InstallSource = subkey.GetValue("InstallLocation").ToString();

                            if (subkey.GetValue("InstallDate") != null && !string.IsNullOrEmpty(subkey.GetValue("InstallDate").ToString()))
                            {
                                if (subkey.GetValue("InstallDate").ToString().Contains("/"))
                                    item.InstallDate = subkey.GetValue("InstallDate").ToString();
                                else
                                    item.InstallDate = DateTime.ParseExact(subkey.GetValue("InstallDate").ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd-MM-yyyy");
                            }       
                            
                            if (subkey.GetValue("Publisher") != null)
                                item.Publisher = subkey.GetValue("Publisher").ToString();

                            list.Add(item);
                        }
                        
                    }
                }
            }

            //list.Sort();
            return list.OrderBy(or => or.DisplayName).ToList();
        }
              
    }
}

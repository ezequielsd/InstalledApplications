using CFSqlCe.Dal;
using InstalledApplications.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications.BLL
{
    public static class ProfileBLL
    {
        /// <summary>
        /// Adiciona um novo profile
        /// </summary>
        /// <param name="profile"></param>
        public static void Criar(Profile profile)
        {
            new ProfileDAL().Criar(profile);
        }

        /// <summary>
        /// Returna a lista de profile riado
        /// </summary>
        /// <returns></returns>
        public static List<Profile> List()
        {
            return new ProfileDAL().List();
        }
    }
}

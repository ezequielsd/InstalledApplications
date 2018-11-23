using CFSqlCe.Dal;
using InstalledApplications.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications.BLL
{
    public class ProfileBLL
    {
        ProfileDAL dal = new ProfileDAL();

        /// <summary>
        /// Adiciona um novo profile
        /// </summary>
        /// <param name="profile"></param>
        public void Criar(Profile profile)
        {
            dal.Criar(profile);
        }

        /// <summary>
        /// Returna a lista de profile riado
        /// </summary>
        /// <returns></returns>
        public List<Profile> List()
        {
            return dal.List();
        }
    }
}

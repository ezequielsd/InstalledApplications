using CFSqlCe.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalledApplications.DAL
{
    public class ProfileDAL
    {
        /// <summary>
        /// Adiciona um novo profile
        /// </summary>
        /// <param name="profile"></param>
        public void Criar(Profile profile)
        {            
            using (Context context = new Context())
            {
                context.Profiles.Add(profile);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Returna a lista de profile riado
        /// </summary>
        /// <returns></returns>
        public List<Profile> List()
        {
            using (Context context = new Context())
                return context.Profiles.ToList();
            
        }
    }
}

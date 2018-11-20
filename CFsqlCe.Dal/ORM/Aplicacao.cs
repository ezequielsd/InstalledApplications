using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFSqlCe.Dal
{
    public class Aplicacao
    {
        [Key]        
        public int Id { get; set; }
        
        [StringLength(500)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string DisplayVersion { get; set; }

        [StringLength(500)]
        public string InstallSource { get; set; }

        [StringLength(500)]
        public DateTime Publisher { get; set; }

        public string ProfileId { get; set; }

        [ForeignKey("ProfileID")]
        public virtual Profile Profile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFSqlCe.Dal
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Nome { get; set; }
                
        [Required]
        public DateTime DataCriacao { get; set; }
        
        public List<Aplicacao> Aplicacoes { get; set; }
    }
}

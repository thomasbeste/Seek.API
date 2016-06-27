using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.DAL
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
    }
}

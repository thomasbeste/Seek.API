using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.DAL
{
    public class Canditate
    {
        [Key]
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

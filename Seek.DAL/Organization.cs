using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.DAL
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public  string Name { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

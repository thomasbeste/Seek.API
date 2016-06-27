using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Seek.DAL
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Cell { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrganizationRelations> OrganizationRelations { get; set; }

    }
}

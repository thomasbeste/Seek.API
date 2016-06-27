using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seek.DAL
{
    public class OrganizationRelations
    {
        [Key]
        public int OrganisationRelationId { get; set; }
        [Required]
        public int SiblingOrganizationId { get; set; }
        [Required]
        public  bool IsAllowedToSeeOrders { get; set; }
    }
}
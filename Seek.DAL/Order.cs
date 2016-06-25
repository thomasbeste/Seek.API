using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.DAL
{
    public class Order
    {
        public int OrderId { get; set; }
        public int MaxCandidates { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }


        public virtual Organization Organization { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Canditate> Candidates { get; set; }
    }
}

using Seek.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.BLL.Commands
{
    internal class FetchUserCommand : CommandBase<EntityFetcher<User>, IEnumerable<User>>
    {
        public override IEnumerable<User> Execute(EntityFetcher<User> parameters, SeekContext context)
        {
            throw new NotImplementedException();
        }
    }
}

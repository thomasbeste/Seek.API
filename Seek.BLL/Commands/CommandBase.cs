using Seek.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.BLL.Commands
{
    internal abstract class CommandBase<T, TReturn>
    {
        public abstract TReturn Execute(T parameters, SeekContext context);
    }
}

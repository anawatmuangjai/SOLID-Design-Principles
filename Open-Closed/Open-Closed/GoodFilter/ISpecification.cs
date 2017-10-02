using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public interface ISpecification<T>
    {
        bool IsStatisfied(T t);
    }
}

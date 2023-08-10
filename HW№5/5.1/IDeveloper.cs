using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destroy(string Tool);

        string Tool { get; set; }
    }
}

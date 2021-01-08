using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IBread
    {
        string Name { get; set; }

        string GetBreadName();
    }
}

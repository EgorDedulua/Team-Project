using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Project
{
    internal interface IRateAndCopy
    {
        double Rating { get; }

        object DeepCopy();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Test.Entitiy.Interface
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}

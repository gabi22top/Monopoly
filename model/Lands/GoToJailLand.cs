﻿using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class GoToJailLand : Land
    {
        public GoToJailLand() => (Type, SealableStrategy) = (LandType.GoToJail, new NotPurchasableStrategy());
    }
}

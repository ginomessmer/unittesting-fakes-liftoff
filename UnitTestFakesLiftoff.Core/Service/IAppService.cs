﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFakesLiftoff.Core.Service
{
    public interface IAppService
    {
        string DisplayCurrentTimeOfDay();
        string GetCurrentWeather();
    }
}

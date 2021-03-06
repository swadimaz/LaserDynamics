﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserDynamics.Common{
    public interface ICalculationWorkspace
    {
        void Calculate();
        long[] GetStats();
        void GetResults();
        ICalculation Parent { get; set; }
        event EventHandler OnCalculationFinish;
        event EventHandler OnCalculationStart;
        event EventHandler OnCalculationError;
        void OnCalculationStopped();
    }
}

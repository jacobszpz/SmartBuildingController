﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuilding
{
    public interface IManager
    {
        public string GetStatus();
        public bool SetEngineerRequired(bool needsEngineer);
    }
}

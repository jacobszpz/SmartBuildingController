﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuilding
{
    public interface IFireAlarmManager
    {
        public void SetAlarm(bool isActive);
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface IReminderObserver
    {
        void Update(IReminder reminder);
    }
}

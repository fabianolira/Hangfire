﻿using System;

namespace HangFire
{
    internal class JobCompletedEventArgs : EventArgs
    {
        public JobCompletedEventArgs(string jobId)
        {
            JobId = jobId;
        }

        public string JobId { get; private set; }
    }
}
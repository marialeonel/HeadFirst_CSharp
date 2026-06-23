using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystemWPF
{
    public interface IWorker
    {
        public string Job { get; set; }
        void WorkTheNextShift();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystemWPF
{
    public abstract class Bee
    {
        public string Job { get; set; }
        public abstract float CostPerShift { get; }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift)) DoJob();
        }

        protected abstract void DoJob();

        public Bee(string job)
        {
            Job = job;
        }
    }
}

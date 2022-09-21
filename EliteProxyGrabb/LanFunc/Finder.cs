using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class Finder : IFinder
    {
        public virtual string Host { get; } 
        public DateTime LastCheck { get; set; } = DateTime.MinValue;
        public int NextCheck { get; set; } = 60;
        public bool NeedCheck => LastCheck.AddSeconds((double)NextCheck) < DateTime.Now;
        public virtual async Task<Proxy[]> Grab()
        {
            await Task.Delay(1);
            return new Proxy[0];
        }

        public event FindEventHandler Finding;

        protected virtual void OnFinding(List<Proxy> newproxylist)
        {
            Finding?.Invoke(this, newproxylist);
        }
    }
}

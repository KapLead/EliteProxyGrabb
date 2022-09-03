using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class Finder : IFinder
    {
        public DateTime LastCheck { get; } = DateTime.MinValue;
        public int NextCheck { get; } = 60;
        public bool NeedCheck => LastCheck.AddMinutes((double)NextCheck) < DateTime.Now;
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

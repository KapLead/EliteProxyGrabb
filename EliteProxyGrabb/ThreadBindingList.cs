using System.ComponentModel;
using System.Threading;

namespace EliteProxyGrabb
{
    public class ThreadBindingList<T> : BindingList<T>
    {
        private readonly SynchronizationContext _ctx;

        public ThreadBindingList()
        {
            _ctx = SynchronizationContext.Current;
        }
        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            if (_ctx == null)
            {
                BaseAddingNew(e);
            }
            else
            {
                _ctx.Send(delegate
                {
                    BaseAddingNew(e);
                }, null);
            }
        }
        void BaseAddingNew(AddingNewEventArgs e)
        {
            base.OnAddingNew(e);
        }
        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (_ctx == null)
            {
                BaseListChanged(e);
            }
            else
            {
                _ctx.Send(delegate
                {
                    BaseListChanged(e);
                }, null);
            }
        }
        void BaseListChanged(ListChangedEventArgs e)
        {
            base.OnListChanged(e);
        }
    }
}

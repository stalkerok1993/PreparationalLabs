using System;
using System.Threading;

namespace Mobile.Threads
{
    public sealed class ManageableAction
    {
        private const bool DEFAULT_IS_WORKING = true;

        private readonly EventWaitHandle waitHandle = new EventWaitHandle(DEFAULT_IS_WORKING, EventResetMode.ManualReset);
        private readonly Action action;

        private volatile bool isWorking = DEFAULT_IS_WORKING;

        public bool IsWorking => isWorking;

        public ManageableAction(Action action) {
            this.action = action;
        }

        public void ThreadStart() {
            while (true) {
                waitHandle.WaitOne();
                action();
            }
        }

        public void Continue() {
            waitHandle.Set();
            isWorking = true;
        }

        public void Suspend() {
            waitHandle.Reset();
            isWorking = false;
        }
    }
}

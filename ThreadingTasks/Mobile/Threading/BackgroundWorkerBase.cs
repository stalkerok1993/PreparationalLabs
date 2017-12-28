using System;

namespace Mobile.Threading {
    public abstract class BackgroundWorkerBase {
        protected Action backgroundWork;
        protected BackgroundWorkerBase(Action work) {
            this.backgroundWork = work;
        }

        public abstract void Start();
    }
}

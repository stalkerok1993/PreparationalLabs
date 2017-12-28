using System;
using System.Threading;

namespace Mobile.Threading {
    public class ThreadBackgroundWorker : BackgroundWorkerBase {
        private Thread workerThread;

        public ThreadBackgroundWorker(Action backgroundWork) : base(backgroundWork) { }

        public override void Start() {
            if (workerThread == null) {
                lock (this) {
                    if (workerThread == null) {
                        workerThread = new Thread(() => backgroundWork());
                        workerThread.IsBackground = true;
                        workerThread.Start();
                    }
                }
            }
        }
    }
}

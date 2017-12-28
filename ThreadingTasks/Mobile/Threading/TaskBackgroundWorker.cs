using System;
using System.Threading.Tasks;

namespace Mobile.Threading {
    public class TaskBackgroundWorker : BackgroundWorkerBase {
        private Task workerTask;

        public TaskBackgroundWorker(Action backgroundWork) : base(backgroundWork) { }

        public override void Start() {
            if (workerTask == null) {
                lock (this) {
                    if (workerTask == null) {
                        workerTask = new Task(backgroundWork);
                        workerTask.Start();
                    }
                }
            }
        }
    }
}

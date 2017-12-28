using System;

namespace Mobile.Threading {
    public class BackgroundWorkerFactoryMethod {

        public BackgroundWorkerBase CreateWorker(Action backgroundWork, WorkerType workerType = WorkerType.Task) {
            switch (workerType) {
                case WorkerType.Task:
                    return new TaskBackgroundWorker(backgroundWork);
                case WorkerType.Thread:
                default:
                    return new ThreadBackgroundWorker(backgroundWork);
            }
        }

        public enum WorkerType {
            Thread,
            Task
        }
    }
}

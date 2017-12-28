using System;

namespace Mobile.Threading {
    public sealed class BackgroundWorkerFactoryMethod {
        private WorkerType workerType;

        public BackgroundWorkerFactoryMethod(WorkerType workerType = WorkerType.Task) {
            this.workerType = workerType;
        }

        public BackgroundWorkerBase CreateWorker(Action backgroundWork) {
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

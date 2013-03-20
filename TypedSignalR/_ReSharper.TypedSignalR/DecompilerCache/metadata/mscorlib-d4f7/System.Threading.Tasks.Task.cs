// Type: System.Threading.Tasks.Task
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading;

namespace System.Threading.Tasks
{
    [DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
    [DebuggerTypeProxy(typeof (SystemThreadingTasks_TaskDebugView))]
    [__DynamicallyInvokable]
    public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
    {
        internal const int TASK_STATE_STARTED = 65536;
        internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
        internal const int TASK_STATE_DISPOSED = 262144;
        internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
        internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
        internal const int TASK_STATE_FAULTED = 2097152;
        internal const int TASK_STATE_CANCELED = 4194304;
        internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
        internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
        internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
        internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
        internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
        internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
        internal const int TASK_STATE_EXECUTIONCONTEXT_IS_NULL = 536870912;
        private const int OptionsMask = 65535;
        private const int TASK_STATE_COMPLETED_MASK = 23068672;
        private const int CANCELLATION_REQUESTED = 1;
        [ThreadStatic] internal static Task t_currentTask;
        [ThreadStatic] private static StackGuard t_stackGuard;
        internal static int s_taskIdCounter;
        private static readonly TaskFactory s_factory;
        private static readonly object s_taskCompletionSentinel;
        private static readonly Action<object> s_taskCancelCallback;
        private static readonly Func<Task.ContingentProperties> s_createContingentProperties;
        private static Task s_completedTask;
        private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;
        [SecurityCritical] private static ContextCallback s_ecCallback;
        private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;
        internal readonly Task m_parent;
        internal object m_action;
        internal volatile Task.ContingentProperties m_contingentProperties;
        private volatile object m_continuationObject;
        internal volatile int m_stateFlags;
        internal object m_stateObject;
        private volatile int m_taskId;
        internal TaskScheduler m_taskScheduler;
        static Task();
        internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct);
        internal Task();
        internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle);

        [__DynamicallyInvokable]
        public Task(Action action);

        [__DynamicallyInvokable]
        public Task(Action action, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public Task(Action action, TaskCreationOptions creationOptions);

        [__DynamicallyInvokable]
        public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions);

        [__DynamicallyInvokable]
        public Task(Action<object> action, object state);

        [__DynamicallyInvokable]
        public Task(Action<object> action, object state, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public Task(Action<object> action, object state, TaskCreationOptions creationOptions);

        [__DynamicallyInvokable]
        public Task(Action<object> action, object state, CancellationToken cancellationToken,
                    TaskCreationOptions creationOptions);

        internal Task(Action<object> action, object state, Task parent, CancellationToken cancellationToken,
                      TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler,
                      ref StackCrawlMark stackMark);

        internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken,
                      TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler);

        private string DebuggerDisplayMethodDescription { get; }
        internal TaskCreationOptions Options { get; }

        internal bool IsWaitNotificationEnabledOrNotRanToCompletion { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
        internal bool IsWaitNotificationEnabled { get; }

        [__DynamicallyInvokable]
        public int Id { [__DynamicallyInvokable]
        get; }

        [__DynamicallyInvokable]
        public static int? CurrentId { [__DynamicallyInvokable]
        get; }

        internal static Task InternalCurrent { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        internal static StackGuard CurrentStackGuard { get; }

        [__DynamicallyInvokable]
        public AggregateException Exception { [__DynamicallyInvokable]
        get; }

        [__DynamicallyInvokable]
        public TaskStatus Status { [__DynamicallyInvokable]
        get; }

        [__DynamicallyInvokable]
        public bool IsCanceled { [__DynamicallyInvokable]
        get; }

        internal bool IsCancellationRequested { get; }
        internal CancellationToken CancellationToken { get; }
        internal bool IsCancellationAcknowledged { get; }
        internal bool IsRanToCompletion { get; }

        [__DynamicallyInvokable]
        public TaskCreationOptions CreationOptions { [__DynamicallyInvokable]
        get; }

        internal TaskScheduler ExecutingTaskScheduler { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        [__DynamicallyInvokable]
        public static TaskFactory Factory { [__DynamicallyInvokable,
                                             TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        internal static Task CompletedTask { [FriendAccessAllowed]
        get; }

        internal ManualResetEventSlim CompletedEvent { get; }
        internal bool IsSelfReplicatingRoot { get; }
        internal bool IsChildReplica { get; }
        internal int ActiveChildCount { get; }
        internal bool ExceptionRecorded { get; }

        [__DynamicallyInvokable]
        public bool IsFaulted { [__DynamicallyInvokable]
        get; }

        internal ExecutionContext CapturedContext { get; set; }
        internal bool IsExceptionObservedByParent { get; }
        internal bool IsDelegateInvoked { get; }
        internal virtual object SavedStateForNextReplica { get; set; }
        internal virtual object SavedStateFromPreviousReplica { get; set; }
        internal virtual Task HandedOverChildReplica { get; set; }

        #region IAsyncResult Members

        [__DynamicallyInvokable]
        public bool IsCompleted { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"),
                                   __DynamicallyInvokable]
        get; }

        [__DynamicallyInvokable]
        WaitHandle IAsyncResult.AsyncWaitHandle { [__DynamicallyInvokable]
        get; }

        [__DynamicallyInvokable]
        public object AsyncState { [__DynamicallyInvokable,
                                    TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        [__DynamicallyInvokable]
        bool IAsyncResult.CompletedSynchronously { [__DynamicallyInvokable]
        get; }

        #endregion

        #region IDisposable Members

        public void Dispose();

        #endregion

        #region IThreadPoolWorkItem Members

        [SecurityCritical]
        void IThreadPoolWorkItem.ExecuteWorkItem();

        [SecurityCritical]
        void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae);

        #endregion

        internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken,
                                          TaskCreationOptions creationOptions, InternalTaskOptions internalOptions,
                                          TaskScheduler scheduler);

        [SecuritySafeCritical]
        internal void PossiblyCaptureContext(ref StackCrawlMark stackMark);

        internal static TaskCreationOptions OptionsMethod(int flags);
        internal bool AtomicStateUpdate(int newBits, int illegalBits);
        internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags);
        internal void SetNotificationForWaitCompletion(bool enabled);
        internal bool NotifyDebuggerOfWaitCompletionIfNecessary();
        internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal bool MarkStarted();

        internal void AddNewChild();
        internal void DisregardChild();

        [__DynamicallyInvokable]
        public void Start();

        [__DynamicallyInvokable]
        public void Start(TaskScheduler scheduler);

        [__DynamicallyInvokable]
        public void RunSynchronously();

        [__DynamicallyInvokable]
        public void RunSynchronously(TaskScheduler scheduler);

        [SecuritySafeCritical]
        internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion);

        internal static Task InternalStartNew(Task creatingTask, Delegate action, object state,
                                              CancellationToken cancellationToken, TaskScheduler scheduler,
                                              TaskCreationOptions options, InternalTaskOptions internalOptions,
                                              ref StackCrawlMark stackMark);

        internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions);
        internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        private static bool IsCompletedMethod(int flags);

        protected virtual void Dispose(bool disposing);

        [SecuritySafeCritical]
        internal void ScheduleAndStart(bool needsProtection);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal void AddException(object exceptionObject);

        internal void AddException(object exceptionObject, bool representsCancellation);
        internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos();
        internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo();
        internal void ThrowIfExceptional(bool includeTaskCanceledExceptions);
        internal void UpdateExceptionObservedStatus();
        internal void Finish(bool bUserDelegateExecuted);
        internal void FinishStageTwo();
        internal void FinishStageThree();
        internal void ProcessChildCompletion(Task childTask);
        internal void AddExceptionsFromChildren();
        internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan);
        internal virtual bool ShouldReplicate();

        internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask,
                                                TaskScheduler taskScheduler,
                                                TaskCreationOptions creationOptionsForReplica,
                                                InternalTaskOptions internalOptionsForReplica);

        [SecuritySafeCritical]
        internal bool ExecuteEntry(bool bPreventDoubleExecution);

        internal virtual void InnerInvoke();

        [MethodImpl(MethodImplOptions.NoInlining)]
        internal void InnerInvokeWithArg(Task childTask);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        [__DynamicallyInvokable]
        public TaskAwaiter GetAwaiter();

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        [__DynamicallyInvokable]
        public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext);

        [SecurityCritical]
        internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext,
                                              bool flowExecutionContext, ref StackCrawlMark stackMark);

        [__DynamicallyInvokable]
        public static YieldAwaitable Yield();

        [__DynamicallyInvokable]
        public void Wait();

        [__DynamicallyInvokable]
        public bool Wait(TimeSpan timeout);

        [__DynamicallyInvokable]
        public void Wait(CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public bool Wait(int millisecondsTimeout);

        [__DynamicallyInvokable]
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);

        internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken);

        [SecuritySafeCritical]
        internal bool InternalCancel(bool bCancelNonExecutingOnly);

        internal void RecordInternalCancellationRequest();
        internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord);
        internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException);
        internal void CancellationCleanupLogic();

        [SecuritySafeCritical]
        internal void FinishContinuations();

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task> continuationAction);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken,
                                 TaskContinuationOptions continuationOptions, TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task, object> continuationAction, object state);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task, object> continuationAction, object state,
                                 CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task, object> continuationAction, object state,
                                 TaskContinuationOptions continuationOptions);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task, object> continuationAction, object state,
                                 CancellationToken cancellationToken, TaskContinuationOptions continuationOptions,
                                 TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction,
                                                   CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction,
                                                   TaskContinuationOptions continuationOptions);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction,
                                                   CancellationToken cancellationToken,
                                                   TaskContinuationOptions continuationOptions, TaskScheduler scheduler);

        private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler,
                                                    CancellationToken cancellationToken,
                                                    TaskContinuationOptions continuationOptions,
                                                    ref StackCrawlMark stackMark);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state,
                                                   CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state,
                                                   TaskScheduler scheduler);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state,
                                                   TaskContinuationOptions continuationOptions);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state,
                                                   CancellationToken cancellationToken,
                                                   TaskContinuationOptions continuationOptions, TaskScheduler scheduler);

        private Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state,
                                                    TaskScheduler scheduler, CancellationToken cancellationToken,
                                                    TaskContinuationOptions continuationOptions,
                                                    ref StackCrawlMark stackMark);

        internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions,
                                                                    out TaskCreationOptions creationOptions,
                                                                    out InternalTaskOptions internalOptions);

        internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler,
                                       CancellationToken cancellationToken, TaskContinuationOptions options);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal void AddCompletionAction(ITaskCompletionAction action);

        private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers);
        internal void RemoveContinuation(object continuationObject);

        [__DynamicallyInvokable]
        public static void WaitAll(params Task[] tasks);

        [__DynamicallyInvokable]
        public static bool WaitAll(Task[] tasks, TimeSpan timeout);

        [__DynamicallyInvokable]
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout);

        [__DynamicallyInvokable]
        public static void WaitAll(Task[] tasks, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

        private static void AddToList<T>(T item, ref List<T> list, int initSize);
        internal static void FastWaitAll(Task[] tasks);
        internal static void AddExceptionsForCompletedTask(ref List<Exception> exceptions, Task t);

        [__DynamicallyInvokable]
        public static int WaitAny(params Task[] tasks);

        [__DynamicallyInvokable]
        public static int WaitAny(Task[] tasks, TimeSpan timeout);

        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static int WaitAny(Task[] tasks, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static int WaitAny(Task[] tasks, int millisecondsTimeout);

        [__DynamicallyInvokable]
        public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task<TResult> FromResult<TResult>(TResult result);

        [FriendAccessAllowed]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal static Task FromException(Exception exception);

        [FriendAccessAllowed]
        internal static Task<TResult> FromException<TResult>(Exception exception);

        [FriendAccessAllowed]
        internal static Task FromCancellation(CancellationToken cancellationToken);

        [FriendAccessAllowed]
        internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken);

        internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Task Run(Action action);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Task Run(Action action, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Task<TResult> Run<TResult>(Func<TResult> function);

        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task Run(Func<Task> function);

        [__DynamicallyInvokable]
        public static Task Run(Func<Task> function, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function);

        [__DynamicallyInvokable]
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task Delay(TimeSpan delay);

        [__DynamicallyInvokable]
        public static Task Delay(TimeSpan delay, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task Delay(int millisecondsDelay);

        [__DynamicallyInvokable]
        public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken);

        [__DynamicallyInvokable]
        public static Task WhenAll(IEnumerable<Task> tasks);

        [__DynamicallyInvokable]
        public static Task WhenAll(params Task[] tasks);

        [__DynamicallyInvokable]
        public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks);

        [__DynamicallyInvokable]
        public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks);

        private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks);

        [__DynamicallyInvokable]
        public static Task<Task> WhenAny(params Task[] tasks);

        [__DynamicallyInvokable]
        public static Task<Task> WhenAny(IEnumerable<Task> tasks);

        [__DynamicallyInvokable]
        public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks);

        [__DynamicallyInvokable]
        public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks);

        [FriendAccessAllowed]
        internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce);

        private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent,
                                             TaskContinuation continuation);

        private static void TaskCancelCallback(object o);

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void NotifyDebuggerOfWaitCompletion();

        private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection);
        private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext);
        private AggregateException GetExceptions(bool includeTaskCanceledExceptions);
        private void Execute();
        private static void ExecuteSelfReplicating(Task root);

        [SecurityCritical]
        private void ExecuteWithThreadLocal(ref Task currentTaskSlot);

        [SecurityCritical]
        private static void ExecutionContextCallback(object obj);

        private void HandleException(Exception unhandledException);
        private bool WrappedTryRunInline();
        private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken);
        private bool SpinWait(int millisecondsTimeout);
        private void SetCancellationAcknowledged();

        private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler,
                                  CancellationToken cancellationToken, TaskContinuationOptions continuationOptions,
                                  ref StackCrawlMark stackMark);

        private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler,
                                  CancellationToken cancellationToken, TaskContinuationOptions continuationOptions,
                                  ref StackCrawlMark stackMark);

        private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers);
        private bool AddTaskContinuation(object tc, bool addBeforeOthers);

        private static bool WaitAllBlockingCore(List<Task> tasks, int millisecondsTimeout,
                                                CancellationToken cancellationToken);

        private static Task InternalWhenAll(Task[] tasks);

        #region Nested type: ContingentProperties

        internal class ContingentProperties
        {
            internal Shared<CancellationTokenRegistration> m_cancellationRegistration;
            internal CancellationToken m_cancellationToken;
            internal ExecutionContext m_capturedContext;
            internal volatile int m_completionCountdown;
            internal volatile ManualResetEventSlim m_completionEvent;
            internal volatile List<Task> m_exceptionalChildren;
            internal volatile TaskExceptionHolder m_exceptionsHolder;
            internal volatile int m_internalCancellationRequested;
            internal void SetCompleted();
            internal void DeregisterCancellationCallback();
        }

        #endregion

        #region Nested type: DelayPromise

        private sealed class DelayPromise : Task<VoidTaskResult>
        {
            internal readonly CancellationToken Token;
            internal CancellationTokenRegistration Registration;
            internal Timer Timer;
            internal DelayPromise(CancellationToken token);
            internal void Complete();
        }

        #endregion

        #region Nested type: SetOnCountdownMres

        private sealed class SetOnCountdownMres : ManualResetEventSlim, ITaskCompletionAction
        {
            private int _count;
            internal SetOnCountdownMres(int count);

            #region ITaskCompletionAction Members

            public void Invoke(Task completingTask);

            #endregion
        }

        #endregion

        #region Nested type: SetOnInvokeMres

        private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
        {
            internal SetOnInvokeMres();

            #region ITaskCompletionAction Members

            public void Invoke(Task completingTask);

            #endregion
        }

        #endregion

        #region Nested type: WhenAllPromise

        private sealed class WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction
        {
            private readonly Task<T>[] m_tasks;
            private int m_count;
            internal WhenAllPromise(Task<T>[] tasks);
            internal override bool ShouldNotifyDebuggerOfWaitCompletion { get; }

            #region ITaskCompletionAction Members

            public void Invoke(Task ignored);

            #endregion
        }

        private sealed class WhenAllPromise : Task<VoidTaskResult>, ITaskCompletionAction
        {
            private readonly Task[] m_tasks;
            private int m_count;
            internal WhenAllPromise(Task[] tasks);
            internal override bool ShouldNotifyDebuggerOfWaitCompletion { get; }

            #region ITaskCompletionAction Members

            public void Invoke(Task ignored);

            #endregion
        }

        #endregion
    }
}

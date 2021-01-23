/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.Internal;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	public abstract class AsyncTriggerBase : MonoBehaviour
	{
		// Fields
		private static readonly Action<object> Callback;
		private bool calledAwake;
		private bool destroyCalled;
		private CancellationTokenRegistration[] registeredCancellations;
		private int registeredCancellationsCount;
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem
		{
			// Fields
			private readonly AsyncTriggerBase trigger;
	
			// Constructors
			public AwakeMonitor(AsyncTriggerBase trigger);
	
			// Methods
			public bool MoveNext();
		}
	
		[CompilerGenerated]
		private sealed class _Concat_d__6 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise>
		{
			// Fields
			private int __1__state;
			private ICancelablePromise __2__current;
			private int __l__initialThreadId;
			private ICancelablePromise p1;
			public ICancelablePromise __3__p1;
			private IEnumerable<ICancelablePromise> p1s;
			public IEnumerable<ICancelablePromise> __3__p1s;
			private IEnumerator<ICancelablePromise> __7__wrap1;
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _Concat_d__7 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise>
		{
			// Fields
			private int __1__state;
			private ICancelablePromise __2__current;
			private int __l__initialThreadId;
			private ICancelablePromise p1;
			public ICancelablePromise __3__p1;
			private IEnumerable<ICancelablePromise> p1s;
			public IEnumerable<ICancelablePromise> __3__p1s;
			private ICancelablePromise p2;
			public ICancelablePromise __3__p2;
			private IEnumerable<ICancelablePromise> p2s;
			public IEnumerable<ICancelablePromise> __3__p2s;
			private IEnumerator<ICancelablePromise> __7__wrap1;
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _Concat_d__8 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise>
		{
			// Fields
			private int __1__state;
			private ICancelablePromise __2__current;
			private int __l__initialThreadId;
			private ICancelablePromise p1;
			public ICancelablePromise __3__p1;
			private IEnumerable<ICancelablePromise> p1s;
			public IEnumerable<ICancelablePromise> __3__p1s;
			private ICancelablePromise p2;
			public ICancelablePromise __3__p2;
			private IEnumerable<ICancelablePromise> p2s;
			public IEnumerable<ICancelablePromise> __3__p2s;
			private ICancelablePromise p3;
			public ICancelablePromise __3__p3;
			private IEnumerable<ICancelablePromise> p3s;
			public IEnumerable<ICancelablePromise> __3__p3s;
			private IEnumerator<ICancelablePromise> __7__wrap1;
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			private void __m__Finally3();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _Concat_d__9 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise>
		{
			// Fields
			private int __1__state;
			private ICancelablePromise __2__current;
			private int __l__initialThreadId;
			private ICancelablePromise p1;
			public ICancelablePromise __3__p1;
			private IEnumerable<ICancelablePromise> p1s;
			public IEnumerable<ICancelablePromise> __3__p1s;
			private ICancelablePromise p2;
			public ICancelablePromise __3__p2;
			private IEnumerable<ICancelablePromise> p2s;
			public IEnumerable<ICancelablePromise> __3__p2s;
			private ICancelablePromise p3;
			public ICancelablePromise __3__p3;
			private IEnumerable<ICancelablePromise> p3s;
			public IEnumerable<ICancelablePromise> __3__p3s;
			private ICancelablePromise p4;
			public ICancelablePromise __3__p4;
			private IEnumerable<ICancelablePromise> p4s;
			public IEnumerable<ICancelablePromise> __3__p4s;
			private IEnumerator<ICancelablePromise> __7__wrap1;
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			private void __m__Finally3();
			private void __m__Finally4();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _Concat_d__10 : IEnumerable<ICancelablePromise>, IEnumerator<ICancelablePromise>
		{
			// Fields
			private int __1__state;
			private ICancelablePromise __2__current;
			private int __l__initialThreadId;
			private object[] promises;
			public object[] __3__promises;
			private object[] __7__wrap1;
			private int __7__wrap2;
			private IEnumerator<ICancelablePromise> __7__wrap3;
	
			// Properties
			ICancelablePromise IEnumerator<UniRx.Async.Triggers.ICancelablePromise>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		protected AsyncTriggerBase();
		static AsyncTriggerBase();
	
		// Methods
		protected abstract IEnumerable<ICancelablePromise> GetPromises();
		[IteratorStateMachine]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s);
		[IteratorStateMachine]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s);
		[IteratorStateMachine]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s);
		[IteratorStateMachine]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s, ICancelablePromise p4, IEnumerable<ICancelablePromise> p4s);
		[IteratorStateMachine]
		protected static IEnumerable<ICancelablePromise> Concat(params object[] promises);
		protected UniTask<T> GetOrAddPromise<T>(ref AsyncTriggerPromise<T> promise, ref AsyncTriggerPromiseDictionary<T> promises, CancellationToken cancellationToken);
		private static void CancelCallback(object state);
		protected void TrySetResult<T>(ReusablePromise<T> promise, AsyncTriggerPromiseDictionary<T> promises, T value);
		private void Awake();
		private void OnDestroy();
	}
}

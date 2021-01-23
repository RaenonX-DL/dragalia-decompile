/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class LeanThreadPool
	{
		// Fields
		private static LeanThreadPool instance;
		private Thread[] threads;
		private Semaphore semaphore;
		private object jobsLock;
		private object convergeLock;
		private List<ParallelJob> jobs;
		private bool quit;
		private int convergeCount;
	
		// Properties
		public static LeanThreadPool Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _KillAll_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LeanThreadPool __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _KillAll_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		private LeanThreadPool();
		static LeanThreadPool();
	
		// Methods
		private void ThreadFunction();
		[IteratorStateMachine]
		public IEnumerator KillAll();
		public void AddJob(ParallelJob job);
	}
}

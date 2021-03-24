/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Image 40: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class Dispatcher
	{
		// Fields
		private int ownerThreadId;
		private Queue<Action> queue;
	
		// Nested types
		private class CallbackStorage<TResult>
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable]
			private TResult _Result_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable]
			private Exception _Exception_k__BackingField;
	
			// Properties
			public TResult Result { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Exception Exception { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public CallbackStorage();
		}
	
		[CompilerGenerated]
		private sealed class _Run_c__AnonStorey0<TResult>
		{
			// Fields
			internal Func<TResult> callback;
			internal CallbackStorage<TResult> result;
			internal EventWaitHandle waitHandle;
	
			// Constructors
			public _Run_c__AnonStorey0();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _RunAsync_c__AnonStorey1<TResult>
		{
			// Fields
			internal TaskCompletionSource<TResult> tcs;
			internal Func<TResult> callback;
	
			// Constructors
			public _RunAsync_c__AnonStorey1();
	
			// Methods
			internal void __m__0();
		}
	
		// Constructors
		public Dispatcher();
	
		// Methods
		public TResult Run<TResult>(Func<TResult> callback);
		public Task<TResult> RunAsync<TResult>(Func<TResult> callback);
		internal static Task<TResult> RunAsyncNow<TResult>(Func<TResult> callback);
		internal bool ManagesThisThread();
		public void PollJobs();
	}
}

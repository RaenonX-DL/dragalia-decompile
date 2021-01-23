/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

// Image 39: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Unity
{
	[Preserve]
	internal class UnitySynchronizationContext : SynchronizationContext
	{
		// Fields
		private static UnitySynchronizationContext _instance;
		private Queue<Tuple<SendOrPostCallback, object>> queue;
		private SynchronizationContextBehavoir behavior;
		private int mainThreadId;
		private static Dictionary<int, ManualResetEvent> signalDictionary;
	
		// Nested types
		private class SynchronizationContextBehavoir : MonoBehaviour
		{
			// Fields
			private Queue<Tuple<SendOrPostCallback, object>> callbackQueue;
	
			// Properties
			public Queue<Tuple<SendOrPostCallback, object>> CallbackQueue { get; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class _Start_c__Iterator0 : IEnumerator<object>
			{
				// Fields
				internal Tuple<SendOrPostCallback, object> _entry___0;
				internal object _locvar0;
				internal SynchronizationContextBehavoir _this;
				internal object _current;
				internal bool _disposing;
				internal int _PC;
	
				// Properties
				object IEnumerator<object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _Start_c__Iterator0();
	
				// Methods
				public bool MoveNext();
				[DebuggerHidden]
				public void Dispose();
				[DebuggerHidden]
				public void Reset();
			}
	
			// Constructors
			public SynchronizationContextBehavoir();
	
			// Methods
			[DebuggerHidden]
			[Preserve]
			private IEnumerator Start();
		}
	
		[CompilerGenerated]
		private sealed class _SignaledCoroutine_c__Iterator0 : IEnumerator<object>
		{
			// Fields
			internal Func<IEnumerator> coroutine;
			internal ManualResetEvent newSignal;
			internal object _current;
			internal bool _disposing;
			internal int _PC;
	
			// Properties
			object IEnumerator<object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SignaledCoroutine_c__Iterator0();
	
			// Methods
			public bool MoveNext();
			[DebuggerHidden]
			public void Dispose();
			[DebuggerHidden]
			public void Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SendCoroutine_c__AnonStorey1
		{
			// Constructors
			public _SendCoroutine_c__AnonStorey1();
		}
	
		[CompilerGenerated]
		private sealed class _SendCoroutine_c__AnonStorey2
		{
			// Constructors
			public _SendCoroutine_c__AnonStorey2();
		}
	
		[CompilerGenerated]
		private sealed class _Send_c__AnonStorey3
		{
			// Fields
			internal SendOrPostCallback d;
	
			// Constructors
			public _Send_c__AnonStorey3();
		}
	
		[CompilerGenerated]
		private sealed class _Send_c__AnonStorey4
		{
			// Fields
			internal ManualResetEvent newSignal;
			internal _Send_c__AnonStorey3 __f__ref_3;
	
			// Constructors
			public _Send_c__AnonStorey4();
	
			// Methods
			internal void __m__0(object x);
		}
	
		// Constructors
		private UnitySynchronizationContext(GameObject gameObject);
		static UnitySynchronizationContext();
	
		// Methods
		public static void Create(GameObject gameObject);
		public static void Destroy();
		private ManualResetEvent GetThreadEvent();
		public override void Post(SendOrPostCallback d, object state);
		public override void Send(SendOrPostCallback d, object state);
	}
}

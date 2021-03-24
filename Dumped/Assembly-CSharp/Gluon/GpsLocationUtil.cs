/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class GpsLocationUtil
	{
		// Properties
		public static bool IsEnabledByUser { get; }
		public static float Latitude { get; }
		public static float Longitude { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetLocationInfoCoroutine_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitMaxTime;
			public Action onError;
			public Action onSucceess;
			private float _waitTime_5__2;
			private float _waitStep_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetLocationInfoCoroutine_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _RequestLocationPermission_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onDenied;
			public Action onPermitted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RequestLocationPermission_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Methods
		[IteratorStateMachine]
		public static IEnumerator GetLocationInfoCoroutine(float waitMaxTime, Action onSucceess, Action onError);
		[IteratorStateMachine]
		public static IEnumerator RequestLocationPermission(Action onPermitted, Action onDenied);
	}
}

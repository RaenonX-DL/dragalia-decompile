/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SingletonInBaseMonoBehaviour<T> : MonoBehaviour
		where T : MonoBehaviour
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _MoveMeToBase_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T obj;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MoveMeToBase_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SingletonInBaseMonoBehaviour();
		static SingletonInBaseMonoBehaviour();
	
		// Methods
		protected virtual void Awake();
		public static bool IsInstanceEmpty();
		protected virtual void OnDestroy();
		[IteratorStateMachine]
		public static IEnumerator MoveMeToBase(T obj);
	}
}

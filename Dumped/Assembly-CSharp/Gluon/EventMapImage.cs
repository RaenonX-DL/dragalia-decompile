/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventMapImage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public RawImage render3dImage;
		[SerializeField]
		public Camera render3dCamera;
		private bool is3DBgLoaded;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _Load3DBgSceneCoroutine_b__0();
			internal bool _Load3DBgSceneCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Load3DBgSceneCoroutine_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string filename;
			public EventMapImage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Load3DBgSceneCoroutine_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetupRenderBg_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventMapImage __4__this;
			public string filename;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupRenderBg_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventMapImage();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		[IteratorStateMachine]
		private IEnumerator Load3DBgSceneCoroutine(string filename);
		[IteratorStateMachine]
		public IEnumerator SetupRenderBg(string filename);
		[CompilerGenerated]
		private bool _SetupRenderBg_b__6_0();
	}
}

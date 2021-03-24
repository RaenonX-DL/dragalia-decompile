/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryScene : SceneBase
	{
		// Fields
		[SerializeField]
		protected GameObject cameraRootObject;
		private StoryCanvas mainCanvas;
		private DownloadOperation downloadOperation;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public StoryScene __4__this;
			public AsyncOperation unloadOperation;
			public UnityAction __9__8;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _WaitPrevSceneExit_b__4(DownloadErrorType type, string error);
			internal void _WaitPrevSceneExit_b__8();
			internal bool _WaitPrevSceneExit_b__1();
			internal bool _WaitPrevSceneExit_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__4_5;
			public static Func<bool> __9__4_6;
			public static Func<bool> __9__4_7;
			public static Func<bool> __9__4_0;
			public static Func<bool> __9__4_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _WaitPrevSceneExit_b__4_5();
			internal bool _WaitPrevSceneExit_b__4_6();
			internal bool _WaitPrevSceneExit_b__4_7();
			internal bool _WaitPrevSceneExit_b__4_0();
			internal bool _WaitPrevSceneExit_b__4_2();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryScene __4__this;
			private __c__DisplayClass4_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryScene();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		public StoryCanvas GetStoryCanvas();
	}
}

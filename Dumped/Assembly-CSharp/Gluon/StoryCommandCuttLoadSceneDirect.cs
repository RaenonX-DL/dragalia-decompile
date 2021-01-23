/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCuttLoadSceneDirect : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private DungeonManager dungeonManager;
		private DownloadOperation downloadOperation;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__3_1;
			public static Action<DownloadErrorType, string> __9__3_0;
			public static Func<bool> __9__5_0;
			public static Func<bool> __9__5_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__3_0(DownloadErrorType type, string error);
			internal void _Start_b__3_1();
			internal bool __Update_b__5_0();
			internal bool __Update_b__5_1();
		}
	
		[CompilerGenerated]
		private sealed class __Update_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandCuttLoadSceneDirect __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandCuttLoadSceneDirect();
	
		// Methods
		public void Start(string scenePath0, string scenePath1, string scenePath2, string areaName);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillScene : SceneBase
	{
		// Fields
		private Canvas mainCanvas;
		private MissionDrillMainCanvas drillMainCanvas;
		private MissionDrillCompleteCanvas completeCanvas;
		private const string mainCanvasPath = "Prefabs/OutGame/MissionDrill/MissionDrillMainCanvas";
		private const string completeCanvasPath = "Prefabs/OutGame/MissionDrill/MissionDrillCompleteCanvas";
		private const string nhaamDrillVoiceGroup = "VO_CHR_100007_01_DRILL";
		private const string soundGroup_OUT_COMMONUSE = "OUT_COMMONUSE";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UnloadScene_b__9_0();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadScene_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MissionDrillScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadScene_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MissionDrillScene();
	
		// Methods
		private void Start();
		private void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator UnloadScene();
		private void PlayCompleteDirection(DrillTalkElement talk);
		private void OnCompleteDirectionFinished();
		public override void StartExitAnimation();
	}
}

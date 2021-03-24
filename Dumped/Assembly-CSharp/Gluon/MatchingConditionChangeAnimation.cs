/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingConditionChangeAnimation : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private bool _IsOn_k__BackingField;
		private FlashPlayer flashPlayer;
		private const string requireConditionChangeFlashPath = "Prefabs/OutGame/Matching/MatchingRoom/Flash/pf_MatchingConditionIcon";
		private const string iconShaderPath = "FlashToUnity/uGUI/GraphicNormalEx";
	
		// Properties
		public bool IsOn { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Play_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public MatchingConditionChangeAnimation __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Play_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MatchingConditionChangeAnimation();
	
		// Methods
		public void Initialize(FlashPlayer flashPlayer, Material srcMat, Transform parent, bool isOn);
		[IteratorStateMachine]
		public IEnumerator Play(float delay);
		private void Play(string label);
	}
}

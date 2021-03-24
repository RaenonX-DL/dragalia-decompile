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
	public class EventTopPageCombat : EventTopPageBase
	{
		// Fields
		[SerializeField]
		private GameObject combatMultiButton;
		[SerializeField]
		private GameObject combatQuestButtonMini;
		[SerializeField]
		private GameObject combatQuestButtonBig;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForStatusInfoInitilizing_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventTopPageCombat __4__this;
			public AnimationUICanvas.AnimationPattern pattern;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStatusInfoInitilizing_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventTopPageCombat();
	
		// Methods
		protected override void Start();
		public override void OnQuestButtonTouched();
		[IteratorStateMachine]
		protected override IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern);
		[CompilerGenerated]
		[DebuggerHidden]
		private IEnumerator __n__0(AnimationPattern pattern);
	}
}

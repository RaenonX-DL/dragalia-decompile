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
	public class LoginBonusPageCharacter : LoginBonusPageBase
	{
		// Fields
		private int rewardIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EnableTapCoroutine_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnableTapCoroutine_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ExecDemoCoroutine_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageCharacter __4__this;
			public Action endCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecDemoCoroutine_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public LoginBonusRewardElement reward;
			public LoginBonusPageCharacter __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _OnScreenTapped_b__0();
		}
	
		// Constructors
		public LoginBonusPageCharacter();
	
		// Methods
		protected override void Start();
		public override void OnNextLoginBonus();
		protected override Vector2[] GetIconPositionArray(int total);
		[IteratorStateMachine]
		private IEnumerator EnableTapCoroutine();
		[IteratorStateMachine]
		private IEnumerator ExecDemoCoroutine(Action endCallback);
		public override void OnScreenTapped();
		[CompilerGenerated]
		private void _OnScreenTapped_b__6_1();
	}
}

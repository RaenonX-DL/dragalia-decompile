/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventTopPageFEH : EventTopPageBase
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForStatusInfoInitilizing_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventTopPageFEH __4__this;
			public AnimationUICanvas.AnimationPattern pattern;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStatusInfoInitilizing_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventTopPageFEH();
	
		// Methods
		public override void OnQuestButtonTouched();
		[IteratorStateMachine]
		protected override IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern);
		[CompilerGenerated]
		[DebuggerHidden]
		private IEnumerator __n__0(AnimationPattern pattern);
	}
}

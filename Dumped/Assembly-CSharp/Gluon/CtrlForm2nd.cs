/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CtrlForm2nd : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private EnemyCharacter _owner_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _original_k__BackingField;
	
		// Properties
		public EnemyCharacter owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EnemyCharacter original { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoForm2ndOff_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CtrlForm2nd __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoForm2ndOff_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CtrlForm2nd();
	
		// Methods
		public void Setup(EnemyCharacter owner_, EnemyCharacter original_);
		public void ShiftIntoForm2nd(bool ignoreSync);
		public void ShiftIntoOriginal();
		[IteratorStateMachine]
		public IEnumerator CoForm2ndOff();
	}
}

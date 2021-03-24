/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NPF.User;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NPFInitializer : SingletonMonoBehaviour<Gluon.NPFInitializer>
	{
		// Fields
		private NPFEventHandlerImpl pNPFEventhandler;
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField;
	
		// Properties
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitInitCoroutine_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NPFInitializer __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitInitCoroutine_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public NPFInitializer();
	
		// Methods
		protected override void Awake();
		public void Init();
		[IteratorStateMachine]
		public IEnumerator WaitInitCoroutine();
		[CompilerGenerated]
		private void _Init_b__6_0(BaaSUser user);
		[CompilerGenerated]
		private bool _WaitInitCoroutine_b__7_0();
	}
}

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
	public class QuestSelectList : QuestMenuList<Gluon.QSTableViewData>
	{
		// Fields
		[SerializeField]
		private QuestMainDetailList questMainDetailList;
		private DragEventScrollRect dragEventScrollRect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitOpenCompletedCoroutine_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectList __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitOpenCompletedCoroutine_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseCompletedCoroutine_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectList __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseCompletedCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectList();
	
		// Methods
		private void Awake();
		public override void OnOpen();
		protected override void Open();
		[IteratorStateMachine]
		private new IEnumerator WaitOpenCompletedCoroutine();
		public override void OnClose();
		protected override void Close();
		[IteratorStateMachine]
		private new IEnumerator WaitCloseCompletedCoroutine();
		public override bool IsOnAnimation();
		[CompilerGenerated]
		private bool _WaitOpenCompletedCoroutine_b__5_0();
		[CompilerGenerated]
		private bool _WaitCloseCompletedCoroutine_b__8_0();
	}
}

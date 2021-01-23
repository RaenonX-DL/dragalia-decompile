/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMenuList<T> : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject questViewControllerObj;
		[SerializeField]
		private float eachCellOpenWaitTime;
		private QuestCommonTableViewController<T> questViewController;
		[CompilerGenerated]
		private bool _isRenderBgReady_k__BackingField;
		[CompilerGenerated]
		private bool _isOpenCompleted_k__BackingField;
		[CompilerGenerated]
		private bool _isCloseCompleted_k__BackingField;
	
		// Properties
		public bool isRenderBgReady { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isOpenCompleted { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isCloseCompleted { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitOpenCompletedCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMenuList<T> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitOpenCompletedCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseCompletedCoroutine_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMenuList<T> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseCompletedCoroutine_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestMenuList();
	
		// Methods
		public virtual void OnOpen();
		protected virtual void Open();
		[IteratorStateMachine]
		private IEnumerator WaitOpenCompletedCoroutine();
		public virtual void OnClose();
		protected virtual void Close();
		[IteratorStateMachine]
		private IEnumerator WaitCloseCompletedCoroutine();
		public virtual bool IsOnAnimation();
		[CompilerGenerated]
		private bool _WaitOpenCompletedCoroutine_b__17_0();
		[CompilerGenerated]
		private bool _WaitOpenCompletedCoroutine_b__17_1();
		[CompilerGenerated]
		private bool _WaitCloseCompletedCoroutine_b__20_0();
		[CompilerGenerated]
		private bool _WaitCloseCompletedCoroutine_b__20_1();
	}
}

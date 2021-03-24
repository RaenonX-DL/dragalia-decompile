/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestFailedResultTopPage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private QuestFailedResultMultiRebattlePage multiRebattlePage;
		[CompilerGenerated]
		private QuestFailedResultScene _sceneObj_k__BackingField;
		private int questId;
		private bool rebattleCanFlag;
		private bool isOnPressNext;
		private DateTime rebattleStartTime;
		public const float animationWaitTime = 0.033333335f;
		private UnityEvent backKeyEvent;
	
		// Properties
		public QuestFailedResultScene sceneObj { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateReBattleCountDown_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestFailedResultTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateReBattleCountDown_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestFailedResultTopPage();
	
		// Methods
		public void OnPressNext();
		private void OnRebattlePageDone();
		public void InitByData();
		private void SetBackKey(UnityAction action);
		private void Disconnect();
		[IteratorStateMachine]
		private IEnumerator UpdateReBattleCountDown();
	}
}

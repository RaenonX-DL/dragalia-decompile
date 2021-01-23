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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultMultiReBattleConfirm : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text rebattleCountDownText;
		public UnityEvent onExit;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateReBattle_d__3 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int reBattleCount;
			public DateTime rebattleStartTime;
			public QuestResultMultiReBattleConfirm __4__this;
			private int _maxPointCount_5__2;
			private float _time_5__3;
			private string _dot_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateReBattle_d__3(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultMultiReBattleConfirm();
	
		// Methods
		public void SetTimer(int maxTime, DateTime startTime);
		[IteratorStateMachine]
		private IEnumerator UpdateReBattle(int reBattleCount, DateTime rebattleStartTime);
		public void OnExitPressed();
	}
}

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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultEarnEventBonusList : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Transform contentTransform;
		[SerializeField]
		private float moveDis;
		[SerializeField]
		private QuestResultEarnEventBonusCell clearStageCell;
		private float moveDuration;
		private List<QuestResultEarnEventBonusCell> bonusCells;
		private bool isMovingUp;
		[CompilerGenerated]
		private bool _isSkipped_k__BackingField;
	
		// Properties
		public bool isSkipped { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public QuestResultEarnEventBonusList __4__this;
			public QuestResultEarnEventBonus buildEventResult;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _StartEnterAnimation_b__1();
			internal bool _StartEnterAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _StartEnterAnimation_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultEarnEventBonusList __4__this;
			public QuestResultEarnEventBonus buildEventResult;
			private __c__DisplayClass11_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEnterAnimation_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultEarnEventBonusList();
	
		// Methods
		public void SetContent(QuestDataElement dataElement);
		[IteratorStateMachine]
		public IEnumerator StartEnterAnimation(QuestResultEarnEventBonus buildEventResult);
		public void SkipEnterAnimation();
		public bool IsOnAnimation();
	}
}

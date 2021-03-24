/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRBuildEventBonusList : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Transform contentTransform;
		[SerializeField]
		private float moveDis;
		private float moveDuration;
		[SerializeField]
		private QRBuildEventBonusCell clearStageCell;
		[CompilerGenerated]
		private bool _isSkipped_k__BackingField;
		private List<QRBuildEventBonusCell> bonusCells;
		private QuestResultTopPage resultTop;
		private bool isMovingUp;
	
		// Properties
		public bool isSkipped { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<AtgenScoreMissionSuccessList, bool> __9__12_0;
			public static Func<AtgenScoreMissionSuccessList, int> __9__12_1;
			public static Func<AtgenScoreMissionSuccessList, int> __9__12_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SortScoreMissions_b__12_0(AtgenScoreMissionSuccessList x);
			internal int _SortScoreMissions_b__12_1(AtgenScoreMissionSuccessList x);
			internal int _SortScoreMissions_b__12_2(AtgenScoreMissionSuccessList x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public QRBuildEventBonusList __4__this;
			public QRBuildEventResult buildEventResult;
			public int clearStagePoint;
			public int finishedCheckAnimationCount;
			public int clearedMissionCellCount;
			public Action __9__4;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _StartEnterAnimation_b__2();
			internal bool _StartEnterAnimation_b__0();
			internal void _StartEnterAnimation_b__4();
			internal void _StartEnterAnimation_b__3();
			internal bool _StartEnterAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _StartEnterAnimation_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRBuildEventBonusList __4__this;
			public QRBuildEventResult buildEventResult;
			private __c__DisplayClass13_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEnterAnimation_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QRBuildEventBonusList();
	
		// Methods
		public void SetContent(QuestDataElement dataElement, QuestResultTopPage resultTop);
		private AtgenScoreMissionSuccessList[] SortScoreMissions();
		[IteratorStateMachine]
		public IEnumerator StartEnterAnimation(QRBuildEventResult buildEventResult);
		public void SkipEnterAnimation();
		public bool IsOnAnimation();
	}
}

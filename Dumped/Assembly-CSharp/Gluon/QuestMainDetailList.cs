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
	public class QuestMainDetailList : QuestListBase
	{
		// Fields
		[SerializeField]
		private Transform contentTransfrom;
		public AnimationListOneCol listAnimation;
		[SerializeField]
		private GameObject scrollBarObj;
		[SerializeField]
		private UIAnimationPublisher scrollBarAnimation;
		private List<QuestMainMenuElement> mainDataList;
		private int locationId;
		private QuestSelectScene.Difficulty difficulty;
		private float initialPosY;
		public QuestCell mainStoryMissionTargetCell;
		[CompilerGenerated]
		private bool _isOpenCompleted_k__BackingField;
		[CompilerGenerated]
		private bool _isCloseCompleted_k__BackingField;
	
		// Properties
		public bool isOpenCompleted { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isCloseCompleted { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestMainMenuElement> __9__20_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadData_b__20_0(QuestMainMenuElement a, QuestMainMenuElement b);
		}
	
		[CompilerGenerated]
		private sealed class _WaitOpenCompletedCoroutine_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMainDetailList __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitOpenCompletedCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseCompletedCoroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMainDetailList __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseCompletedCoroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestMainDetailList();
	
		// Methods
		private void Awake();
		private void OnEnable();
		public void SetContent(int locationId, QuestSelectScene.Difficulty difficulty);
		public void LoadData();
		private void CreateList();
		public void StartEnterAnimation();
		[IteratorStateMachine]
		private IEnumerator WaitOpenCompletedCoroutine();
		public void StartExitAnimation();
		[IteratorStateMachine]
		private IEnumerator WaitCloseCompletedCoroutine();
		public void ClickCell(int questId);
		[CompilerGenerated]
		private bool _WaitOpenCompletedCoroutine_b__23_0();
		[CompilerGenerated]
		private bool _WaitOpenCompletedCoroutine_b__23_1();
		[CompilerGenerated]
		private bool _WaitCloseCompletedCoroutine_b__25_0();
		[CompilerGenerated]
		private bool _WaitCloseCompletedCoroutine_b__25_1();
	}
}

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
	public class QuestSelectEventSubPage : QuestSelectEventPageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private QuestSelectEventShortCut questSelectEventShortCut;
		[SerializeField]
		private TabBase questMultiTab;
		public QuestSupportCanvas.PlayType playType;
		private int baseQuestGroupId;
		private QuestEventBannerPage bannerPage;
		private QuestSelectInstance.QuestEventData eventData;
		private Dictionary<int, float> scrollValueDic;
		private List<EventMenuCell> eventMenuCellList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _CreateEventList_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _CreateEventList_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_2
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_2();
	
			// Methods
			internal void _CreateEventList_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__23_1;
			public static Action __9__23_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _TutorialReleaseSubdueCoroutine_b__23_0();
			internal void _TutorialReleaseSubdueCoroutine_b__23_1();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialReleaseSubdueCoroutine_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventSubPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialReleaseSubdueCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectEventSubPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		private void Start();
		public override void OnPageBecomeActive(object data);
		private void OpenDefaultTab(int baseQuestGroupId);
		public void OnSelectedTab(int num);
		public override void OnPageBecomeInActive();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void CreateEventList(QuestSelectInstance.QuestEventData eventData);
		public void OnBackButtonTouched();
		public void OnMainQuestButtonTouched();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void OnPageEnterAnimationEnded();
		private void TutorialReleaseSubdue();
		[IteratorStateMachine]
		private IEnumerator TutorialReleaseSubdueCoroutine();
		[CompilerGenerated]
		private void _TutorialReleaseSubdue_b__22_0();
	}
}

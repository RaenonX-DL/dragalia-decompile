/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectEventTopPage : QuestSelectEventPageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private GameObject mainStoryMenuTitle;
		[SerializeField]
		private GameObject eventSpecialMenuTitle;
		[SerializeField]
		private GameObject eventNormalMenuTitle;
		[SerializeField]
		private GameObject eventChallengeMenuTitle;
		[SerializeField]
		private GameObject eventHighLevelMenuTitle;
		[SerializeField]
		private Transform disableMenuTitleParent;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		private int tutorialMultiBattleEventId;
		private int tutorialDragonBattleEventId;
		private int tutorialInterceptionBattleEventId;
		private float totalCellHeight;
		private Dictionary<int, float> scrollHeightDic;
		public static bool needRecreateTopList;
		private Sequence scrollSequence;
		private const float scrollDuration = 0.5f;
		private MainStoryMenuCell storyCell;
		private bool isEventListCreating;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CreateEventList_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventTopPage __4__this;
			private int _delayIndex_5__2;
			private GameObject _normalPrefab_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateEventList_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public DragEventScrollRect dragEventScrollRect;
			public QuestSelectEventTopPage __4__this;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _SetScrollTween_b__0(float value);
			internal void _SetScrollTween_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Reload_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectEventTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Reload_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectEventTopPage();
		static QuestSelectEventTopPage();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private int SetupCategorizedEventMenuCell(List<QuestSelectInstance.QuestEventData> eventsData, GameObject normalPrefab, int startDelayIndex);
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void ClearEventList();
		[IteratorStateMachine]
		private IEnumerator CreateEventList();
		private void UpdateRemainTime();
		private void AddMenuTitle(GameObject menuTitleObj, int delayIndex);
		private void CreateTutorialEventList();
		public void OnBackButtonTouched();
		public void OnMainQuestButtonTouched();
		private void ChangePageToMainQuest();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void OnPageEnterAnimationEnded();
		public override bool IsLoading();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void SetScrollPosition(QuestSelectInstance.QuestEventData targetEvent);
		private void SetScrollTween(DragEventScrollRect dragEventScrollRect, float toValue, float duration);
		public void Reload(int eventId);
		public void ReloadList();
		[IteratorStateMachine]
		private IEnumerator Reload();
		[CompilerGenerated]
		private bool _CreateEventList_b__24_0();
		[CompilerGenerated]
		private bool _Reload_b__39_0();
	}
}

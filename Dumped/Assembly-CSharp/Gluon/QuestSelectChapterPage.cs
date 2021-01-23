/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectChapterPage : QuestSelectPageBase
	{
		// Fields
		[SerializeField]
		public Canvas selfCanvas;
		[SerializeField]
		public GameObject uiSelectWheel;
		public GameObject chapterTitleRoot;
		[SerializeField]
		private FlashPosScaleInfo dragonFlashInfo;
		[CompilerGenerated]
		private List<QSChapterElement> _chapterList_k__BackingField;
		[SerializeField]
		private QuestSelectWheel questSelectWheel;
		public QuestSelectWheelElement topChapterElement;
		private QuestReleasePopup releaseChapterPopup;
		private QuestReleasePopup releaseDifficultyPopup;
		[SerializeField]
		private Transform _mainTrans;
		private FlashPlayer flashPlayerNewChapter;
		public FlashPlayer flashPlayerDragon;
		private bool isNotCloud;
		private bool isDragonAnimation;
		[SerializeField]
		public float iPhoneXMapOffset;
	
		// Properties
		public List<QSChapterElement> chapterList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform mainTtans { get; }
	
		// Nested types
		[Serializable]
		public struct FlashPosScaleInfo
		{
			// Fields
			public Vector3 localPos;
			public float localScale;
			public int sortingOrder;
		}
	
		[CompilerGenerated]
		private sealed class _WaitForCloudAnimationComplete_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForCloudAnimationComplete_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _MapIconOff_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterPage __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapIconOff_d__34(int __1__state);
	
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
			public QuestSelectChapterPage __4__this;
			public QuestMainGroupElement beforeNum;
			public QuestMainGroupElement topNum;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _OnChangeTopChapterElement_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public QuestSelectChapterPage __4__this;
			public QuestMainGroupElement topNum;
			public QuestMainGroupElement beforeNum;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _DelayChangeMap_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayChangeMap_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterPage __4__this;
			public QuestMainGroupElement topNum;
			public QuestMainGroupElement beforeNum;
			private __c__DisplayClass37_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayChangeMap_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public QuestSelectChapterPage __4__this;
			public QuestMainGroupElement afterData;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _OnClickDifficulty_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__40_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnClickDifficulty_b__40_0();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeWorldMapEffectCorutine_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeWorldMapEffectCorutine_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetActiveDragonCorutine_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterPage __4__this;
			public bool enable;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetActiveDragonCorutine_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public QuestSelectChapterPage __4__this;
			public Action action;
			public string str;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _PlayDragonFlash_b__0();
			internal void _PlayDragonFlash_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _DelayMethod_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int delayCount;
			public Action callback;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayMethod_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectChapterPage();
	
		// Methods
		private void Start();
		protected override void OnDestroy();
		public void Initialize();
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public void FitSize(float width);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		private void OnDragonAnimationEnd();
		public bool IsDragonAnimation();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		[IteratorStateMachine]
		private IEnumerator WaitForCloudAnimationComplete();
		public void UIOff();
		[IteratorStateMachine]
		private IEnumerator MapIconOff(int index);
		private void Update();
		public void OnChangeTopChapterElement(QuestMainGroupElement beforeNum, QuestMainGroupElement topNum);
		[IteratorStateMachine]
		private IEnumerator DelayChangeMap(QuestMainGroupElement beforeNum, QuestMainGroupElement topNum);
		public int GetChengeWorldMapId(QuestMainGroupElement beforeMaster, QuestMainGroupElement afterMaster);
		private bool IsChageWorldMap(QuestMainGroupElement beforeQmge);
		public void OnClickDifficulty();
		public void OnReleasePopupColosed();
		public List<QSChapterElement> GetChapterList();
		public void SetRotationByChapter(int topChapter, bool isPlaySound = true);
		public int GetLastSelectedChapterNumber();
		public void DisplayAchievementLevel();
		public void WheelEnable(bool enable);
		public QuestSelectWheelElement GetTopElement();
		public QuestSelectWheel GetWheel();
		public void PlayWorldMapWheelAnim();
		public void StartWorldMapWheelEnterAnimation();
		public void StartWorldMapWheelExitAnimation();
		public void OnClickMainQuestChapter(int a_chapterNumber, QuestSelectWheelElement a_qswheel);
		public void CanvasActive(bool enable);
		public void OnClickMapIcon();
		public void OpenChapterTitle();
		public void CloseOpenChapterTitle();
		public void SetFlashNewChapterAll();
		private void NewChapterZoomOut();
		private void NewCahpterChangeIcon();
		private void NewChapterUI();
		private void NewChapterFinish();
		private void FlashSetUpNewChapter();
		private void FlashSetCallback(Action action, string label, FlMotionActionTypes type);
		private void FlashPlayNewChapter();
		private Sequence MapMove();
		private Sequence ZoomIn();
		private Sequence ChangeWorldMapEffect();
		[IteratorStateMachine]
		private IEnumerator ChangeWorldMapEffectCorutine();
		private Sequence ZoomOut();
		private void SetPositionZ(Canvas canvas, GameObject target);
		public void CreateDragon();
		public void SetActiveDragon(bool enable);
		[IteratorStateMachine]
		private IEnumerator SetActiveDragonCorutine(bool enable);
		public void PlayDragonFlash(string str, int delayCount = 0, Action action = null);
		[IteratorStateMachine]
		private IEnumerator DelayMethod(Action callback, int delayCount);
		[CompilerGenerated]
		private void _StartExitAnimation_b__28_0();
		[CompilerGenerated]
		private void _StartExitAnimation_b__28_1();
		[CompilerGenerated]
		private bool _WaitForCloudAnimationComplete_b__32_0();
		[CompilerGenerated]
		private bool _WaitForCloudAnimationComplete_b__32_1();
		[CompilerGenerated]
		private bool _WaitForCloudAnimationComplete_b__32_2();
		[CompilerGenerated]
		private bool _WaitForCloudAnimationComplete_b__32_3();
		[CompilerGenerated]
		private bool _MapIconOff_b__34_0();
		[CompilerGenerated]
		private void _SetFlashNewChapterAll_b__57_0();
		[CompilerGenerated]
		private void _ChangeWorldMapEffect_b__67_0();
		[CompilerGenerated]
		private void _ChangeWorldMapEffect_b__67_1();
		[CompilerGenerated]
		private void _CreateDragon_b__71_0(int index);
		[CompilerGenerated]
		private bool _SetActiveDragonCorutine_b__73_0();
	}
}

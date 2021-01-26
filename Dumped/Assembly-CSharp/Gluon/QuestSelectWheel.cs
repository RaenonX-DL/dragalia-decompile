/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectWheel : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Canvas selfCanvas;
		[SerializeField]
		private GameObject orgWheelElement;
		[SerializeField]
		public Button chapterWheelOverAllButton;
		[SerializeField]
		public Button uiChapterLeftButton;
		[SerializeField]
		public Button uiChapterRightButton;
		[SerializeField]
		public UnityEngine.UI.Text uiChapterNumberText;
		[SerializeField]
		public UnityEngine.UI.Text uiChapterTitleText;
		[SerializeField]
		private GameObject wheel;
		[SerializeField]
		private Image lightImage;
		[SerializeField]
		private Image uiChapterTitlelineImage;
		[SerializeField]
		private Image uiChapterTitleBgImage;
		[SerializeField]
		public GameObject chapterTitleRoot;
		[SerializeField]
		private Image uiBgLayer;
		[SerializeField]
		private CanvasGroup uiArrowCanvasGroup;
		[CompilerGenerated]
		private QuestSelectScene _sceneObj_k__BackingField;
		private List<QSChapterElement> chapterList;
		private RectTransform canvasRect;
		private bool touchInCanvas;
		private bool touchFlick;
		private bool touchDrag;
		private bool touchSwipe;
		private QuestSelectWheelElement[] chapterArray;
		private QuestSelectWheelElement[] chapterArrayOrg;
		private int chapterNum;
		private List<QuestMainGroupElement> questGroupList;
		private int maxChapter;
		[SerializeField]
		private float elementsScele;
		[SerializeField]
		private float chapterRot1;
		private const float wheelScale = 0.9f;
		private float rot;
		[Header]
		[SerializeField]
		private float rotSpeedFirstConst;
		[Header]
		[SerializeField]
		private float miniFirstSpeed;
		[Header]
		[SerializeField]
		private float swipeSpeed;
		[Header]
		[SerializeField]
		private float breakSpeedOneConst;
		[Header]
		[SerializeField]
		private float breakSpeedSecondConst;
		[Header]
		[Header]
		[SerializeField]
		private float reverseSpeedConst;
		[SerializeField]
		private float breakSpeed;
		[SerializeField]
		private float rotSpeed;
		private bool initialized;
		private float beginRot;
		private float endRot;
		private float wheelWidth;
		private float firstTouchRot;
		private Vector3 firstTouchPos;
		private QuestSelectWheelElement touchTopWheelElement;
		private QuestSelectWheelElement topWheelElement;
		private QuestSelectWheelElement orgWheelElementObj;
		private int _lastSelectedChapterNumber;
		private bool isFirstTop;
		[Header]
		[SerializeField]
		private float inWorldMapElementBaseY;
		[Header]
		[SerializeField]
		private float inWorldMapElementdelay;
		private CanvasGroup myCanvasGroup;
		public UnityAction<int, QuestSelectWheelElement> onClickWheel;
		private Vector2 defaultChapterNumberPos;
		private Vector2 defaultChapterTitlePos;
		private float openMoveDistance;
		private float closeMoveDistance;
		private Vector2 lineWidth;
		private bool isPlayingChapterScrollByArrowButton;
		public bool isWheel;
		[SerializeField]
		public NewChapterActionTime newChapterDelayTime;
		public float jump;
		public float bounce;
		public float jumpTime;
		public float frameTime;
		public float bounceTime;
	
		// Properties
		public QuestSelectScene sceneObj { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float ElementsScale { get; }
		public int lastSelectedChapterNumber { get; }
	
		// Nested types
		private class PosElement : IComparable<PosElement>
		{
			// Fields
			[CompilerGenerated]
			private Vector3 _pos_k__BackingField;
			[CompilerGenerated]
			private int _index_k__BackingField;
			[CompilerGenerated]
			private QuestSelectWheelElement.WheelChapterSize _chapterSize_k__BackingField;
	
			// Properties
			public Vector3 pos { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; }
			public QuestSelectWheelElement.WheelChapterSize chapterSize { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public PosElement(Vector3 a_pos, int a_index);
	
			// Methods
			public int CompareTo(PosElement a_posElement);
		}
	
		[Serializable]
		public class NewChapterActionTime
		{
			// Fields
			public float dropCellDelayTime;
			public float titleDelayTime;
			public float bgDelayTime;
			public float otherCellDelayTime;
			public float endDelayTime;
	
			// Constructors
			public NewChapterActionTime();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0
		{
			// Fields
			public int index;
			public QuestSelectWheelElement chapter;
	
			// Constructors
			public __c__DisplayClass71_0();
	
			// Methods
			internal void _Initialize_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class _InitializeWheelElements_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectWheel __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitializeWheelElements_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestMainGroupElement> __9__73_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _InitializeQuestGroupList_b__73_0(QuestMainGroupElement a, QuestMainGroupElement b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public Sequence mainSequence;
			public QuestSelectWheel __4__this;
			public Vector3[] tempPos;
			public Vector3[] tempSca;
			public List<CanvasGroup> canvasGroupList;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _PlayAreaMapWheelAnim_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public QuestSelectWheel __4__this;
			public int topChapter;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _PlayNewChapterWheelAnimationTop_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_1
		{
			// Fields
			public Transform rect;
	
			// Constructors
			public __c__DisplayClass83_1();
	
			// Methods
			internal void _PlayNewChapterWheelAnimationTop_b__0();
			internal void _PlayNewChapterWheelAnimationTop_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public QuestSelectWheel __4__this;
			public Sequence mainSequence;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal void _PlayNewChapterWheelAnimation_b__1();
			internal void _PlayNewChapterWheelAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public QuestSelectWheel __4__this;
			public Sequence mainSequence;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _PlayWorldMapWheelAnim_b__1();
			internal void _PlayWorldMapWheelAnim_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0
		{
			// Fields
			public QuestSelectWheel __4__this;
			public Sequence mainSequence;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal void _ExitWorldMapWheelAnim_b__3();
			internal void _ExitWorldMapWheelAnim_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_1
		{
			// Fields
			public Transform rect;
			public QuestSelectWheelElement chapterElement;
	
			// Constructors
			public __c__DisplayClass86_1();
	
			// Methods
			internal void _ExitWorldMapWheelAnim_b__1();
			internal void _ExitWorldMapWheelAnim_b__2(float alpha);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0
		{
			// Fields
			public QuestSelectWheel __4__this;
			public RectTransform lineTrans;
	
			// Constructors
			public __c__DisplayClass90_0();
	
			// Methods
			internal Color _AnimChapterTitle_b__1();
			internal void _AnimChapterTitle_b__2(Color color);
			internal void _AnimChapterTitle_b__3();
			internal void _AnimChapterTitle_b__4();
			internal void _AnimChapterTitle_b__5();
			internal Vector2 _AnimChapterTitle_b__6();
			internal void _AnimChapterTitle_b__7(Vector2 x);
			internal void _AnimChapterTitle_b__8();
			internal void _AnimChapterTitle_b__9();
			internal void _AnimChapterTitle_b__0(float alpha);
			internal Color _AnimChapterTitle_b__11();
			internal void _AnimChapterTitle_b__12(Color color);
			internal void _AnimChapterTitle_b__13();
			internal void _AnimChapterTitle_b__14();
			internal void _AnimChapterTitle_b__15();
			internal Vector2 _AnimChapterTitle_b__16();
			internal void _AnimChapterTitle_b__17(Vector2 x);
			internal void _AnimChapterTitle_b__18();
			internal void _AnimChapterTitle_b__10(float alpha);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public Transform LightImage;
			public Vector2 defaultLightPos;
			public Vector2 defaultLightScale;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _NewChapterLightFunction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass92_1();
	
			// Methods
			internal float _NewChapterLightFunction_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass92_2();
	
			// Methods
			internal float _NewChapterLightFunction_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_3
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass92_3();
	
			// Methods
			internal float _NewChapterLightFunction_b__3(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal float _NewChapterNumberTextFunction_b__0(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass94_1();
	
			// Methods
			internal float _NewChapterNumberTextFunction_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass94_2();
	
			// Methods
			internal float _NewChapterNumberTextFunction_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal float _NewChapterTitleTextFunction_b__0(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_1
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass95_1();
	
			// Methods
			internal float _NewChapterTitleTextFunction_b__1(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_2
		{
			// Fields
			public TweenItemVisualizer.CustomEaseInfo easeInfo;
	
			// Constructors
			public __c__DisplayClass95_2();
	
			// Methods
			internal float _NewChapterTitleTextFunction_b__2(float time, float duration, float overshootOrAmplitude, float period);
		}
	
		// Constructors
		public QuestSelectWheel();
	
		// Methods
		private void Clear();
		public void Initialize();
		[IteratorStateMachine]
		public IEnumerator InitializeWheelElements();
		private void InitializeQuestGroupList();
		private void Update();
		private void OnApplicationPause(bool pauseStatus);
		public void OnClickMainQuestChapter(QuestSelectWheelChapter clickedChapter);
		public void PlayAreaMapWheelAnim(UnityAction action = null);
		public void PlayNewChapterWheelAnimationTop();
		public void PlayNewChapterWheelAnimation(UnityAction action = null);
		public void PlayWorldMapWheelAnim(UnityAction action = null);
		public void ExitWorldMapWheelAnim(UnityAction action = null);
		private void SetTextAlpha(float alpha);
		public void OpenChapterTitle();
		public void CloseChapterTitle();
		private void AnimChapterTitle(bool isBackwards);
		public Sequence NewAnimChapterTitle();
		private Sequence NewChapterLightFunction();
		private Sequence NewChapterLineFunction();
		private Sequence NewChapterNumberTextFunction();
		private Sequence NewChapterTitleTextFunction();
		public void SetChapterList(List<QSChapterElement> a_chapterList);
		public int CheckMaxChapter();
		public void SetRotationByChapter(int topChapter, bool isPlaySound = true);
		private void SetRotation(float rot, bool isPlaySound = true);
		public void UpdateAllAchievementLevels();
		public void DisplayChapterNumberAndTitle();
		public void DisplayChapterNumberAndTitleFromMaster(QuestMainGroupElement qmge);
		public QuestSelectWheelElement GetTopChapterElement();
		private Vector3 GetNowPoint();
		public void OnClickChapterLeft();
		public void OnClickChapterRight();
		public void LeftRightArrowsEnable(bool enable);
		public Tweener LeftRightArrowFadeIn(float endValue, float duration);
		public void OnClickDifficulty();
		private bool IsDown();
		private bool IsFlickLeft();
		private bool IsFlickRight();
		private bool IsUp();
		private bool IsDrag();
		private bool IsPress();
		private bool IsTouchGuard();
		public void StartEnterAnimation();
		public void StartExitAnimation();
		public void NewChapterAnimation();
		public void NewChapterrAnimationTop();
		public void CanvasEnable(float alpha);
		public void SetBgLayerWidth(float width);
		[CompilerGenerated]
		private void _NewAnimChapterTitle_b__91_0();
		[CompilerGenerated]
		private void _NewChapterLineFunction_b__93_0();
		[CompilerGenerated]
		private void _NewChapterLineFunction_b__93_2(float width);
		[CompilerGenerated]
		private void _NewChapterLineFunction_b__93_1();
	}
}

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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectChapterMap : AnimationUIObject
	{
		// Fields
		public QuestSelectScene questSelectScene;
		[SerializeField]
		public Canvas selfCanvas;
		[SerializeField]
		public Image uiWorldMap;
		[SerializeField]
		private float worldmapScrollOffsetY;
		[SerializeField]
		private QuestCloudController worldMapCloudCtrl;
		private Tweener worldMapMoveTweener;
		private readonly Vector2 mapSize;
		private const float adjustCloudSpeed = 0.5f;
		[SerializeField]
		private float worldIconMoveTime;
		private Material worldMapMaterial;
		private int worldMapId;
		private CanvasGroup worldMapCanvasGroup;
		private Tweener mapChangeFadeTweener;
		[Header]
		[SerializeField]
		private Vector2 mapChangeDurationSec;
		private QuestChapterIconPos[] chapterMapIconArray;
		[SerializeField]
		private float mapOffset;
		[SerializeField]
		private float iPhoneXMapOffset;
		[SerializeField]
		private AnimationUIBase mapAnimation;
		[CompilerGenerated]
		private bool _IsMapIconInitDone_k__BackingField;
		[CompilerGenerated]
		private bool _IsInitDone_k__BackingField;
	
		// Properties
		public float worldMoveTime { get; }
		public bool IsMapIconInitDone { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsInitDone { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		public class ChapterIconPos
		{
			// Fields
			[SerializeField]
			private Image _iconImage1;
			[SerializeField]
			private Image _iconImage2;
			[CompilerGenerated]
			private Vector2 _iconPos1_k__BackingField;
			[CompilerGenerated]
			private Vector2 _iconPos2_k__BackingField;
			private bool initFlag;
			[SerializeField]
			private Button _button;
	
			// Properties
			public Image iconImage1 { get; set; }
			public Vector2 iconPos1 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Image iconImage2 { get; set; }
			public Vector2 iconPos2 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Button button { get; set; }
	
			// Constructors
			public ChapterIconPos();
	
			// Methods
			public void Initialize(int index);
			[CompilerGenerated]
			private void _Initialize_b__21_0(Material iconMaterial);
		}
	
		[CompilerGenerated]
		private sealed class _InitializeWorldMapMaterial_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterMap __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitializeWorldMapMaterial_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _InitializeCoroutine_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectChapterMap __4__this;
			public QuestSelectWheelElement topChapterElement;
			public int lastSelectedChapterNumber;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitializeCoroutine_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public QuestSelectChapterMap __4__this;
			public int topNum;
			public int beforeNum;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _OnUpdate_b__0();
			internal void _OnUpdate_b__1();
			internal void _OnUpdate_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public Color worldMapColor;
			public QuestSelectChapterMap __4__this;
			public float toAlpha;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _FadeWorldMap_b__0(float alpha);
			internal void _FadeWorldMap_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public QuestSelectChapterMap __4__this;
			public QuestSelectWheelElement topChapterElement;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _SetChapterIconButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public int lastSelectedChapterNumber;
			public QuestSelectChapterMap __4__this;
			public Action<int> __9__0;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _InitchapterMapIconArray_b__0(int index);
		}
	
		// Constructors
		public QuestSelectChapterMap();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator InitializeWorldMapMaterial();
		public void ChangeWorldMap(int mapId);
		private void InitializeMapIcon();
		private void DestroyChapter();
		private void WorldMapCheck();
		public void Initialize(int lastSelectedChapterNumber, QuestSelectWheelElement topChapterElement);
		[IteratorStateMachine]
		private IEnumerator InitializeCoroutine(int lastSelectedChapterNumber, QuestSelectWheelElement topChapterElement);
		public void OnUpdate(QuestSelectWheelElement topChapterElement, int topNum, int beforeNum, Action onComplete);
		public void EnableChapterMapIconArray(int topNum, bool flag);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public void FadeWorldMap(float fromAlpha, float toAlpha);
		public void GetChapterIconPivotAndLocalPos(int chapterNumber, out Vector2 chapterPivot, out Vector3 chapterTargetLocalPos);
		public void DisplayChapterIcon();
		public Tweener NewChapterTweenMove(int newChapter, float during);
		public Tweener NewChapterTweenScale(float endValue, float time);
		public void CloudFadeOut(int topNum);
		private void SetChapterIconAlpha(int chapterIndex, float alphaValue);
		public void SetChapterIconButton(QuestSelectWheelElement topChapterElement);
		public void InitchapterMapIconArray(int lastSelectedChapterNumber);
		public void AllChapterIconButtonInteractable(bool enable);
		public QuestChapterIconPos[] GetChapterIcon();
		private Vector3 ConvertLocalPositionByPivot(RectTransform rectTrans, Vector2 newPivot);
		[CompilerGenerated]
		private bool _InitializeCoroutine_b__36_0();
	}
}

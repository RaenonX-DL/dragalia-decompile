/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class STGUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image topFade;
		[Header]
		[SerializeField]
		public Transform uiScrollTarget;
		public DragEventScrollRect dragEventScrollRect;
		[Header]
		[SerializeField]
		public RectTransform gameRect;
		[NonSerialized]
		public Canvas canvas;
		[Header]
		[SerializeField]
		public Image[] lifeHearts;
		public UnityEngine.UI.Text shootLevelText;
		public Color initFadeColor;
		[Header]
		[SerializeField]
		public GameObject hiScoreMark;
		[Header]
		[SerializeField]
		public Button pauseButton;
		public STGPausePU pausePU;
		[Header]
		[SerializeField]
		public Sprite[] numbers;
		public Image[] digits;
		[Header]
		[SerializeField]
		public GameObject levelUpGO;
		public CanvasGroup levelUpCanvasGroup;
		[Header]
		[SerializeField]
		public GameObject bossAppearGO;
		public UnityEngine.UI.Text dragonName;
		public UnityEngine.UI.Text dragonLevel;
		public GameObject[] trueMidHideGOs;
		public Animator bossAppearAnimator;
		[Header]
		[SerializeField]
		public GameObject dropHeartHeart;
		public CanvasGroup dropHeartCanvasGroup;
		[Header]
		[SerializeField]
		public UIAnimationPublisher enterPublisher;
		[Header]
		[SerializeField]
		public GameObject gaugeGO;
		public GameObject gaugeIndicator;
		public CommonSlider slider;
		[Header]
		[SerializeField]
		public GameObject bombGO;
		public CanvasGroup bombCanvasGroup;
		public Button bombButton;
		public GameObject logoGO;
		public CanvasGroup logoCanvasGroup;
		public GameObject[] marker;
		public CanvasGroup[] markerCanvasGroup;
		private bool isInBombAnimation;
		[NonSerialized]
		public bool isInPause;
		private int[] bossDisplayLevel;
		private int[] bossIds;
		private float savedTimeScale;
		private Coroutine waitBossAppearCoroutine;
		private List<Sequence> runningSequences;
		private Vector2 curInputPos;
		private int displayLevel;
		private Enemy watchEnemy;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _EnableBomb_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _OnBombButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _ShowSlider_b__0(float x);
			internal void _ShowSlider_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBossAppearDone_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public STGUI __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBossAppearDone_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public STGUI __4__this;
			public int index;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _ShowMarker_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _ShowLogo_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _CloseSlider_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal void _PlayDropLife_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public STGUI __4__this;
			public Sequence seq;
			public TweenCallback __9__2;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _ShowLevelUp_b__0();
			internal void _ShowLevelUp_b__1();
			internal void _ShowLevelUp_b__2();
		}
	
		// Constructors
		public STGUI();
	
		// Methods
		private void Awake();
		private void Start();
		public void DoInitFadeIn();
		public void BlackOut(float boTime);
		public void Restart(bool fromMenu = false);
		public void UpdateInputPos();
		public Vector3 GetInputPos();
		public bool IsAnyFingerPressed();
		public void ShowIndi();
		private void SetBackKey(UnityAction action);
		private void SetBackKeyAsEvent(UnityEvent backKeyEvent);
		public void EnableBomb();
		public void OnBombButton();
		public void ShowSlider(float bossHp, float expandTime, float slideTime);
		public void ShowBossInfo(float bossHp, int level);
		private void ShowBossAppear();
		[IteratorStateMachine]
		private IEnumerator WaitBossAppearDone();
		public void UpdateScore(int score);
		public void UpdateWatch();
		public void ShowMarker(int index);
		public void ShowLogo();
		public void CloseSlider();
		public void UpdateBossGauge(float bossHp, float maxHp);
		public void SetLifeVal(int life, int recoverCount);
		public void PlayDropLife(int pos);
		public void ShowLevelUp();
		public void SetShootLevel(int level);
		private void Update();
		public void OnPause();
		protected void OnApplicationPause(bool pause);
		private void CreatePause();
		public void SetSliderWatch(Enemy enemy);
		public void QuitShooting();
		public void CreateGameOverFlow();
		[CompilerGenerated]
		private void _Restart_b__44_0();
		[CompilerGenerated]
		private void _CreatePause_b__72_0();
		[CompilerGenerated]
		private void _CreatePause_b__72_1();
		[CompilerGenerated]
		private void _CreatePause_b__72_2();
		[CompilerGenerated]
		private void _CreateGameOverFlow_b__76_0();
		[CompilerGenerated]
		private void _CreateGameOverFlow_b__76_1();
		[CompilerGenerated]
		private void _CreateGameOverFlow_b__76_2();
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QSAreaLandmarkElement : QSTableTopViewCell
	{
		// Fields
		public bool isQuestReturn;
		public bool isNextFlag;
		[SerializeField]
		private GameObject _questStateIconParent;
		[SerializeField]
		private Vector3 questStateIconLocalPosOffset;
		[SerializeField]
		private GameObject landMarkNameRoot;
		[SerializeField]
		private GameObject _nextQuestIcon;
		public GameObject uiTreasure;
		[SerializeField]
		private Canvas uiCanvas;
		[SerializeField]
		private QuestSelectLandmarkDot landMarkFlash;
		[SerializeField]
		private float nextFirstPosYDuration;
		[SerializeField]
		private float nextFirstPosY;
		[SerializeField]
		private float nextLoopMoveDelay;
		[SerializeField]
		private float balloonStartDelay;
		[SerializeField]
		private float balloonLoopMoveDelay;
		[SerializeField]
		private RectTransform tapButton;
		[SerializeField]
		private float[] landmarkSizeScaleY;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private GameObject balloonObject;
		[SerializeField]
		private Image sphereImage;
		[SerializeField]
		private UnityEngine.UI.Text sphereCountText;
		[SerializeField]
		private UnityEngine.UI.Text sphereZeroText;
		[CompilerGenerated]
		private float _nextLoopMoveDuration_k__BackingField;
		[CompilerGenerated]
		private float _balloonLoopMoveDuration_k__BackingField;
		private int flashSortOrder;
		private QuestSelectScene sceneObj;
		private GameObject questStateIconObj;
		private bool _isTreasureBox;
		private bool isTreasureBoxOpend;
		private QuestTreasureBoxRewardPopup treasureBoxRewardPopup;
		private QuestUtil.QuestState _curQuestState;
		private int index;
		private UiTextColorExchanger landmarkNameColorExchanger;
		private FlashPlayer treasureBoxFlashPlayer;
		private Sequence _myseqLoop;
		private Sequence _myseqBallonLoop;
		private bool _isFirstTresure;
		private const int nextOffsetPos = -20;
		private const int balloonOffsetPos = -20;
		private const float closeUiFrame = 8f;
		private const float openUiFrame = 1f;
	
		// Properties
		public bool isTreasureBox { get; private set; }
		public bool isFirstTreasure { get; }
		public QuestUtil.QuestState curQuestState { get; private set; }
		public GameObject questStateIconParent { get; }
		public GameObject nextQuestIcon { get; }
		public float nextLoopMoveDuration { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float balloonLoopMoveDuration { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum LandmarkSize
		{
			None = 0,
			Small = 1,
			Normal = 2,
			Num = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public QSAreaLandmarkElement __4__this;
			public int chapterNumber;
			public QuestSelectScene.Difficulty difficulty;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _OnTreasureRequestSuccess_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _OnTreasureRequestError_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public QSAreaLandmarkElement __4__this;
			public RectTransform nextRect;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _NextAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public QSAreaLandmarkElement __4__this;
			public RectTransform balloonRect;
			public TweenCallback __9__1;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _WaitBalloonAnimation_b__0();
			internal void _WaitBalloonAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBalloonAnimation_d__80 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QSAreaLandmarkElement __4__this;
			private __c__DisplayClass80_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBalloonAnimation_d__80(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QSAreaLandmarkElement();
	
		// Methods
		public void Initialize(QuestSelectScene a_sceneObj, int routeGroupNumber, int routeIndex, int arrayIndex, int sortOrder = 10);
		public void InitTreasureBoxFlashPlayer(bool isFirst);
		private void OnDestroy();
		private void OnTreasureRequestSuccess(QuestOpenTreasureResponse res);
		private void OnTreasureRequestError(ErrorType type, int errorCode);
		public void RequestTreasureOpen();
		public void TresureActive();
		public override void OnClick();
		public void OnTreasureRewardPopupClosed();
		public void OnOpenQuestListPopup();
		public void OnClickQuestListPopupCancel();
		private void OnClickBackButton();
		public void SetNextQuestIcon(bool enable);
		public void NextAnimation();
		public QuestSelectLandmarkDot GetLandmarkDot();
		private void SetTapButtonSize();
		public int LanrmrkCanvasSortOrder();
		public void CloseLandMark();
		public void OpenLandMark();
		public void SetBalloonData(List<QuestMainMenuElement> elementList, QuestSelectScene.Difficulty difficulty);
		public void BalloonAnimation();
		[IteratorStateMachine]
		private IEnumerator WaitBalloonAnimation();
		[CompilerGenerated]
		private void _InitTreasureBoxFlashPlayer_b__60_0(int index);
	}
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QSAreaLandmarkElement : QSTableTopViewCell
	{
		public enum LandmarkSize
		{
			None,
			Small,
			Normal,
			Num
		}

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
		private Text sphereCountText;

		[SerializeField]
		private Text sphereZeroText;

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

		public bool isTreasureBox
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public bool isFirstTreasure => default(bool);

		public QuestUtil.QuestState curQuestState
		{
			get
			{
				return default(QuestUtil.QuestState);
			}
			private set
			{
			}
		}

		public GameObject questStateIconParent => null;

		public GameObject nextQuestIcon => null;

		public float nextLoopMoveDuration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float balloonLoopMoveDuration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(QuestSelectScene a_sceneObj, int routeGroupNumber, int routeIndex, int arrayIndex, int sortOrder = 10)
		{
		}

		public void InitTreasureBoxFlashPlayer(bool isFirst)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTreasureRequestSuccess(QuestOpenTreasureResponse res)
		{
		}

		private void OnTreasureRequestError(ErrorType type, int errorCode)
		{
		}

		public void RequestTreasureOpen()
		{
		}

		public void TresureActive()
		{
		}

		public override void OnClick()
		{
		}

		public void OnTreasureRewardPopupClosed()
		{
		}

		public void OnOpenQuestListPopup()
		{
		}

		public void OnClickQuestListPopupCancel()
		{
		}

		private void OnClickBackButton()
		{
		}

		public void SetNextQuestIcon(bool enable)
		{
		}

		public void NextAnimation()
		{
		}

		public QuestSelectLandmarkDot GetLandmarkDot()
		{
			return null;
		}

		private void SetTapButtonSize()
		{
		}

		public int LanrmrkCanvasSortOrder()
		{
			return default(int);
		}

		public void CloseLandMark()
		{
		}

		public void OpenLandMark()
		{
		}

		public void SetBalloonData(List<QuestMainMenuElement> elementList, QuestSelectScene.Difficulty difficulty)
		{
		}

		public void BalloonAnimation()
		{
		}

		private IEnumerator WaitBalloonAnimation()
		{
			return null;
		}
	}
}

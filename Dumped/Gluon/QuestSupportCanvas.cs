using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestSupportCanvas : MonoBehaviour
	{
		public enum PlayType
		{
			singlePlay,
			muiltiPlay,
			both
		}

		public QuestSupportListBase questSupportListBase;

		public QuestSupportListController questSupportListController;

		public UnityAction cellButtonCallBack;

		public UnityAction backButtonCallBack;

		[SerializeField]
		private GameObject sliderObjRoot;

		[SerializeField]
		private GameObject multiButtonObjRoot;

		[SerializeField]
		[Header("â\u0080»ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0083\u0090ã\u0083¼ã\u0080\u0081ã\u0082½ã\u0083¼ã\u0083\u0088ã\u0080\u0081ã\u0083\u009eã\u0083«ã\u0083\u0081ã\u0081®é\u00a0\u0086")]
		private Vector3 openDelayTime;

		[SerializeField]
		private GameObject blackLayerObj;

		[SerializeField]
		private GameObject touchGuardObj;

		private SceneUICanvas _sceneUiCanvas;

		private QuestElementFilter elementFilter;

		[SerializeField]
		private MultiPlaySelector multiPlay;

		[SerializeField]
		private TabBase tab;

		public PlayType playType;

		[SerializeField]
		private GameObject[] playTypeObject;

		[SerializeField]
		private AnimationListOneCol listMultiAnim;

		private float eachCellOpenWaitTime;

		[SerializeField]
		private RectTransform questSupportListArea;

		private Vector2 questSupportListOffsetMaxDefault;

		private Vector2 questSupportListOffsetMaxNonTab;

		private GameObject multiLockObj;

		private const string defaultQuestTabPrefsNameTemplate = "QuestSupportCanvasDefaultTab_{0}";

		private Action onFirstOpenSupportPage;

		private int questId;

		public QuestSupportPage supportPage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SceneUICanvas sceneUiCanvas
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OpenDefaultTab(int questId, Action onFirstOpenSupportPage)
		{
		}

		public static int GetCurrentTab(int questGroupId)
		{
			return default(int);
		}

		public static PlayType GetPlayType(int questGroupId)
		{
			return default(PlayType);
		}

		public static void SetCurrentTab(int questGroupId, int num)
		{
		}

		public void CheckConstraint(int questId)
		{
		}

		public void InitFortEnteringAnim(int questId)
		{
		}

		public void LoadSupportUserList()
		{
		}

		private void PlayTabSelectedAnimation()
		{
		}

		private void UpdateSupportList()
		{
		}

		public void ChangeFilterElement()
		{
		}

		public void OnSelectedSoloplay(bool shouldOpenSupportList)
		{
		}

		public void OnSelectedMultiplay()
		{
		}

		private void CellButtonPressed(QuestSupportListCellData selectData)
		{
		}

		public void OnSelectedTab(int num)
		{
		}

		public void OnSelectOnlyTab(int num)
		{
		}

		public void CloseButtonPressed()
		{
		}

		public void OnOpen()
		{
		}

		private void SetMultiLock(bool isLock)
		{
		}

		public void OnClose()
		{
		}

		private void StartObjFadeAnim(GameObject obj, Ease easing, float startAlpha, float endAlpha, float duration, float delayTime)
		{
		}

		private void StartObjMoveYAnim(GameObject obj, Ease easing, float startRelativeY, float endRelativeY, float duration, float delayTime)
		{
		}

		public QuestCellData GetCurrentQuestCellData()
		{
			return null;
		}

		public void ShowSearchRoomPopup()
		{
		}
	}
}

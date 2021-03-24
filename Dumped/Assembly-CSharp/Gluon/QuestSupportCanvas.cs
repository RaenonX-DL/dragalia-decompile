/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSupportCanvas : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private QuestSupportPage _supportPage_k__BackingField;
		public QuestSupportListBase questSupportListBase;
		public QuestSupportListController questSupportListController;
		public UnityAction cellButtonCallBack;
		public UnityAction backButtonCallBack;
		[SerializeField]
		private GameObject sliderObjRoot;
		[SerializeField]
		private GameObject multiButtonObjRoot;
		[Header]
		[SerializeField]
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
	
		// Properties
		public QuestSupportPage supportPage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SceneUICanvas sceneUiCanvas { get; private set; }
	
		// Nested types
		public enum PlayType
		{
			singlePlay = 0,
			muiltiPlay = 1,
			both = 2
		}
	
		// Constructors
		public QuestSupportCanvas();
	
		// Methods
		private void Awake();
		private void Start();
		public void OpenDefaultTab(int questId, Action onFirstOpenSupportPage);
		public static int GetCurrentTab(int questGroupId);
		public static PlayType GetPlayType(int questGroupId);
		public static void SetCurrentTab(int questGroupId, int num);
		public void CheckConstraint(int questId);
		public void InitFortEnteringAnim(int questId);
		public void LoadSupportUserList();
		private void PlayTabSelectedAnimation();
		private void UpdateSupportList();
		public void ChangeFilterElement();
		public void OnSelectedSoloplay(bool shouldOpenSupportList);
		public void OnSelectedMultiplay();
		private void CellButtonPressed(QuestSupportListCellData selectData);
		public void OnSelectedTab(int num);
		public void OnSelectOnlyTab(int num);
		public void CloseButtonPressed();
		public void OnOpen();
		private void SetMultiLock(bool isLock);
		public void OnClose();
		private void StartObjFadeAnim(GameObject obj, Ease easing, float startAlpha, float endAlpha, float duration, float delayTime);
		private void StartObjMoveYAnim(GameObject obj, Ease easing, float startRelativeY, float endRelativeY, float duration, float delayTime);
		public QuestCellData GetCurrentQuestCellData();
	}
}

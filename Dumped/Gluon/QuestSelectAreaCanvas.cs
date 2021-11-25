using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectAreaCanvas : AnimationUIObject
	{
		[HideInInspector]
		public QuestSelectScene sceneObj;

		public UnityAction onClickEventButton;

		[SerializeField]
		public Canvas selfCanvas;

		[SerializeField]
		public GameObject uiAreaMapRoot;

		[SerializeField]
		public Image uiAreaMapImage;

		[SerializeField]
		private int uiAreaMapKeepCountMax;

		[SerializeField]
		public GameObject uiLineDotRoot;

		[SerializeField]
		public GameObject uiLandmarkRoot;

		[SerializeField]
		private GameObject dragCenterObj;

		[SerializeField]
		public Transform areaMapTargetForDisp;

		[SerializeField]
		private Vector2 namPos;

		[SerializeField]
		private Vector2 namScale;

		[SerializeField]
		[Header("ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081®æ\u008b¡å¤§ç\u008e\u0087")]
		private float mapScale;

		[SerializeField]
		private int[] cloudNg;

		[SerializeField]
		private Vector3 landmarkFlashArrangeOffset;

		[SerializeField]
		private AnimationUIBase _animationUiBase;

		[SerializeField]
		private QuestStoryClearReward storyClearReward;

		[SerializeField]
		private RectTransform mapRectTransform;

		[SerializeField]
		private QSLandMarkController qSLandmarkController;

		[SerializeField]
		private GameObject pinchScaleRoot;

		[SerializeField]
		[Header("ã\u0083\u0094ã\u0083³ã\u0083\u0081æ\u0099\u0082ã\u0081®æ\u008b¡ç\u00b8®é\u0080\u009fåº¦ä¿\u0082æ\u0095°")]
		private float pinchMapScalingModulus;

		[SerializeField]
		[Header("ã\u0083\u0094ã\u0083³ã\u0083\u0081æ\u0099\u0082ã\u0081®æ\u008b¡ç\u00b8®ç\u00af\u0084å\u009b²(æ\u009c\u0080å°\u008f,æ\u009c\u0080å¤§)")]
		private Vector2 pinchMapScalingRange;

		[SerializeField]
		[Header("ã\u0083\u0094ã\u0083³ã\u0083\u0081æ\u0099\u0082ã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å\u0088\u009dæ\u009c\u009få\u0080¤")]
		private float pinchMapScalingDefault;

		[SerializeField]
		[Header("æ\u008b¡ç\u00b8®ç\u00af\u0084å\u009b²é\u0099\u0090åº¦ã\u0081§ã\u0081®Elasticä¿\u0082æ\u0095°")]
		private float pinchMapScalingLimitRangeElasticModulus;

		[SerializeField]
		private Transform _mainTrans;

		[SerializeField]
		private float newCommerTime;

		[SerializeField]
		private float newLandmarkDirectionDelayTime;

		[SerializeField]
		private float newLandmarkIconAnimationDelayTime;

		[SerializeField]
		private float newTreasureBoxIconAnimationDelayTime;

		private float curMapScale;

		private bool isMultiTouch;

		private Vector2[] multiTouchPos;

		private ScrollRect mapDragScrollRect;

		private float prevMultiPointerDistance;

		private RectTransform pinchScaleRootRectTransform;

		private QuestStoryRewardPopup storyRewardPopup;

		private QuestCloudController cloudCtrl;

		private Vector2 centerDiff;

		private Vector2 scrollMin;

		private Vector2 scrollMax;

		private Vector2 dragCenterInitialSize;

		private QuestSelectNhaam questSelectNhaam;

		private QSAreaLandmarkElement[] landmarkArray;

		private RectTransform dragCenterObjRect;

		private QuestReleasePopup releasePopup;

		private RectTransform qaAreaSelectRectTrans;

		private Vector3 initialLocalPos;

		private bool isMapLocalPosPreserved;

		private Vector3 mapPrevLocalPos;

		private int lastLandmarkIndex;

		private List<int> newLandmarkIndexList;

		private List<QSChapterElement> chapterList;

		private QuestSelectLocationDetail questSelectLocationDetailOpened;

		private List<List<QuestSelectRouteDot>> questSelectRouteDotList;

		private List<Material> areaMapMaterialList;

		private const float pointScaleTime = 0.2f;

		private readonly string areaMapImagePrefix;

		private readonly Vector2 cloudAreaSize;

		private bool isInitializing;

		private bool isStartingFlyAnimation;

		public AnimationUIBase animationUiBase => null;

		public bool isTutorialPopupShown
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QSChapterElement chapterElement
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

		public Transform mainTtans => null;

		public bool IsAreaMapInitializing => default(bool);

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public IEnumerator Initialize()
		{
			return null;
		}

		private void InitTresureBox(QSAreaLandmarkElement[] landmarkArray, bool isNewTresureReleased, int lastLandmarkIndex)
		{
		}

		private void onStartArrangingRoutePoints()
		{
		}

		private void OnEndArrangingRoutePoints()
		{
		}

		private void onReadyStartArrangingRoutePoints()
		{
		}

		private void onReadyEndArrangingRoutePoints()
		{
		}

		public void LoadNewEnrollmentPage(int id, GiftType giftType, int index, Action onFinish)
		{
		}

		private IEnumerator LoadNewEnrollmentPageCorutine(int id, GiftType giftType, int index, Action onFinish)
		{
			return null;
		}

		private void OnNewEnrollmentOutAnimationStart()
		{
		}

		private void OnNewEnrollmentInAnimationEnd()
		{
		}

		private IEnumerator StartFlyAnimation()
		{
			return null;
		}

		private void StartNewLandmarkActivation()
		{
		}

		private IEnumerator NewLandmarkCoroutine(int startIndex, int goalIndex)
		{
			return null;
		}

		private int GetNextLandMarkIndex(int lastIndex)
		{
			return default(int);
		}

		private int GetMainLocationLastIndex()
		{
			return default(int);
		}

		private void CheckTransition(bool isNewLandmark)
		{
		}

		private void CreateAndroidReviewPopup()
		{
		}

		private void CreateAndroidReviewNoPopup()
		{
		}

		private void CreateAndroidReviewYesPopup()
		{
		}

		public void OnClickBack()
		{
		}

		public void OnClickDifficulty()
		{
		}

		private void CloseQuestSelectLocation()
		{
		}

		private CommonPopup CreateDuplicateConfirmPopup(string title, string text, bool isNewLandmark = false)
		{
			return null;
		}

		private void StartTutorial()
		{
		}

		private void Tutorial_Default()
		{
		}

		private void DisableUiOnTutorial()
		{
		}

		private void Tutorial_1_1()
		{
		}

		private IEnumerator Tutorial_1_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_1_Result()
		{
		}

		private IEnumerator Tutorial_1_1_Result_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_2()
		{
		}

		private void Tutorial_1_2_MaterialReceiveDone()
		{
		}

		private IEnumerator Tutorial_1_2_MaterialReceiveDone_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_4()
		{
		}

		private IEnumerator Tutorial_1_4_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_5()
		{
		}

		private IEnumerator Tutorial_1_5_Coroutine()
		{
			return null;
		}

		private void Tutorial_2_1()
		{
		}

		private IEnumerator Tutorial_2_1_Coroutine()
		{
			return null;
		}

		private void StartEditSkillTutorial()
		{
		}

		private void Tutorial_2_2()
		{
		}

		private IEnumerator Tutorial_2_2_Coroutine()
		{
			return null;
		}

		private void Tutorial_ToBackButton()
		{
		}

		private void Tutorial_ToEventTab()
		{
		}

		private void Tutorial_6_1()
		{
		}

		private IEnumerator Tutorial_6_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_ReleaseTruthDragonBattle()
		{
		}

		private IEnumerator Tutorial_ReleaseTruthDragonBattle_Coroutine()
		{
			return null;
		}

		private void Tutorial_ReleaseAgito()
		{
		}

		private IEnumerator Tutorial_ReleaseAgito_Coroutine()
		{
			return null;
		}

		private void TutorialReleaseDiabolos()
		{
		}

		private IEnumerator TutorialReleaseDiabolosCoroutine()
		{
			return null;
		}

		private void Tutorial_7_1()
		{
		}

		private IEnumerator Tutorial_7_1_Coroutine()
		{
			return null;
		}

		private IEnumerator Tutorial_7_1_ShowDualWindow_Coroutine()
		{
			return null;
		}

		private void Tutorial_9_1()
		{
		}

		private IEnumerator Tutorial_9_1_Coroutine()
		{
			return null;
		}

		private IEnumerator Tutorial_9_1_ShowDualWindow_Coroutine()
		{
			return null;
		}

		private void Tutorial_10_1()
		{
		}

		private IEnumerator Tutorial_10_1_Coroutine()
		{
			return null;
		}

		private void MovePointer(int targetPointerArrayIndex)
		{
		}

		private void MovePointerWithAnimation(int targetPointerArrayIndex, [Optional] Action onCompleted)
		{
		}

		private void OnPinch()
		{
		}

		private void ChageMapScale(float deltaDistance)
		{
		}

		public Vector3 GetNowPoint()
		{
			return default(Vector3);
		}

		private bool IsAreaSelectOperationEnabled()
		{
			return default(bool);
		}

		private bool IsDispJustAreaMapColorTexture()
		{
			return default(bool);
		}

		public Vector3 GetNowPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		private void ReflectPinchScale(float scaleValue)
		{
		}

		public void NhaamMove(int pointerIndex)
		{
		}

		public void PlayCloud()
		{
		}

		private void StopCloud()
		{
		}

		public QSAreaLandmarkElement[] GetLandmarkArray()
		{
			return null;
		}

		private void OnLandmarkAppearedCommon(QSAreaLandmarkElement landmarkElement)
		{
		}

		private int GetDotNum()
		{
			return default(int);
		}

		private void OnClickEventButton()
		{
		}

		public void CanvasActive(bool enable)
		{
		}

		private void CheckTrailer(UnityAction action)
		{
		}

		private float GetAim(Vector2 p1, Vector2 p2)
		{
			return default(float);
		}

		public void ChageChapter(bool isSupport)
		{
		}

		public void OnClickLeftArrow()
		{
		}

		public void OnClickRightArrow()
		{
		}

		private int GetMaxChapter()
		{
			return default(int);
		}

		private IEnumerator ChangeChapter(int groupId, bool isSupport = false)
		{
			return null;
		}

		public void OnToChapter()
		{
		}

		private bool CheckPlayNewLandmarkAnimationCondition(QSAreaLandmarkElement landmark)
		{
			return default(bool);
		}
	}
}

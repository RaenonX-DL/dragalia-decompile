using System;
using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class GrowthLimitBreak : SceneBase
	{
		public enum SkipEffectStatus
		{
			None,
			LimitBreakText,
			BeforeAmulet,
			AfterAmulet
		}

		public static ulong growBaseKeyId;

		public static bool isShowCaption;

		public Canvas mainCanvas;

		public Camera uiCamera;

		public Camera flashCamera;

		public GameObject effectBase;

		public Canvas bgCanvas;

		public Camera frontEffectCamera;

		public Camera backEffectCamera;

		private GrowthBaseType growthBaseType;

		private GrowthBaseInfoFrame growthBaseInfoFrame;

		private GrowResultBaseData oldGrowBaseData;

		private LimitBreakMaterialListBase materialListBase;

		private LimitBreakMaterialListController materialListController;

		private Dictionary<ulong, int> selectMaterialKeyList;

		private List<ulong> selectNumberKeyList;

		private GameObject limitBreakObj;

		private BaseCanvasContents baseCanvasContents;

		private BackButton backButton;

		private bool isVoiceLoadComplete;

		private string nowVoiceSheetName;

		private int limitbreakMargin;

		private int growStarIndex;

		private bool isStarAnimationEnd;

		private Coroutine setupEffectPopCoroutine;

		private Coroutine growAnimationDelayCoroutine;

		private Coroutine startStarGrowAnimationCoroutine;

		private Coroutine goResultCoroutine;

		private Coroutine waitLoadVoiceGroupCoroutine;

		private GameObject amuletAnimation;

		private GameObject amuletHeaderAnimation;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private EffectObject firstEffectObject;

		private bool isSkipButtonLocked;

		private SkipEffectStatus nowEffectStatus;

		private int effectSkipSortOderKey;

		private AudioPlayback amuletSePlayback;

		public const int materialTypeDragon = 7;

		public const int materialTypeWeapon = 3;

		public const int materialTypeAmulet = 12;

		public const int materialTypeItem = 8;

		public const int amuletEffectTriger = 10;

		private const string prefabPath = "Prefabs/OutGame/Growth/GrowthLimitBreak/";

		public const int itemKeyIdOffset = 100000;

		private const int DragonLimitBreakTypeDragon = 1;

		private const int DragonLimitBreakTypeMaterial = 2;

		private const int DragonLimitBreakTypeSphere = 3;

		private const int DragonLimitBreakTypeAwake = 4;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private IEnumerator SwitchToScreenSpaceCamera()
		{
			return null;
		}

		private void OnInitReady()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPresentReceived()
		{
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator ShowPointerDelay()
		{
			return null;
		}

		public void BackButtonPressed()
		{
		}

		private void LimitBreakButtonPressed()
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconPressAction(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void ShowMissingItemPopup(LimitBreakMaterialCellData itemData)
		{
		}

		private void SendUnLockUintData(ulong keyId, Action callBack)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void LoadMaterialDataList()
		{
		}

		private IEnumerator LoadMaterialDataListCoroutine()
		{
			return null;
		}

		public void OnSortButtonClicked()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType)
		{
			return null;
		}

		private void SendLimitBreakData()
		{
		}

		private GrowMaterialList[] SetupSendMaterialData()
		{
			return null;
		}

		private LimitBreakGrowList[] SetupSendDragonMaterialData()
		{
			return null;
		}

		private void SendDataOnSuccess(DragonLimitBreakResponse res)
		{
		}

		private void SendDataOnSuccess(WeaponLimitBreakResponse res)
		{
		}

		private void SendDataOnSuccess(AmuletLimitBreakResponse res)
		{
		}

		private void ShowLimitBreakEffect()
		{
		}

		private IEnumerator SetupEffectPop()
		{
			return null;
		}

		private void CloseEffectPop(UnityAction fadeEndCallBack)
		{
		}

		private IEnumerator GrowAnimationDelay(float time)
		{
			return null;
		}

		private void PlayLimitBreakFlash(Action playEndCallBack)
		{
		}

		private IEnumerator GoResult()
		{
			return null;
		}

		private IEnumerator WaitLoadVoiceGroup()
		{
			return null;
		}

		private IEnumerator StartStarGrowAnimation()
		{
			return null;
		}

		public void SkipGrowEffect()
		{
		}

		private IEnumerator PlayDragonVoiceCoroutine(TouchGuardObject touchGuard)
		{
			return null;
		}

		private void ShowResultDialog()
		{
		}

		public void SceneReload()
		{
		}

		private void UpdateLimitBreakMargin()
		{
		}

		private void ShowAmuletChangeEffect()
		{
		}

		private IEnumerator AmuletAnimationDelay(FlMotion awakeAnimeMotion)
		{
			return null;
		}

		private void CloseAmuletEffect()
		{
		}

		private void DeleteAmuletEffectObj()
		{
		}

		private void OnSkipButtonPressed(bool isBackKey = false)
		{
		}

		public static bool IsLimitBreakDragonBySphereMaterial(ulong dragonKeyId)
		{
			return default(bool);
		}

		public static bool IsLimitBreakDragonBySphereMaterial(int dragonMasterId, int nextLimitBreakCount)
		{
			return default(bool);
		}
	}
}

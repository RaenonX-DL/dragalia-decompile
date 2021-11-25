using System;
using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthMaterialSelectScene : SceneBase
	{
		public Canvas mainCanvas;

		public static ulong growBaseKeyId;

		public static bool isShowCaption;

		public Camera uiCamera;

		public Camera flashCamera;

		public GameObject effectBase;

		public Canvas bgCanvas;

		public Button effectSkipButton;

		private GrowthBaseType growthBaseType;

		private GrowthBaseInfoFrame growthBaseInfoFrame;

		private GrowResultBaseData oldGrowBaseData;

		private GrowMaterialListBase growMaterialListBase;

		private Dictionary<int, int> useItemInfoDict;

		private List<ulong> selectMaterialList;

		private bool isAllListIconLock;

		private GameObject levelUpObj;

		private GameObject hpPlusUpObj;

		private GameObject atkPlusUpObj;

		private bool isShowHpPlusEffect;

		private bool isShowAtkPlusEffect;

		private FlRoot levelUpFlRoot;

		private FlRoot hpPlusUpFlRoot;

		private FlRoot atkPlusUpFlRoot;

		private FlRoot manaUnleashFlRoot;

		private BaseCanvasContents baseCanvasContents;

		private BackButton backButton;

		private AudioPlayback seSoundPlayBack;

		private bool isSkipLevelup;

		private Coroutine growAnimationCoroutine;

		private Coroutine restartGrowAnimationCoroutine;

		private EffectObject growthEffect;

		private UseMaterialType receiveReloadType;

		private Coroutine closeEffectCoroutine;

		private GrowthManaCircleManaCircleData circleData;

		private GameObject manaUnleashObj;

		private GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;

		private int storyIndex;

		private string voiceSoundGroup;

		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthMaterialSelect/";

		private const int maxGrowMaterialCount = 20;

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

		private IEnumerator LoadMaterialListDataCoroutine()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator ShowPointerDelay()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public override void OnPresentReceived()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void GrowButtonPressed()
		{
		}

		private int MatTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell)
		{
			return default(int);
		}

		private void ConfigButtonPressed()
		{
		}

		private void ManaButtonPressed()
		{
		}

		private void LoadMaterialListData()
		{
		}

		private void PlatinumCrystalPressed()
		{
		}

		private void PlayUsePlatinumCrystalDirection()
		{
		}

		private void ShowUsePlatinumEffect(bool isLevelUp, bool isMaxLevel = false)
		{
		}

		public void FinishUsePlatinumEffect()
		{
		}

		public IEnumerator FinishUsePlatinumEffectCoroutine()
		{
			return null;
		}

		private IEnumerator ShowStoryPopupIfNeeded(UnityAction onCompleted)
		{
			return null;
		}

		private void UpdatePlatinumCrystalState()
		{
		}

		private void LoadItemListData()
		{
		}

		private void LoadUnitMaterialListData()
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType)
		{
			return null;
		}

		private void ListChangeCallBack()
		{
		}

		private void UpdateUseItem(int materialId, int count)
		{
		}

		private void UnitMaterialIconPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UnitMaterialIconLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UnSelectIcon(ulong targetKey)
		{
		}

		private void UpdateSelectIconNumber()
		{
		}

		private void UpdateTotalExp()
		{
		}

		private int GetMaterialExp(int materialLevel, int rarity)
		{
			return default(int);
		}

		private void UpeteGetExpPlus(int allExp, int hpPlus, int atkPlus)
		{
		}

		private void AutoSelectButtonPressed()
		{
		}

		private void ItemsAutoSelect(ItemMaterialCellData[] itemDatas, int expMargin)
		{
		}

		private void CountUpUseItem(int materialId, int addCount)
		{
		}

		private void UnitMaterialAutoSelect(GrowMaterialCellData[] materialDatas, int expMargin)
		{
		}

		public int CheckSelectIcon(ulong keyId)
		{
			return default(int);
		}

		private void SendGrowData()
		{
		}

		private GrowMaterialList[] SetupSendMaterialData()
		{
			return null;
		}

		private AtgenEnemyPiece[] SetupSendMaterialDataByChara()
		{
			return null;
		}

		private void SendDataOnSuccess(CharaBuildupResponse res)
		{
		}

		private void SendDataOnSuccess(DragonBuildupResponse res)
		{
		}

		private void SendDataOnSuccess(WeaponBuildupResponse res)
		{
		}

		private void SendDataOnSuccess(AmuletBuildupResponse res)
		{
		}

		private void ShowGrowthEffect()
		{
		}

		private void SetupGrowthEffectBg(UnityAction backKeyAction)
		{
		}

		private void PlayCharaIconEffect()
		{
		}

		private void LoadStrengthenLevelupPrefab()
		{
		}

		private void LoadManaUnleashPrefab()
		{
		}

		private IEnumerator SetupEffect(UnityAction<bool, bool> growAnimationEndCallBack, UnityAction afterSkipAction)
		{
			return null;
		}

		private void CloseEffectPop()
		{
		}

		private IEnumerator CloseEffectPopCoroutine()
		{
			return null;
		}

		private void ShowLevelupEffect(bool isLevelUp, bool isMaxLevel = false)
		{
		}

		private void PlayPlusupEffect()
		{
		}

		private void PlayLevelUpFlash(Action playEndCallBack)
		{
		}

		private void PlayHpPlusUpFlash(Action playEndCallBack)
		{
		}

		private void PlayAtkPlusUpFlash(Action playEndCallBack)
		{
		}

		private void PlayManaUnleashFlash(Action playEndCallBack)
		{
		}

		public void StopGaugeUpSe()
		{
		}

		private IEnumerator GrowAnimationCoroutine(float time)
		{
			return null;
		}

		private IEnumerator RestartGrowAnimationCoroutine()
		{
			return null;
		}

		public void SkipGrowEffect()
		{
		}

		private void ShowResultDialog()
		{
		}

		private IEnumerator FinishGrowEffect()
		{
			return null;
		}

		private void GoOtherScene(GrowResultDialogType type, NeedLimitMaterialType needLimitMaterialType)
		{
		}

		private void SetupTutorial(GrowMaterialListBase listBase)
		{
		}

		public void SceneReload()
		{
		}
	}
}

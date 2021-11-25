using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponEnhanceMainCanvas : GrowthUnitEnhanceMainCanvas
	{
		public TabBase statusCellTab;

		public GrowthUnitEnhanceListCell[] statusCells;

		public GrowthUnitEnhanceListCell[] specCells;

		public Text EmptySpecCellText;

		public GameObject craftEffectBaseObject;

		public RectTransform craftEffectResultButtonsRect;

		public Button closeButtonForCraftResult;

		public Text closeTextForCraftResult;

		public Badge growStatusBadge;

		public Badge growSpecBadge;

		private bool isShowEmptySpecCellText;

		private GameObject craftAnimation;

		private GameObject craftHeaderAnimation;

		private GameObject weaponModel;

		private BaseCanvasContents baseCanvasContents;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private List<FlMotion> outMotionList;

		private int effectSkipSortOderKey;

		private bool isShowSkinResultCloseButton;

		private Canvas uiCanvas;

		private Vector2 craftResultCloseButtonTargetPos;

		private Tweener craftResultCloseButtonTween;

		private RectTransform craftEffectResultCloseButtonRect;

		private int[] weaponSkinIds;

		private int[] effectMaterialIds;

		private FlashTextType playTextType;

		private bool isPlaySkinResultEffect;

		private bool isAllGetSkinEffectEned;

		private string skinResultLabelName;

		private int skinResultFrontEffectTrigger;

		private bool isSkipSkinResultEffect;

		private bool isTapAndBackKeyLockFlag;

		private AudioPlayback skinResultSePlayback;

		private int skinResultEffectSkinId;

		private bool isSkipSkinResultSound;

		private Coroutine skinResultEffectCoroutine;

		private int nowSkinId;

		public static GrowthUnitEnhanceMainCanvas GetUICanvas(Transform parentTransform)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model)
		{
		}

		public override void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, [Optional] Action effectEndCallBack)
		{
		}

		public void OnTabSelected(int index)
		{
		}

		public override void OnAutoButtonPressed()
		{
		}

		protected override GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type)
		{
			return null;
		}

		private void OnCellButtonPressed(UnitEnhanceListCellType type)
		{
		}

		private void InitTab()
		{
		}

		private void UpdateGrowBadge()
		{
		}

		protected override void UpdateCell()
		{
		}

		protected override bool IsAllCellComplete()
		{
			return default(bool);
		}

		protected override bool IsUsableAutoButton()
		{
			return default(bool);
		}

		private void ShowWeaponTypeAbilitySelectPopup()
		{
		}

		private void ShowWeaponTypeAbilityReleaseConfirmPopup(int[] selectIds)
		{
		}

		private void ShowWeaponLimitBreakResultPopup(int beforeLimitBreak, BitArray diffParam)
		{
		}

		private void ShowUpdateSkillAbilityPopup(BitArray diffParam)
		{
		}

		private void SendLimitOverData(int limitOver)
		{
		}

		private void SendWeaponTypeAbilityData(int[] selectAbilityDataIds)
		{
		}

		private GrowthUnitEnhanceSendData[] CreateSendWeaponTypeAbilityData(int[] abilityDataIds)
		{
			return null;
		}

		private void SendWeaponSlotData(int addSlotType1, int addSlotType2, int addSlotType3)
		{
		}

		private GrowthUnitEnhanceSendData[] CreateSendWeaponSlotData(int addSlotType1, int addSlotType2, int addSlotType3)
		{
			return null;
		}

		private void SendWeaponBonusData()
		{
		}

		private GrowthUnitEnhanceSendData[] CreateSendWeaponBonusData()
		{
			return null;
		}

		private void SendAutoEnhanceData(GrowthAutoUnitEnhanceConfirmPopup autoUnitEnhanceConfirmPopup, Action resultAction)
		{
		}

		private void ShowLimitOverResultPopup(int beforeLimitOver)
		{
		}

		private void ShowWeaponTypeAbilityResultPopup(int[] selectAbilitys)
		{
		}

		private void ShowWeaponSlotResultPopup(int beforeType1Slot, int beforeType2Slot, int beforeType3Slot)
		{
		}

		private void ShowWeaponBonusResultPopup()
		{
		}

		private void ShowAutoEnhanceResultPopup(int totalReleaseCount, int beforeBuildup, int beforePassiveAbilityCount, int beforeType1Slot, int beforeType2Slot, int beforeType3Slot, float beforeBonusHpParam, float beforeBonusAtkParam)
		{
		}

		private void SetupSkinEffectData(UnitEnhanceListCellType type, int toCount)
		{
		}

		private void SetupPassiveAbilitySkinEffectData(int[] selectAbilityDataIds)
		{
		}

		private void ShowGetSkinEffect(Action effectEndCallBack)
		{
		}

		private void PlayResultSkinEffect()
		{
		}

		private void SetupSkinEffect()
		{
		}

		private void CloseSkinEffect()
		{
		}

		private void PlayNextEffect(bool isBackKey = false)
		{
		}

		private void PlayGetSkinStartEffect(int skinId, int[] effectMaterialIds, Action startEffectEndCallBack)
		{
		}

		private IEnumerator PlayResultEffect(int skinId, bool isFirstEffect)
		{
			return null;
		}

		private void AfterResultAction()
		{
		}

		private void SkipSkinResultEffect(bool isBackKey = false)
		{
		}

		private void ShowCraftResultButtons(float duration, [Optional] Action onComplete)
		{
		}

		private void HideCraftResultButtons()
		{
		}

		private void DestoryButtonTween()
		{
		}

		private void CreateWeaponModel(int skinId)
		{
		}

		public void InitWeaponTransform(WeaponType weaponType)
		{
		}

		public void InitWeaponTransformGrowthWeaponObjectsSettings()
		{
		}
	}
}

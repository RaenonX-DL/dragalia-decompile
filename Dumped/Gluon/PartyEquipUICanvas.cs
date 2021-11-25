using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipUICanvas : AnimationUICanvas
	{
		[HideInInspector]
		public PartyEquipScene scene;

		public CommonIconListBase equipUnitListBase;

		public EquipUnitListController equipUnitListController;

		public Text characterNameText;

		public Text plusValueText;

		public Image charaElementIcon;

		public Image charaWeaponTypeIcon;

		public GameObject[] rarityIcons;

		public Text charaLvText;

		public Text totalPowerText;

		public Text totalPowerDeltaText;

		public Text charaCostText;

		public DragEventScrollRect dragScroll;

		public Button autoEquipButton;

		public Text autoEquipButtonText;

		public bool isDragEventActive;

		public UIAnimationPublisher enterExitPublisher;

		public CanvasGroup attributeMatchParentGroup;

		[SerializeField]
		private GameObject charaChangeArrowParent;

		[SerializeField]
		private TabBase typeTab;

		[SerializeField]
		private GameObject listButtonObj;

		[SerializeField]
		private GameObject skinButtonObj;

		[SerializeField]
		private PartyEquipCrestList crestList;

		[SerializeField]
		private GameObject unionBonusButton;

		[SerializeField]
		private GameObject crestSetButton;

		[SerializeField]
		private GameObject weaponAndDragonListGameObject;

		[SerializeField]
		private PartyEquipWeaponStatus weaponStatusUI;

		[SerializeField]
		private PartyEquipDragonStatus dragonStatusUI;

		[SerializeField]
		private PartyEquipCrestStatus crestStatusUI;

		private bool partyChangeFlg;

		private bool isLeftDrag;

		private int oldTotalPowerParam;

		private int nowTotalPowerParam;

		private SceneUICanvas sceneUiCanvas;

		private Color positiveFontColor;

		private Color negativeFontColor;

		private Color blackFontColor;

		private StepChangeParam totalPowerParam;

		private bool isFirstReload;

		private bool isPlayingEditSkillTutorial;

		private bool isUniqueWeaponChara;

		private float delayTime;

		private void Start()
		{
		}

		private IEnumerator SetStatusModeDelayed(float delayTime)
		{
			return null;
		}

		public void OnUnionBonusButtonPressed()
		{
		}

		private void InitActiveTab(int activeIndex)
		{
		}

		private bool IsDisabledCrestTab()
		{
			return default(bool);
		}

		public void UpdateTypeTab()
		{
		}

		public void UpdateWeaponStatus()
		{
		}

		public void UpdateDragonStatus()
		{
		}

		public void UpdateCrestStatus()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void SetStaticText()
		{
		}

		private void OmitTextAfterBestFit(Text text)
		{
		}

		public void Reload()
		{
		}

		public static bool IsEnablePeriodAbility(int abilityId)
		{
			return default(bool);
		}

		public void SetEquipUnitDiffParam()
		{
		}

		private void ShowDiffParam(Text text, int diffValue)
		{
		}

		private void SetCountUpDownParam()
		{
		}

		private void OnSelectedTypeTab(int typeIndex)
		{
		}

		private void SetTabMode(PartyModel.EquipMode nextMode)
		{
		}

		public void SetEquipListOutButton(PartyModel.EquipMode equipMode)
		{
		}

		public void OnWeaponBarPressed()
		{
		}

		public void OnAmulet2BarPressed()
		{
		}

		public void OnDragonBarPressed()
		{
		}

		private void ShowUnitDetail(UnitDetailModel.UnitDetailType type, ulong keyId)
		{
		}

		public void OnArrowButtonPressed(bool isRightButton)
		{
		}

		private void EquipListReload()
		{
		}

		public void ReloadCrestList()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnAutoButtonPressed()
		{
		}

		public void OnCharacterLongPressed()
		{
		}

		private void ShowSkillDetailDialog(PartyEquipSkillAbilityData data)
		{
		}

		private void ShowAbilityDetailDialog(PartyEquipSkillAbilityData data)
		{
		}

		private void ShowExAbilityDetailDialog(PartyEquipSkillAbilityData data, int index)
		{
		}

		public void StartExitAnimation(Action onFinished, Action onHalfFinished)
		{
		}

		private bool IsEnableCharacterChange()
		{
			return default(bool);
		}

		public void OnListChangeButtonPressed()
		{
		}

		public void OnSkinButtonPressed()
		{
		}

		public void DisableAllButton()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void OnCrestSetButtonPressed()
		{
		}

		private void ApplyCrestSetData(int setIndex)
		{
		}
	}
}

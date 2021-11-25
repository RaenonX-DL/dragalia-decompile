using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyUICanvasBase : AnimationUICanvas
	{
		public Text powerText;

		public Text totalPowerText;

		public GameObject recommendedPowerLabel;

		public GameObject requiredPowerLabel;

		[SerializeField]
		protected GameObject recommendedRaidPowerLabel;

		[SerializeField]
		protected GameObject myPowerBack;

		[SerializeField]
		protected GameObject myRaidPowerBack;

		private bool isPowerInitialized;

		protected float currentReferencePowerNum;

		private float displayReferencePowerNum;

		private float deltaReferencePowerNum;

		private int changeReferencePowerFrame;

		protected float currentTotalPowerNum;

		private float displayTotalPowerNum;

		private float deltaTotalPowerNum;

		private int changeTotalPowerFrame;

		private const float changeNumFrame = 8f;

		public Image eventBonusIcon;

		public Image[] exAbilityIcons;

		public Image[] exAbilityEmptyIcons;

		protected List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;

		[SerializeField]
		protected GameObject unionBonusButton;

		[SerializeField]
		protected Text switchButtonText;

		protected List<UnionBonusPopup.UnionBonusInfo> unionBonusCharaInfoList;

		[SerializeField]
		protected GameObject switchButtonObject;

		[SerializeField]
		protected Text switchButtonPageText;

		protected void SetBattlePointType(int questId, bool required)
		{
		}

		protected int GetBattlePoint(int questId)
		{
			return default(int);
		}

		protected virtual void Update()
		{
		}

		protected void ReflectPowerNum(int totalPowerNum, int referencePowerNum)
		{
		}

		protected void ReloadExAbilityIcon(CommonCharaExAbilityData[] exAbilityData)
		{
		}

		protected virtual void ReloadExAbilityIcon()
		{
		}

		protected virtual void RefreshEventBonusIcon()
		{
		}

		protected virtual bool IsRaidBoostOn(int questId)
		{
			return default(bool);
		}

		public virtual void OnEventBonusIconPressed()
		{
		}

		protected virtual void RefreshUnionBonus()
		{
		}

		public void OnUnionBonusButtonPressed()
		{
		}

		public void OnModeSwitchButtonPressed()
		{
		}

		protected virtual void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode)
		{
		}

		public void UpdateSwitchButtonText(PartyModel.PartySceneUnitStatusMode statusMode)
		{
		}

		public void UpdateSwitchButtonPageCount()
		{
		}

		public void ReloadStatusMode()
		{
		}
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyUICanvasBase : AnimationUICanvas
	{
		// Fields
		public UnityEngine.UI.Text powerText;
		public UnityEngine.UI.Text totalPowerText;
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
		protected UnityEngine.UI.Text switchButtonText;
		protected List<UnionBonusPopup.UnionBonusInfo> unionBonusCharaInfoList;
		[SerializeField]
		protected GameObject switchButtonObject;
		[SerializeField]
		protected UnityEngine.UI.Text switchButtonPageText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public EventBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _OnEventBonusIconPressed_b__0();
		}
	
		// Constructors
		public PartyUICanvasBase();
	
		// Methods
		protected void SetBattlePointType(int questId, bool required);
		protected int GetBattlePoint(int questId);
		protected virtual void Update();
		protected void ReflectPowerNum(int totalPowerNum, int referencePowerNum);
		protected void ReloadExAbilityIcon(CommonCharaExAbilityData[] exAbilityData);
		protected virtual void ReloadExAbilityIcon();
		protected virtual void RefreshEventBonusIcon();
		protected virtual bool IsRaidBoostOn(int questId);
		public virtual void OnEventBonusIconPressed();
		protected virtual void RefreshUnionBonus();
		public void OnUnionBonusButtonPressed();
		public void OnModeSwitchButtonPressed();
		protected virtual void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode);
		public void UpdateSwitchButtonText(PartyModel.PartySceneUnitStatusMode statusMode);
		public void UpdateSwitchButtonPageCount();
		public void ReloadStatusMode();
	}
}

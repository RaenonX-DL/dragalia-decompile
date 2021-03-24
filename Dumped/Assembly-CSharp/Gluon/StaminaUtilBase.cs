/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class StaminaUtilBase
	{
		// Fields
		[CompilerGenerated]
		private int _stamina_k__BackingField;
		[CompilerGenerated]
		private int _surplusSecond_k__BackingField;
		private int staminaFromServer;
		protected DateTime lastStaminaUpdateTime;
		protected List<CampaignDataElement> doubleCampaignList;
		protected List<CampaignDataElement> reduceCampaignList;
	
		// Properties
		public int stamina { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int surplusSecond { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public abstract int autoRecoveryStaminaMax { get; }
		public abstract int absoluteStaminaMax { get; }
		public abstract int autoRecoveryTimeInMinute { get; }
		public abstract StoneRecoverValue stoneRecoverValue { get; }
		public abstract StoneRecoverValue stoneRecoverValueForSpecialPack { get; }
	
		// Nested types
		public class StoneRecoverValue
		{
			// Fields
			public int priceStep;
			public int recoverPoint;
			public Dictionary<int, int> priceChange;
	
			// Properties
			public int stone { get; }
	
			// Constructors
			public StoneRecoverValue(Dictionary<int, int> priceChange, int recoverPoint);
	
			// Methods
			public void SetStep(int boughtCount);
		}
	
		// Constructors
		protected StaminaUtilBase();
	
		// Methods
		public abstract void ClearStoneRecoverValue();
		public abstract string GetStaminaText();
		public abstract List<UseItemElement> GetUsableItemList();
		public List<ItemList> GetHoldingUsableItemList();
		public void UpdateFromServer(int staminaFromServer, int lastUpdateTimeFromServer, int surplusSecond);
		public void UpdateManually();
		public abstract void ReloadCampaignData();
		public TimeSpan GetDiffFromLastUpdateWithCampaign(out TimeSpan campaignSpan);
		public void UpdateAutoRecovery();
		public int GetNextAddTimeInSeconds();
		public int GetFullRecoveryTimeInSeconds();
		public bool IsStaminaEnough(int requiredStamina);
		public bool IsStaminaFullForAutoRecovery();
		public bool CanApplyNonAutoRecoveryAction(int recoveryVal);
		public int GetMaxApplyableNonAutoRecoveryCount(int recoveryValPerItem, int holdingCount);
		public int GetMaxApplyableNonAutoRecoveryCountForStone(int holdingStone);
		public static StaminaUtilBase GetByType(bool isMulti);
		public bool IsMulti();
		public bool IsWithInDecreaseCampaign();
		public bool IsWithInDoubleCampaign();
		public int GetLeftDoubleCampaignTime();
		public CampaignDataElement GetWithInDecreaseCampaignDataElement(int groupId);
		public CampaignDataElement GetWithInDoubleCampaignDataElement(int groupId);
	}
}

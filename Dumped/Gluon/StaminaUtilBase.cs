using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public abstract class StaminaUtilBase
	{
		public class StoneRecoverValue
		{
			public int priceStep;

			public int recoverPoint;

			public Dictionary<int, int> priceChange;

			public int stone => default(int);

			public void SetStep(int boughtCount)
			{
			}

			public StoneRecoverValue(Dictionary<int, int> priceChange, int recoverPoint)
			{
			}
		}

		private int staminaFromServer;

		private static readonly DateTime oldDate;

		protected DateTime lastStaminaUpdateTime;

		protected List<CampaignDataElement> doubleCampaignList;

		protected List<CampaignDataElement> reduceCampaignList;

		public int stamina
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int surplusSecond
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public abstract int autoRecoveryStaminaMax { get; }

		public abstract int absoluteStaminaMax { get; }

		public abstract int autoRecoveryTimeInMinute { get; }

		public abstract StoneRecoverValue stoneRecoverValue { get; }

		public abstract StoneRecoverValue stoneRecoverValueForSpecialPack { get; }

		public abstract void ClearStoneRecoverValue();

		public abstract string GetStaminaText();

		public abstract List<UseItemElement> GetUsableItemList();

		public List<ItemList> GetHoldingUsableItemList()
		{
			return null;
		}

		public void UpdateFromServer(int staminaFromServer, int lastUpdateTimeFromServer, int surplusSecond)
		{
		}

		public void UpdateManually()
		{
		}

		public abstract void ReloadCampaignData();

		public TimeSpan GetDiffFromLastUpdateWithCampaign(out TimeSpan campaignSpan)
		{
			return default(TimeSpan);
		}

		public void UpdateAutoRecovery()
		{
		}

		private void SendErrorToFirebase(string errorType, string errorMessage)
		{
		}

		public int GetNextAddTimeInSeconds()
		{
			return default(int);
		}

		public int GetFullRecoveryTimeInSeconds()
		{
			return default(int);
		}

		public bool IsStaminaEnough(int requiredStamina)
		{
			return default(bool);
		}

		public bool IsStaminaFullForAutoRecovery()
		{
			return default(bool);
		}

		public bool CanApplyNonAutoRecoveryAction(int recoveryVal)
		{
			return default(bool);
		}

		public int GetMaxApplyableNonAutoRecoveryCount(int recoveryValPerItem, int holdingCount)
		{
			return default(int);
		}

		public int GetMaxApplyableNonAutoRecoveryCountForStone(int holdingStone)
		{
			return default(int);
		}

		public static StaminaUtilBase GetByType(bool isMulti)
		{
			return null;
		}

		public bool IsMulti()
		{
			return default(bool);
		}

		public bool IsWithInDecreaseCampaign()
		{
			return default(bool);
		}

		public bool IsWithInDoubleCampaign()
		{
			return default(bool);
		}

		public int GetLeftDoubleCampaignTime()
		{
			return default(int);
		}

		public CampaignDataElement GetWithInDecreaseCampaignDataElement(int groupId)
		{
			return null;
		}

		public CampaignDataElement GetWithInDoubleCampaignDataElement(int groupId)
		{
			return null;
		}
	}
}

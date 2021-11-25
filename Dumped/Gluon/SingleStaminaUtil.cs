using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class SingleStaminaUtil : StaminaUtilBase
	{
		private static SingleStaminaUtil instance;

		private StoneRecoverValue _stoneRecoverValue;

		private StoneRecoverValue _stoneRecoverValueForSpecialPack;

		public static SingleStaminaUtil Instance => null;

		public override StoneRecoverValue stoneRecoverValue => null;

		public override StoneRecoverValue stoneRecoverValueForSpecialPack => null;

		public override int autoRecoveryStaminaMax => default(int);

		public override int absoluteStaminaMax => default(int);

		public override int autoRecoveryTimeInMinute => default(int);

		public static void DeleteInstance()
		{
		}

		private SingleStaminaUtil()
		{
		}

		static SingleStaminaUtil()
		{
		}

		public override void ReloadCampaignData()
		{
		}

		public override void ClearStoneRecoverValue()
		{
		}

		public override string GetStaminaText()
		{
			return null;
		}

		public override List<UseItemElement> GetUsableItemList()
		{
			return null;
		}
	}
}

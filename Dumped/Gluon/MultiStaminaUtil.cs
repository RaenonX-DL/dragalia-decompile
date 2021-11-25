using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class MultiStaminaUtil : StaminaUtilBase
	{
		private static MultiStaminaUtil instance;

		private StoneRecoverValue _stoneRecoverValue;

		private StoneRecoverValue _stoneRecoverValueForSpecialPack;

		public static MultiStaminaUtil Instance => null;

		public override int autoRecoveryStaminaMax => default(int);

		public override int absoluteStaminaMax => default(int);

		public override int autoRecoveryTimeInMinute => default(int);

		public override StoneRecoverValue stoneRecoverValue => null;

		public override StoneRecoverValue stoneRecoverValueForSpecialPack => null;

		public static void DeleteInstance()
		{
		}

		private MultiStaminaUtil()
		{
		}

		static MultiStaminaUtil()
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

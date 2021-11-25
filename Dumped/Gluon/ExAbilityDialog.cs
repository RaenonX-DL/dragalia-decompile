using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class ExAbilityDialog : CommonPopup
	{
		public ExAbilityDialogListBase[] dialogListBase;

		public static ExAbilityDialog Create(string dialogPath, bool showBlackLayer = true)
		{
			return null;
		}

		public void SetupExAbiltyDialog(PartyList partyList)
		{
		}

		public void SetupExAbiltyDialog(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas)
		{
		}

		public void SetupExAbiltyDialog(CommonPartyPowerCalculateData[] questPartyData)
		{
		}
	}
}

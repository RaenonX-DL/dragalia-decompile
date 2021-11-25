using System;
using Gluon.Http;

namespace Gluon
{
	public class PartyChangeQuestClearPartyRegistPopup : CommonPopup
	{
		public PartyChangePopupCell fromSetCell;

		public PartyChangePopupCell toSetCell;

		public static PartyChangeQuestClearPartyRegistPopup Create()
		{
			return null;
		}

		public void InitPopup(PartyList questClearParty, int partyIndex, Action registAction)
		{
		}
	}
}

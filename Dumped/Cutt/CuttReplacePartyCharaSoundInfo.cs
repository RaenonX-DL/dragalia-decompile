using System;
using System.Collections.Generic;

namespace Cutt
{
	[Serializable]
	public class CuttReplacePartyCharaSoundInfo
	{
		public string replaceLabel;

		public CuttCharacterInitializeData.PartyCharacterType partyType;

		public List<CuttReplacePartyCharaSoundData> replaceList;

		public CuttReplacePartyCharaSoundInfo(string label, CuttCharacterInitializeData.PartyCharacterType type, List<CuttReplacePartyCharaSoundData> list)
		{
		}
	}
}

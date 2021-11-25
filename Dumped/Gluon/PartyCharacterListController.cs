using Gluon.Http;

namespace Gluon
{
	public class PartyCharacterListController : CommonIconListController
	{
		public bool isOutButtonSelect;

		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		public void SelectPartyInfoUpdate(PartySettingList[] partyList)
		{
		}

		public void SetSelectIconToOutButton(bool isShowSelect)
		{
		}
	}
}

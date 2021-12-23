using System.Collections.Generic;

namespace Gluon
{
	public class DmodeExpeditionCharaController : CommonIconListController
	{
		public bool isOutButtonSelect;

		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		public void SetSelectIconToOutButton(bool isShowSelect)
		{
		}

		public void ShowCharaDetail(CommonIconListCellData charaData)
		{
		}

		public void ShowCharaDetail(int charaId)
		{
		}

		public void UpdateMemberList(List<int> memberList)
		{
		}
	}
}

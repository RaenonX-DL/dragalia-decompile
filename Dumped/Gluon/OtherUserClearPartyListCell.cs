using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class OtherUserClearPartyListCell : TableViewCell<OtherUserClearPartyListCellData>
	{
		public CommonUnitIcon[] charaIcons;

		public GameObject[] emptyCharaIcons;

		[SerializeField]
		private Text[] partyChangeButtonTextList;

		[SerializeField]
		[Header("PartySwitchç\u0094\u00a8")]
		public CommonUnitIcon[] secondCharaIcons;

		public GameObject[] secondEmptyCharaIcons;

		public Action<int, int> sampleButtonCallBack;

		private OtherUserClearPartyListCellData cellData;

		public void SetUpButtonText(bool isSoloQuest)
		{
		}

		public override void UpdateContent(OtherUserClearPartyListCellData cellData)
		{
		}

		public void OnSampleButtonPressed(int partySwitchIndex)
		{
		}
	}
}

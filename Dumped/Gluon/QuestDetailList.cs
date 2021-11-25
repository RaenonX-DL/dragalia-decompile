using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestDetailList : QuestListBase
	{
		[SerializeField]
		private Transform contentTransfrom;

		public AnimationListOneCol listAnimation;

		private List<QuestDataElement> questDataList;

		public void SetContent(List<QuestCellData> givenCellDataList, QuestCell.SubType subType)
		{
		}

		private void LoadData(List<QuestCellData> givencellDataList)
		{
		}

		private void CreateList(List<QuestCellData> givencellDataList, QuestCell.SubType subType)
		{
		}
	}
}

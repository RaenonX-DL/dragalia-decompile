using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QRBonusRewardHoledPopup : QuestResultCommonPopup
	{
		[SerializeField]
		private QRBonusRewardTableViewController questRewardTableViewController;

		[SerializeField]
		private GameObject bonusPlusImage;

		private QuestResultModel.QuestBonus model;

		public static QRBonusRewardHoledPopup Create([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public static QRBonusRewardHoledPopup CreateWithModel(QuestResultModel.QuestBonus model, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public static QRBonusRewardHoledPopup Create(List<QuestResultModel.QuestBonus.QuestBonusInfo> list, string title, string mainText, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public void SetBonusPlusImage()
		{
		}
	}
}

using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestScheduleDetailElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ScheduleGroupId;

		[SerializeField]
		private int _DropBonusPercent;

		[SerializeField]
		private QuestGroupIntervalType _QuestIntervalType;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		[SerializeField]
		private int _LimitShopGoodsType;

		public int Id => default(int);

		public int ScheduleGroupId => default(int);

		public int DropBonusPercent => default(int);

		public QuestGroupIntervalType QuestIntervalType => default(QuestGroupIntervalType);

		public string StartDate => null;

		public string EndDate => null;

		public int LimitShopGoodsType => default(int);
	}
}

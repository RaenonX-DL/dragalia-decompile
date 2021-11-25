using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestWallMonthlyRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TotalWallLevel;

		[SerializeField]
		private int _RewardStageNum;

		[SerializeField]
		private string _RewardImage;

		[SerializeField]
		private int _IsShowBadge;

		[SerializeField]
		private GiftType _RewardEntityType;

		[SerializeField]
		private int _RewardEntityId;

		[SerializeField]
		private int _RewardEntityQuantity;

		[SerializeField]
		private string _ReceiveStartDate;

		[SerializeField]
		private string _ReceiveEndDate;

		public int Id => default(int);

		public int TotalWallLevel => default(int);

		public int RewardStageNum => default(int);

		public string RewardImage => null;

		public int IsShowBadge => default(int);

		public GiftType RewardEntityType => default(GiftType);

		public int RewardEntityId => default(int);

		public int RewardEntityQuantity => default(int);

		public string ReceiveStartDate => null;

		public string ReceiveEndDate => null;
	}
}

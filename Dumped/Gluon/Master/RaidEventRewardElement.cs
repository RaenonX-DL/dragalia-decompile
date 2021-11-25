using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _RaidEventItemId;

		[SerializeField]
		private int _RaidEventItemQuantity;

		[SerializeField]
		private int _IsShowBadge;

		[SerializeField]
		private GiftType _RewardEntityType;

		[SerializeField]
		private int _RewardEntityId;

		[SerializeField]
		private int _RewardEntityQuantity;

		public int Id => default(int);

		public int RaidEventItemId => default(int);

		public int RaidEventItemQuantity => default(int);

		public int IsShowBadge => default(int);

		public GiftType RewardEntityType => default(GiftType);

		public int RewardEntityId => default(int);

		public int RewardEntityQuantity => default(int);
	}
}

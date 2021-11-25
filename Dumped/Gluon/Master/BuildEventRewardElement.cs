using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventItemId;

		[SerializeField]
		private int _EventItemQuantity;

		[SerializeField]
		private int _IsShowBadge;

		[SerializeField]
		private GiftType _RewardEntityType;

		[SerializeField]
		private int _RewardEntityId;

		[SerializeField]
		private int _RewardEntityQuantity;

		public int Id => default(int);

		public int EventItemId => default(int);

		public int EventItemQuantity => default(int);

		public int IsShowBadge => default(int);

		public GiftType RewardEntityType => default(GiftType);

		public int RewardEntityId => default(int);

		public int RewardEntityQuantity => default(int);
	}
}

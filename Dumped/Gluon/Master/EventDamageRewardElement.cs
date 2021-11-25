using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventDamageRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private long _DamageValue;

		[SerializeField]
		private int _IsShowBadge;

		[SerializeField]
		private GiftType _RewardEntityType;

		[SerializeField]
		private int _RewardEntityId;

		[SerializeField]
		private int _RewardEntityQuantity;

		public int Id => default(int);

		public int EventId => default(int);

		public long DamageValue => default(long);

		public int IsShowBadge => default(int);

		public GiftType RewardEntityType => default(GiftType);

		public int RewardEntityId => default(int);

		public int RewardEntityQuantity => default(int);
	}
}

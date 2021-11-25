using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CombatEventLocationRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _LocationRewardId;

		[SerializeField]
		private GiftType _EntityType;

		[SerializeField]
		private int _EntityId;

		[SerializeField]
		private int _EntityQuantity;

		public int Id => default(int);

		public int EventId => default(int);

		public int LocationRewardId => default(int);

		public GiftType EntityType => default(GiftType);

		public int EntityId => default(int);

		public int EntityQuantity => default(int);
	}
}

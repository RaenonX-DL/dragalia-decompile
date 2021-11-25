using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LoginBonusRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Gid;

		[SerializeField]
		private int _Day;

		[SerializeField]
		private GiftType _EntityType;

		[SerializeField]
		private int _EntityId;

		[SerializeField]
		private int _EntityQuantity;

		[SerializeField]
		private int _EntityLevel;

		[SerializeField]
		private int _EntityLimitBreakCount;

		[SerializeField]
		private int _EntityBuildupCount;

		[SerializeField]
		private int _EntityEquipableCount;

		[SerializeField]
		private string _AnimationSetting;

		public int Id => default(int);

		public int Gid => default(int);

		public int Day => default(int);

		public GiftType EntityType => default(GiftType);

		public int EntityId => default(int);

		public int EntityQuantity => default(int);

		public int EntityLevel => default(int);

		public int EntityLimitBreakCount => default(int);

		public int EntityBuildupCount => default(int);

		public int EntityEquipableCount => default(int);

		public string AnimationSetting => null;
	}
}

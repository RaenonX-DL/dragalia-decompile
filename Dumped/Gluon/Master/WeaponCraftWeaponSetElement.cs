using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftWeaponSetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _WeaponId1;

		[SerializeField]
		private int _WeaponLimitBreakCount1;

		[SerializeField]
		private int _WeaponId2;

		[SerializeField]
		private int _WeaponLimitBreakCount2;

		[SerializeField]
		private int _WeaponId3;

		[SerializeField]
		private int _WeaponLimitBreakCount3;

		[SerializeField]
		private int _WeaponId4;

		[SerializeField]
		private int _WeaponLimitBreakCount4;

		[SerializeField]
		private int _WeaponId5;

		[SerializeField]
		private int _WeaponLimitBreakCount5;

		public int Id => default(int);

		public int WeaponId1 => default(int);

		public int WeaponLimitBreakCount1 => default(int);

		public int WeaponId2 => default(int);

		public int WeaponLimitBreakCount2 => default(int);

		public int WeaponId3 => default(int);

		public int WeaponLimitBreakCount3 => default(int);

		public int WeaponId4 => default(int);

		public int WeaponLimitBreakCount4 => default(int);

		public int WeaponId5 => default(int);

		public int WeaponLimitBreakCount5 => default(int);
	}
}
